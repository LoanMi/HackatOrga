using HackatOrga.Models;
using Aspose.Pdf;
using Aspose.Pdf.Text;

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

            lsthackat.DataSource = cnx.Hackatons.OrderBy(cli => cli.Theme).ToList(); ;
            lsthackat.DisplayMember = "Theme";
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

        }

        private void btnEvent_Click(object sender, EventArgs e)
        {

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

            var equipes  =  cnx.Equipes.Where(c => c.IdHackaton == ValueHackaton.Id).ToList();

            string lstPDF = "";



            // Initialiser l'objet document 
            Aspose.Pdf.Document document = new Aspose.Pdf.Document();

            // Ajouter une page
            Aspose.Pdf.Page page = document.Pages.Add();


            // Add Header
            var header = new TextFragment("Liste des Participant");
            header.TextState.Font = FontRepository.FindFont("Arial");
            header.TextState.FontSize = 24;
            header.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            header.Position = new Position(130, 720);
            page.Paragraphs.Add(header);



            foreach (Equipe equipe in equipes)
            {


                foreach (Utilisateur utilisateur in equipe.Utilisateurs)
                {
                    lstPDF += utilisateur.Nom + utilisateur.Prenom + " \n";
                }
                    // Add description
                    var descriptionText = equipe.Utilisateurs;
             //   var description = new TextFragment(descriptionText);
             //   description.TextState.Font = FontRepository.FindFont("Times New Roman");
                //description.TextState.FontSize = 14;
                //description.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Left;
                //page.Paragraphs.Add(description);


                // Enregistrer le PDF 
                document.Save("C:\\Users\\loaki\\Desktop\\document.pdf");
                //+ equipe.NomEquipe +



               


                   









                


            }
            
            

        }
    }
}