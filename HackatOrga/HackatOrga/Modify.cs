using HackatOrga.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatOrga
{
    public partial class Modify : Form
    {
        HackatonContext cnx = new HackatonContext();
        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {

            Hackaton unHackaton = Menu.ValueHackaton;
            tbxTheme.Text = unHackaton.Theme;
            tbxAddresse.Text = unHackaton.Addresse;
            numPlaces.Value = unHackaton.NbPlace;
            dtpDateDeb.Value = unHackaton.DateDeb.ToDateTime(TimeOnly.Parse("10:00 PM")); ;
            dtpDateFin.Value = unHackaton.DateFin.ToDateTime(TimeOnly.Parse("10:00 PM")); ;

            cbbVille.DataSource = cnx.Villes.ToList(); ; 
            cbbVille.DisplayMember = "nom";
            cbbVille.SelectedIndex = (int)unHackaton.IdVille - 1;


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Menu()).Show();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
