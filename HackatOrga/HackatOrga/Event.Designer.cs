namespace HackatOrga
{
    partial class Event
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
            cbType = new ComboBox();
            txbSalle = new TextBox();
            dtpDeb = new DateTimePicker();
            dtpFin = new DateTimePicker();
            txbTheme = new TextBox();
            nudPlace = new NumericUpDown();
            cbIntervenant = new ComboBox();
            labThNb = new Label();
            labIntervenant = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Type = new Label();
            btnValider = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPlace).BeginInit();
            SuspendLayout();
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(335, 42);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 0;
            cbType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txbSalle
            // 
            txbSalle.Location = new Point(345, 94);
            txbSalle.Name = "txbSalle";
            txbSalle.Size = new Size(100, 23);
            txbSalle.TabIndex = 1;
            // 
            // dtpDeb
            // 
            dtpDeb.Location = new Point(147, 216);
            dtpDeb.Name = "dtpDeb";
            dtpDeb.Size = new Size(200, 23);
            dtpDeb.TabIndex = 2;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(470, 216);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 3;
            // 
            // txbTheme
            // 
            txbTheme.Location = new Point(345, 275);
            txbTheme.Name = "txbTheme";
            txbTheme.Size = new Size(100, 23);
            txbTheme.TabIndex = 4;
            // 
            // nudPlace
            // 
            nudPlace.Location = new Point(336, 276);
            nudPlace.Name = "nudPlace";
            nudPlace.Size = new Size(120, 23);
            nudPlace.TabIndex = 5;
            nudPlace.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cbIntervenant
            // 
            cbIntervenant.FormattingEnabled = true;
            cbIntervenant.Location = new Point(335, 362);
            cbIntervenant.Name = "cbIntervenant";
            cbIntervenant.Size = new Size(121, 23);
            cbIntervenant.TabIndex = 6;
            cbIntervenant.SelectedIndexChanged += cbIntervenant_SelectedIndexChanged;
            // 
            // labThNb
            // 
            labThNb.AutoSize = true;
            labThNb.Location = new Point(287, 283);
            labThNb.Name = "labThNb";
            labThNb.Size = new Size(38, 15);
            labThNb.TabIndex = 7;
            labThNb.Text = "label1";
            // 
            // labIntervenant
            // 
            labIntervenant.AutoSize = true;
            labIntervenant.Location = new Point(255, 370);
            labIntervenant.Name = "labIntervenant";
            labIntervenant.Size = new Size(73, 15);
            labIntervenant.TabIndex = 8;
            labIntervenant.Text = "Intervenant :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 224);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 9;
            label3.Text = "Fin :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 222);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Début :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 102);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 11;
            label5.Text = "Salle :";
            label5.Click += label5_Click;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(291, 50);
            Type.Name = "Type";
            Type.Size = new Size(37, 15);
            Type.TabIndex = 12;
            Type.Text = "Type :";
            Type.Click += Type_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(305, 411);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 13;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(408, 411);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Event
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnValider);
            Controls.Add(Type);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labIntervenant);
            Controls.Add(labThNb);
            Controls.Add(cbIntervenant);
            Controls.Add(nudPlace);
            Controls.Add(txbTheme);
            Controls.Add(dtpFin);
            Controls.Add(dtpDeb);
            Controls.Add(txbSalle);
            Controls.Add(cbType);
            Name = "Event";
            Text = "Evenement";
            Load += Evenement_Load;
            ((System.ComponentModel.ISupportInitialize)nudPlace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbType;
        private TextBox txbSalle;
        private DateTimePicker dtpDeb;
        private DateTimePicker dtpFin;
        private TextBox txbTheme;
        private NumericUpDown nudPlace;
        private ComboBox cbIntervenant;
        private Label labThNb;
        private Label labIntervenant;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Type;
        private Button btnValider;
        private Button btnMenu;
    }
}