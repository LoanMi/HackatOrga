using HackatOrga.Models;
namespace HackatOrga
{
    public partial class Menu : Form
    {
        HackatonContext cnx = new HackatonContext();
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
            this.Close();
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
            this.Close();


        }

        private void lsthackat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsthackat.SelectedIndex >= 0)
            {
                //On récupère le client choisi dans la liste
                Hackaton unHackaton = (Hackaton)lsthackat.SelectedItem;
                btnLstP.Enabled = true;
                btnEvent.Enabled = true;
                btnSupp.Enabled = true;
                btnMod.Enabled = true;
            };
        }
    }
}