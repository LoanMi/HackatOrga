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
            label6 = new Label();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlaces).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(403, 495);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(86, 31);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
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
            groupBox1.Location = new Point(139, 75);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(637, 412);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hackaton";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(225, 25);
            label6.Name = "label6";
            label6.Size = new Size(220, 28);
            label6.TabIndex = 27;
            label6.Text = "Modifier un Hackaton";
            // 
            // dtpDateFin
            // 
            dtpDateFin.Location = new Point(355, 279);
            dtpDateFin.Margin = new Padding(3, 4, 3, 4);
            dtpDateFin.Name = "dtpDateFin";
            dtpDateFin.Size = new Size(228, 27);
            dtpDateFin.TabIndex = 23;
            // 
            // dtpDateDeb
            // 
            dtpDateDeb.Location = new Point(51, 279);
            dtpDateDeb.Margin = new Padding(3, 4, 3, 4);
            dtpDateDeb.Name = "dtpDateDeb";
            dtpDateDeb.Size = new Size(228, 27);
            dtpDateDeb.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 251);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 18;
            label2.Text = "Fin :";
            // 
            // numPlaces
            // 
            numPlaces.Location = new Point(443, 88);
            numPlaces.Margin = new Padding(3, 4, 3, 4);
            numPlaces.Name = "numPlaces";
            numPlaces.Size = new Size(137, 27);
            numPlaces.TabIndex = 17;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(263, 355);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(86, 31);
            btnModifier.TabIndex = 10;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 171);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 20;
            label4.Text = "Addresse :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 251);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 16;
            label1.Text = "Début :";
            // 
            // tbxAddresse
            // 
            tbxAddresse.Location = new Point(443, 167);
            tbxAddresse.Margin = new Padding(3, 4, 3, 4);
            tbxAddresse.Name = "tbxAddresse";
            tbxAddresse.Size = new Size(137, 27);
            tbxAddresse.TabIndex = 22;
            // 
            // cbbVille
            // 
            cbbVille.FormattingEnabled = true;
            cbbVille.Location = new Point(141, 171);
            cbbVille.Margin = new Padding(3, 4, 3, 4);
            cbbVille.Name = "cbbVille";
            cbbVille.Size = new Size(139, 28);
            cbbVille.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 171);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 26;
            label5.Text = "Ville :";
            // 
            // Theme
            // 
            Theme.AutoSize = true;
            Theme.Location = new Point(51, 92);
            Theme.Name = "Theme";
            Theme.Size = new Size(61, 20);
            Theme.TabIndex = 15;
            Theme.Text = "Theme :";
            // 
            // tbxTheme
            // 
            tbxTheme.Location = new Point(141, 88);
            tbxTheme.Margin = new Padding(3, 4, 3, 4);
            tbxTheme.Name = "tbxTheme";
            tbxTheme.Size = new Size(139, 27);
            tbxTheme.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 92);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 19;
            label3.Text = "Places :";
            // 
            // Modify
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnMenu);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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