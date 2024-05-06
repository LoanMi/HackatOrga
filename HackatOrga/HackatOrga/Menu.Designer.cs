namespace HackatOrga
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnStatistiques;
            btnMod = new Button();
            btnSupp = new Button();
            btnEvent = new Button();
            btnLstP = new Button();
            btnCreate = new Button();
            lsthackat = new ListBox();
            btnStatistiques = new Button();
            SuspendLayout();
            // 
            // btnStatistiques
            // 
            btnStatistiques.Location = new Point(586, 284);
            btnStatistiques.Name = "btnStatistiques";
            btnStatistiques.Size = new Size(75, 23);
            btnStatistiques.TabIndex = 7;
            btnStatistiques.Text = "Statistiques";
            btnStatistiques.UseVisualStyleBackColor = true;
            btnStatistiques.Click += btnStatistiques_Click;
            // 
            // btnMod
            // 
            btnMod.Enabled = false;
            btnMod.Location = new Point(263, 234);
            btnMod.Margin = new Padding(3, 2, 3, 2);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(82, 22);
            btnMod.TabIndex = 0;
            btnMod.Text = "Modifier";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnSupp
            // 
            btnSupp.Enabled = false;
            btnSupp.Location = new Point(432, 234);
            btnSupp.Margin = new Padding(3, 2, 3, 2);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(82, 22);
            btnSupp.TabIndex = 1;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            btnSupp.Click += btnSupp_Click;
            // 
            // btnEvent
            // 
            btnEvent.Enabled = false;
            btnEvent.Location = new Point(656, 234);
            btnEvent.Margin = new Padding(3, 2, 3, 2);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(82, 22);
            btnEvent.TabIndex = 2;
            btnEvent.Text = "Évènements";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // btnLstP
            // 
            btnLstP.Enabled = false;
            btnLstP.Location = new Point(816, 234);
            btnLstP.Margin = new Padding(3, 2, 3, 2);
            btnLstP.Name = "btnLstP";
            btnLstP.Size = new Size(82, 22);
            btnLstP.TabIndex = 3;
            btnLstP.Text = "Participants";
            btnLstP.UseVisualStyleBackColor = true;
            btnLstP.Click += btnLstP_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(465, 285);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Créer";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lsthackat
            // 
            lsthackat.FormattingEnabled = true;
            lsthackat.ItemHeight = 15;
            lsthackat.Location = new Point(511, 136);
            lsthackat.Margin = new Padding(3, 2, 3, 2);
            lsthackat.Name = "lsthackat";
            lsthackat.Size = new Size(132, 64);
            lsthackat.TabIndex = 6;
            lsthackat.SelectedIndexChanged += lsthackat_SelectedIndexChanged;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 436);
            Controls.Add(btnStatistiques);
            Controls.Add(lsthackat);
            Controls.Add(btnCreate);
            Controls.Add(btnLstP);
            Controls.Add(btnEvent);
            Controls.Add(btnSupp);
            Controls.Add(btnMod);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = " ";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMod;
        private Button btnSupp;
        private Button btnEvent;
        private Button btnLstP;
        private Button btnCreate;
        private ListBox lsthackat;
        private Button btnStatistiques;
    }
}