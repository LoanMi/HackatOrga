namespace HackatOrga
{
    partial class Modify
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
            btnMenu = new Button();
            groupBox1 = new GroupBox();
            labError = new Label();
            label8 = new Label();
            piBimage = new PictureBox();
            tbxURL = new TextBox();
            tbxNom = new TextBox();
            label7 = new Label();
            dtpDateFin = new DateTimePicker();
            dtpDateDeb = new DateTimePicker();
            label2 = new Label();
            numPlaces = new NumericUpDown();
            btnModifier = new Button();
            label4 = new Label();
            label1 = new Label();
            tbxAddresse = new TextBox();
            cbbVille = new ComboBox();
            label5 = new Label();
            Theme = new Label();
            tbxTheme = new TextBox();
            label3 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piBimage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlaces).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(396, 499);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labError);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(piBimage);
            groupBox1.Controls.Add(tbxURL);
            groupBox1.Controls.Add(tbxNom);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpDateFin);
            groupBox1.Controls.Add(dtpDateDeb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numPlaces);
            groupBox1.Controls.Add(btnModifier);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbxAddresse);
            groupBox1.Controls.Add(cbbVille);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Theme);
            groupBox1.Controls.Add(tbxTheme);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(75, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 437);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hackaton";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labError
            // 
            labError.AutoSize = true;
            labError.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labError.ForeColor = Color.Red;
            labError.Location = new Point(324, 341);
            labError.Name = "labError";
            labError.Size = new Size(0, 15);
            labError.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 289);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 31;
            label8.Text = "url Image :";
            // 
            // piBimage
            // 
            piBimage.Location = new Point(45, 274);
            piBimage.Name = "piBimage";
            piBimage.Size = new Size(200, 126);
            piBimage.TabIndex = 30;
            piBimage.TabStop = false;
            piBimage.Click += piBimage_Click;
            // 
            // tbxURL
            // 
            tbxURL.Location = new Point(321, 307);
            tbxURL.Name = "tbxURL";
            tbxURL.Size = new Size(416, 23);
            tbxURL.TabIndex = 29;
            tbxURL.TextChanged += tbxURL_TextChanged;
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(296, 13);
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(100, 23);
            tbxNom.TabIndex = 28;
            tbxNom.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 21);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 27;
            label7.Text = "Nom :";
            label7.Click += label7_Click;
            // 
            // dtpDateFin
            // 
            dtpDateFin.Location = new Point(463, 209);
            dtpDateFin.Name = "dtpDateFin";
            dtpDateFin.Size = new Size(200, 23);
            dtpDateFin.TabIndex = 23;
            // 
            // dtpDateDeb
            // 
            dtpDateDeb.Location = new Point(45, 209);
            dtpDateDeb.Name = "dtpDateDeb";
            dtpDateDeb.Size = new Size(200, 23);
            dtpDateDeb.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 188);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 18;
            label2.Text = "Fin :";
            // 
            // numPlaces
            // 
            numPlaces.Location = new Point(521, 66);
            numPlaces.Name = "numPlaces";
            numPlaces.Size = new Size(120, 23);
            numPlaces.TabIndex = 17;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(321, 408);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 10;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 128);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 20;
            label4.Text = "Addresse :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 188);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 16;
            label1.Text = "Début :";
            // 
            // tbxAddresse
            // 
            tbxAddresse.Location = new Point(521, 120);
            tbxAddresse.Name = "tbxAddresse";
            tbxAddresse.Size = new Size(120, 23);
            tbxAddresse.TabIndex = 22;
            // 
            // cbbVille
            // 
            cbbVille.FormattingEnabled = true;
            cbbVille.Location = new Point(123, 128);
            cbbVille.Name = "cbbVille";
            cbbVille.Size = new Size(122, 23);
            cbbVille.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 128);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 26;
            label5.Text = "Ville :";
            // 
            // Theme
            // 
            Theme.AutoSize = true;
            Theme.Location = new Point(45, 69);
            Theme.Name = "Theme";
            Theme.Size = new Size(49, 15);
            Theme.TabIndex = 15;
            Theme.Text = "Theme :";
            // 
            // tbxTheme
            // 
            tbxTheme.Location = new Point(123, 66);
            tbxTheme.Name = "tbxTheme";
            tbxTheme.Size = new Size(122, 23);
            tbxTheme.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 69);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 19;
            label3.Text = "Places :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(326, 32);
            label6.Name = "label6";
            label6.Size = new Size(177, 21);
            label6.TabIndex = 28;
            label6.Text = "Modifier un Hackaton";
            // 
            // Modify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 546);
            Controls.Add(label6);
            Controls.Add(btnMenu);
            Controls.Add(groupBox1);
            Name = "Modify";
            Text = "Modify";
            Load += Modify_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piBimage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private GroupBox groupBox1;
        private Button btnModifier;
        private NumericUpDown numPlaces;
        private Label label5;
        private ComboBox cbbVille;
        private DateTimePicker dtpDateDeb;
        private DateTimePicker dtpDateFin;
        private TextBox tbxAddresse;
        private TextBox tbxTheme;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Theme;
        private Label label6;
        private TextBox tbxNom;
        private Label label7;
        private TextBox tbxURL;
        private PictureBox piBimage;
        private Label label8;
        private Label labError;
    }
}