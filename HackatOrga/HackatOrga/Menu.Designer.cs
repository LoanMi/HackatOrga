﻿namespace HackatOrga
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
            btnMod = new Button();
            btnSupp = new Button();
            btnEvent = new Button();
            btnLstP = new Button();
            btnCreate = new Button();
            lsthackat = new ListBox();
            SuspendLayout();
            // 
            // btnMod
            // 
            btnMod.Enabled = false;
            btnMod.Location = new Point(301, 312);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(94, 29);
            btnMod.TabIndex = 0;
            btnMod.Text = "Modifier";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnSupp
            // 
            btnSupp.Enabled = false;
            btnSupp.Location = new Point(494, 312);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(94, 29);
            btnSupp.TabIndex = 1;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            btnSupp.Click += btnSupp_Click;
            // 
            // btnEvent
            // 
            btnEvent.Enabled = false;
            btnEvent.Location = new Point(750, 312);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(94, 29);
            btnEvent.TabIndex = 2;
            btnEvent.Text = "Évènements";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // btnLstP
            // 
            btnLstP.Enabled = false;
            btnLstP.Location = new Point(932, 312);
            btnLstP.Name = "btnLstP";
            btnLstP.Size = new Size(94, 29);
            btnLstP.TabIndex = 3;
            btnLstP.Text = "Participants";
            btnLstP.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(621, 381);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Créer";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lsthackat
            // 
            lsthackat.FormattingEnabled = true;
            lsthackat.ItemHeight = 20;
            lsthackat.Location = new Point(584, 182);
            lsthackat.Name = "lsthackat";
            lsthackat.Size = new Size(150, 84);
            lsthackat.TabIndex = 6;
            lsthackat.SelectedIndexChanged += lsthackat_SelectedIndexChanged;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 581);
            Controls.Add(lsthackat);
            Controls.Add(btnCreate);
            Controls.Add(btnLstP);
            Controls.Add(btnEvent);
            Controls.Add(btnSupp);
            Controls.Add(btnMod);
            Name = "Menu";
            Text = "Menu";
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
    }
}