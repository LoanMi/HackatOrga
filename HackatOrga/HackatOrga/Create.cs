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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.DataFormats;

namespace HackatOrga
{
    public partial class Create : Form
    {

        HackatonContext cnx = new HackatonContext();
        Boolean urlValide = true;
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            cbbVille.DataSource = cnx.Villes.OrderBy(cli => cli.Nom).ToList();
            cbbVille.DisplayMember = "nom";




        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Ville ville = new Ville();
            ville = cnx.Villes.Where(ville => ville.Nom == cbbVille.Text).FirstOrDefault();
            string txtUrl;



            if (urlValide)
            {
                txtUrl = tbxURL.Text;
            }
            else { txtUrl = ""; }

            Hackaton newHackaton = new Hackaton()
            {
                NbPlace = Convert.ToInt16(numPlaces.Value),
                Theme = tbxTheme.Text,
                Addresse = tbxAddresse.Text,
                IdVilleNavigation = ville,
                DateDeb = DateOnly.FromDateTime(dtpDateDeb.Value),
                DateFin = DateOnly.FromDateTime(dtpDateFin.Value),
                Nom = tbxNom.Text,
                Image = txtUrl,



            };

            //Ajout de l'objet au dataContext
            cnx.Hackatons.Add(newHackaton);
            //Enregistrement dans la BD
            cnx.SaveChanges();

            (new Menu()).Show();
            this.Close();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            (new Menu()).Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

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





        private void textBox1_TextChanged(object sender, EventArgs e)
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
                lbError.Text = "";
                urlValide = true;
            }

            catch 
            {
                lbError.Text = "Url incorect";
                piBimage.Image = null;
                urlValide = false;
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
