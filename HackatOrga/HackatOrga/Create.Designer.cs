namespace HackatOrga
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbError = new Label();
            label7 = new Label();
            tbxURL = new TextBox();
            piBimage = new PictureBox();
            Nom = new Label();
            tbxNom = new TextBox();
            numPlaces = new NumericUpDown();
            label5 = new Label();
            cbbVille = new ComboBox();
            dtpDateDeb = new DateTimePicker();
            dtpDateFin = new DateTimePicker();
            btnCreer = new Button();
            tbxAddresse = new TextBox();
            tbxTheme = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Theme = new Label();
            btnMenu = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piBimage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlaces).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbError);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbxURL);
            groupBox1.Controls.Add(piBimage);
            groupBox1.Controls.Add(Nom);
            groupBox1.Controls.Add(tbxNom);
            groupBox1.Controls.Add(numPlaces);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbbVille);
            groupBox1.Controls.Add(dtpDateDeb);
            groupBox1.Controls.Add(dtpDateFin);
            groupBox1.Controls.Add(btnCreer);
            groupBox1.Controls.Add(tbxAddresse);
            groupBox1.Controls.Add(tbxTheme);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Theme);
            groupBox1.Location = new Point(72, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hackaton";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbError.ForeColor = Color.Red;
            lbError.Location = new Point(309, 332);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 15);
            lbError.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(490, 286);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 19;
            label7.Text = "url Image :";
            label7.Click += label7_Click_1;
            // 
            // tbxURL
            // 
            tbxURL.Location = new Point(309, 304);
            tbxURL.Name = "tbxURL";
            tbxURL.Size = new Size(416, 23);
            tbxURL.TabIndex = 18;
            tbxURL.TextChanged += textBox1_TextChanged;
            // 
            // piBimage
            // 
            piBimage.Location = new Point(59, 250);
            piBimage.Name = "piBimage";
            piBimage.Size = new Size(200, 126);
            piBimage.TabIndex = 17;
            piBimage.TabStop = false;
            piBimage.Click += pictureBox1_Click;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(230, 30);
            Nom.Name = "Nom";
            Nom.Size = new Size(40, 15);
            Nom.TabIndex = 16;
            Nom.Text = "Nom :";
            Nom.Click += label7_Click;
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(302, 22);
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(100, 23);
            tbxNom.TabIndex = 15;
            // 
            // numPlaces
            // 
            numPlaces.Location = new Point(507, 65);
            numPlaces.Name = "numPlaces";
            numPlaces.Size = new Size(120, 23);
            numPlaces.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 128);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 14;
            label5.Text = "Ville :";
            // 
            // cbbVille
            // 
            cbbVille.FormattingEnabled = true;
            cbbVille.Location = new Point(124, 128);
            cbbVille.Name = "cbbVille";
            cbbVille.Size = new Size(122, 23);
            cbbVille.TabIndex = 13;
            // 
            // dtpDateDeb
            // 
            dtpDateDeb.Location = new Point(59, 208);
            dtpDateDeb.Name = "dtpDateDeb";
            dtpDateDeb.Size = new Size(200, 23);
            dtpDateDeb.TabIndex = 12;
            // 
            // dtpDateFin
            // 
            dtpDateFin.Location = new Point(463, 208);
            dtpDateFin.Name = "dtpDateFin";
            dtpDateFin.Size = new Size(200, 23);
            dtpDateFin.TabIndex = 11;
            // 
            // btnCreer
            // 
            btnCreer.Location = new Point(309, 395);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(75, 23);
            btnCreer.TabIndex = 10;
            btnCreer.Text = "Ajouter";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // tbxAddresse
            // 
            tbxAddresse.Location = new Point(507, 128);
            tbxAddresse.Name = "tbxAddresse";
            tbxAddresse.Size = new Size(120, 23);
            tbxAddresse.TabIndex = 9;
            // 
            // tbxTheme
            // 
            tbxTheme.Location = new Point(124, 70);
            tbxTheme.Name = "tbxTheme";
            tbxTheme.Size = new Size(122, 23);
            tbxTheme.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 136);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Addresse :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 70);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Places :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 190);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Fin :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 190);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Début :";
            // 
            // Theme
            // 
            Theme.AutoSize = true;
            Theme.Location = new Point(46, 73);
            Theme.Name = "Theme";
            Theme.Size = new Size(49, 15);
            Theme.TabIndex = 0;
            Theme.Text = "Theme :";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(381, 511);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(335, 30);
            label6.Name = "label6";
            label6.Size = new Size(168, 21);
            label6.TabIndex = 16;
            label6.Text = "Ajouter un Hackaton";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 546);
            Controls.Add(label6);
            Controls.Add(btnMenu);
            Controls.Add(groupBox1);
            Name = "Create";
            Text = "Create";
            Load += Create_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piBimage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbxTheme;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Theme;
        private Button btnCreer;
        private TextBox tbxAddresse;
        private Button btnMenu;
        private DateTimePicker dtpDateDeb;
        private DateTimePicker dtpDateFin;
        private ComboBox cbbVille;
        private Label label5;
        private NumericUpDown numPlaces;
        private Label Nom;
        private TextBox tbxNom;
        private Label label6;
        private PictureBox piBimage;
        private Label label7;
        private TextBox tbxURL;
        private Label lbError;
    }
}