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
    public partial class Event : Form
    {
        HackatonContext cnx = new HackatonContext();
        public Event()
        {
            InitializeComponent();
        }

        private void Evenement_Load(object sender, EventArgs e)
        {
            List<string> listType = new List<string>();
            listType.Add("Atelier");
            listType.Add("Conférence");
            cbType.DataSource = listType;
            cbType.DisplayMember = "Name";
            cbType.SelectedIndex = 0;


            cbIntervenant.DataSource = cnx.Intervenants.OrderBy(cli => cli.Nom).ToList(); ;
            cbIntervenant.DisplayMember = "Nom";
            cbIntervenant.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Type_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                labThNb.Location = new Point(234, 283);
                labThNb.Text = "Nombre place :";
                nudPlace.Visible = true;
                cbIntervenant.Visible = false;
                txbTheme.Visible = false;
                labIntervenant.Visible = false;
            }
            else if (cbType.SelectedIndex == 1)
            {
                labThNb.Location = new Point(287, 283);
                labThNb.Text = "Thème :";
                nudPlace.Visible = false;
                cbIntervenant.Visible = true;
                txbTheme.Visible = true;
                labIntervenant.Visible = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbIntervenant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {

                Evenement newEvenement = new Evenement()
                {

                    IdHackaton = Menu.ValueHackaton.Id,
                    Salle = txbSalle.Text,
                    DateDeb = DateOnly.FromDateTime(dtpDeb.Value),
                    DateFin = DateOnly.FromDateTime(dtpFin.Value),
                    Type = "place",
                    //theme
                    NbPlace = Convert.ToInt16(nudPlace.Value),
                    //idIntervenant	

                };


                //Ajout de l'objet au dataContext
                cnx.Evenements.Add(newEvenement);
                //Enregistrement dans la BD
                cnx.SaveChanges();

            }

            else
            {
                Evenement newEvenement = new Evenement()
                {
                    IdHackaton = Menu.ValueHackaton.Id,
                    Salle = txbSalle.Text,
                    DateDeb = DateOnly.FromDateTime(dtpDeb.Value),
                    DateFin = DateOnly.FromDateTime(dtpFin.Value),
                    Type = "theme",
                    Theme = txbTheme.Text,
                    //nbPlace
                    IdIntervenant = cbIntervenant.SelectedIndex



                };


                //Ajout de l'objet au dataContext
                cnx.Evenements.Add(newEvenement);
                //Enregistrement dans la BD
                cnx.SaveChanges();


            }





        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            (new Menu()).Show();
            this.Hide();
        }
    }
}
