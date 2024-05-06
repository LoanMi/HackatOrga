using HackatOrga.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatOrga
{
    public partial class Modify : Form
    {
        Boolean urlValide = true;
        Hackaton unHackaton = Menu.ValueHackaton;

        HackatonContext cnx = new HackatonContext();
        public Modify()
        {
            InitializeComponent();
        }



        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }




        private void Modify_Load(object sender, EventArgs e)
        {
            tbxNom.Text = unHackaton.Nom;
            tbxTheme.Text = unHackaton.Theme;
            tbxAddresse.Text = unHackaton.Addresse;
            numPlaces.Value = unHackaton.NbPlace;
            dtpDateDeb.Value = unHackaton.DateDeb.ToDateTime(TimeOnly.Parse("10:00 PM")); ;
            dtpDateFin.Value = unHackaton.DateFin.ToDateTime(TimeOnly.Parse("10:00 PM")); ;

            cbbVille.DataSource = cnx.Villes.ToList(); ;
            cbbVille.DisplayMember = "nom";
            cbbVille.SelectedIndex = (int)unHackaton.IdVille - 1;
            tbxURL.Text = unHackaton.Image;



            System.String url = tbxURL.Text;
            try
            {
                var request = WebRequest.Create(url);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    piBimage.Image = ResizeImage(System.Drawing.Bitmap.FromStream(stream), 200, 126);
                }
                labError.Text = "";
            }

            catch 
            {
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Ville ville = new Ville();
            ville = cnx.Villes.Where(ville => ville.Nom == cbbVille.Text).FirstOrDefault();

            unHackaton.NbPlace = Convert.ToInt16(numPlaces.Value);
            unHackaton.Theme = tbxTheme.Text;
            unHackaton.Addresse = tbxAddresse.Text;
            unHackaton.IdVilleNavigation = ville;
            unHackaton.DateDeb = DateOnly.FromDateTime(dtpDateDeb.Value);
            unHackaton.DateFin = DateOnly.FromDateTime(dtpDateFin.Value);
            unHackaton.Nom = tbxNom.Text;
            unHackaton.Image = tbxURL.Text;



            cnx.Update(unHackaton);
            cnx.SaveChanges();
            this.Hide();
            (new Menu()).Show();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            (new Menu()).Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxURL_TextChanged(object sender, EventArgs e)
        {

            System.String url = tbxURL.Text;
            try
            {
                var request = WebRequest.Create(url);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    piBimage.Image = ResizeImage(System.Drawing.Bitmap.FromStream(stream), 200, 126);
                }
                labError.Text = "";
                urlValide = true;
            }

            catch (Exception ex)
            {
                labError.Text = "Url incorect";
                piBimage.Image = null;
                urlValide = false;
            }


        }

        private void piBimage_Click(object sender, EventArgs e)
        {

        }
    }
}
