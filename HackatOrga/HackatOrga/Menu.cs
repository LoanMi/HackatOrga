using HackatOrga.Models;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Microsoft.EntityFrameworkCore;
using Aspose.Pdf.Operators;
using System.Diagnostics;
using Microsoft.Win32;

namespace HackatOrga

{
    public partial class Menu : Form
    {
        HackatonContext cnx = new HackatonContext();
        public static Hackaton ValueHackaton;

        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

            lsthackat.DataSource = cnx.Hackatons.OrderBy(cli => cli.Theme).ToList();
            lsthackat.DisplayMember = "Nom";
            lsthackat.SelectedIndex = -1;
            btnLstP.Enabled = false;
            btnEvent.Enabled = false;
            btnSupp.Enabled = false;
            btnMod.Enabled = false;
        }

        private void cmbHackat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Modify()).Show();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtez-vous sur de voiloir supprimer le Hackaton " + ValueHackaton.Nom, "Suppression", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cnx.Remove((Hackaton)lsthackat.SelectedItem);
                cnx.SaveChanges();
                lsthackat.DataSource = cnx.Hackatons.OrderBy(cli => cli.Theme).ToList(); ;

            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Event()).Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            (new Create()).Show();
            this.Hide();


        }

        private void lsthackat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsthackat.SelectedIndex >= 0)
            {
                //On récupère le client choisi dans la liste

                Hackaton unHackaton = (Hackaton)lsthackat.SelectedItem;
                ValueHackaton = unHackaton;
                btnLstP.Enabled = true;
                btnEvent.Enabled = true;
                btnSupp.Enabled = true;
                btnMod.Enabled = true;

            };
        }

        private void btnLstP_Click(object sender, EventArgs e)
        {

            var listequipes = cnx.Equipes.Where(c => c.IdHackaton == ValueHackaton.Id).Include(c => c.Utilisateurs).ToList();

            string lstPDF = "";



            // Initialiser l'objet document 
            Aspose.Pdf.Document document = new Aspose.Pdf.Document();

            // Ajouter une page
            Aspose.Pdf.Page page = document.Pages.Add();




            // Add Header
            var header = new TextFragment("Liste des Participant dans " + ValueHackaton.Nom);
            header.TextState.Font = FontRepository.FindFont("Arial");
            header.TextState.FontSize = 24;
            header.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            header.Position = new Position(130, 720);
            page.Paragraphs.Add(header);



            foreach (Equipe equipe in listequipes)
            {
                lstPDF += " \n \n \n \n" + equipe.NomEquipe + " : \n \n ";
                foreach (Utilisateur utilisateur in equipe.Utilisateurs)
                {
                    lstPDF += utilisateur.Nom + utilisateur.Prenom + " \n";
                }


            }
            var descriptionText = lstPDF;
            var description = new TextFragment(descriptionText);
            description.TextState.Font = FontRepository.FindFont("Times New Roman");
            description.TextState.FontSize = 14;
            description.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Left;
            page.Paragraphs.Add(description);


            // Enregistrer le PDF 
            document.Save("C:\\Users\\loaki\\Desktop\\document.pdf");

            
            
            
            
            
            
            
            
            Process.Start(GetSystemDefaultBrowser(), "C:\\Users\\loaki\\Desktop\\document.pdf");

        }


        internal string GetSystemDefaultBrowser()
        {
            string name = string.Empty;
            RegistryKey regKey = null;

            try
            {
                //set the registry key we want to open
                regKey = Registry.ClassesRoot.OpenSubKey("HTTP\\shell\\open\\command", false);

                //get rid of the enclosing quotes
                name = regKey.GetValue(null).ToString().ToLower().Replace("" + (char)34, "");

                //check to see if the value ends with .exe (this way we can remove any command line arguments)
                if (!name.EndsWith("exe"))
                    //get rid of all command line arguments (anything after the .exe must go)
                    name = name.Substring(0, name.LastIndexOf(".exe") + 4);

            }
            catch (Exception ex)
            {
                name = string.Format("ERROR: An exception of type: {0} occurred in method: {1} in the following module: {2}", ex.GetType(), ex.TargetSite, this.GetType());
            }
            finally
            {
                //check and see if the key is still open, if so
                //then close it
                if (regKey != null)
                    regKey.Close();
            }
            //return the value
            return name;
        }
            private void btnStatistiques_Click(object sender, EventArgs e)
        {
            (new Statistique()).Show();
            this.Hide();
        }
    }
}