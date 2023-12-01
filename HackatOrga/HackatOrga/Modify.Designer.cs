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
            btnModifier = new Button();
            Theme = new Label();
            numPlaces = new NumericUpDown();
            label5 = new Label();
            cbbVille = new ComboBox();
            dtpDateDeb = new DateTimePicker();
            dtpDateFin = new DateTimePicker();
            tbxAddresse = new TextBox();
            tbxTheme = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlaces).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(353, 371);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
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
            groupBox1.Location = new Point(122, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 309);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hackaton";
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(230, 266);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 10;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
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
            // numPlaces
            // 
            numPlaces.Location = new Point(388, 66);
            numPlaces.Name = "numPlaces";
            numPlaces.Size = new Size(120, 23);
            numPlaces.TabIndex = 17;
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
            // cbbVille
            // 
            cbbVille.FormattingEnabled = true;
            cbbVille.Location = new Point(123, 128);
            cbbVille.Name = "cbbVille";
            cbbVille.Size = new Size(122, 23);
            cbbVille.TabIndex = 25;
            // 
            // dtpDateDeb
            // 
            dtpDateDeb.Location = new Point(45, 209);
            dtpDateDeb.Name = "dtpDateDeb";
            dtpDateDeb.Size = new Size(200, 23);
            dtpDateDeb.TabIndex = 24;
            // 
            // dtpDateFin
            // 
            dtpDateFin.Location = new Point(311, 209);
            dtpDateFin.Name = "dtpDateFin";
            dtpDateFin.Size = new Size(200, 23);
            dtpDateFin.TabIndex = 23;
            // 
            // tbxAddresse
            // 
            tbxAddresse.Location = new Point(388, 125);
            tbxAddresse.Name = "tbxAddresse";
            tbxAddresse.Size = new Size(120, 23);
            tbxAddresse.TabIndex = 22;
            // 
            // tbxTheme
            // 
            tbxTheme.Location = new Point(123, 66);
            tbxTheme.Name = "tbxTheme";
            tbxTheme.Size = new Size(122, 23);
            tbxTheme.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 128);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 20;
            label4.Text = "Addresse :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 69);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 19;
            label3.Text = "Places :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 188);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 18;
            label2.Text = "Fin :";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(197, 19);
            label6.Name = "label6";
            label6.Size = new Size(177, 21);
            label6.TabIndex = 27;
            label6.Text = "Modifier un Hackaton";
            // 
            // Modify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(groupBox1);
            Name = "Modify";
            Text = "Modify";
            Load += Modify_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPlaces).EndInit();
            ResumeLayout(false);
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
    }
}