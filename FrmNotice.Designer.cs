namespace Reseau
{
    partial class FrmNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotice));
            lblTitle = new Label();
            lblSubTitle1 = new Label();
            lblSubContent = new Label();
            lblSubTitle2 = new Label();
            lblContent1 = new Label();
            lblContent2 = new Label();
            lblContent3 = new Label();
            lblSubTitle = new Label();
            lblContent5 = new Label();
            lblCredits = new Label();
            lblSession = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(271, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(615, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Notice d'utilisation : Calculateur de Masque Réseau IPv4";
            // 
            // lblSubTitle1
            // 
            lblSubTitle1.AutoSize = true;
            lblSubTitle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTitle1.Location = new Point(31, 98);
            lblSubTitle1.Name = "lblSubTitle1";
            lblSubTitle1.Size = new Size(130, 28);
            lblSubTitle1.TabIndex = 1;
            lblSubTitle1.Text = "Introduction";
            // 
            // lblSubContent
            // 
            lblSubContent.AutoSize = true;
            lblSubContent.Location = new Point(56, 144);
            lblSubContent.Name = "lblSubContent";
            lblSubContent.Size = new Size(1029, 20);
            lblSubContent.TabIndex = 2;
            lblSubContent.Text = "Ce calculateur est un outil simple et pratique pour déterminer les paramètres clés d'un réseau IPv4 à partir d'une adresse IP et d'un masque de sous-réseau.";
            // 
            // lblSubTitle2
            // 
            lblSubTitle2.AutoSize = true;
            lblSubTitle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTitle2.Location = new Point(31, 202);
            lblSubTitle2.Name = "lblSubTitle2";
            lblSubTitle2.Size = new Size(166, 28);
            lblSubTitle2.TabIndex = 3;
            lblSubTitle2.Text = "Fonctionnement";
            // 
            // lblContent1
            // 
            lblContent1.AutoSize = true;
            lblContent1.Location = new Point(44, 245);
            lblContent1.Name = "lblContent1";
            lblContent1.Size = new Size(542, 320);
            lblContent1.TabIndex = 4;
            lblContent1.Text = resources.GetString("lblContent1.Text");
            // 
            // lblContent2
            // 
            lblContent2.AutoSize = true;
            lblContent2.Location = new Point(604, 245);
            lblContent2.Name = "lblContent2";
            lblContent2.Size = new Size(460, 240);
            lblContent2.TabIndex = 5;
            lblContent2.Text = resources.GetString("lblContent2.Text");
            // 
            // lblContent3
            // 
            lblContent3.AutoSize = true;
            lblContent3.Location = new Point(604, 505);
            lblContent3.Name = "lblContent3";
            lblContent3.Size = new Size(421, 40);
            lblContent3.TabIndex = 6;
            lblContent3.Text = "3. Cliquez sur le bouton \"Réinitialisation\" pour effacer tous les \r\n    champs et recommencer un nouveau calcul.\r\n";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTitle.Location = new Point(439, 588);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(273, 25);
            lblSubTitle.TabIndex = 8;
            lblSubTitle.Text = "Informations complémentaires";
            // 
            // lblContent5
            // 
            lblContent5.AutoSize = true;
            lblContent5.Location = new Point(104, 630);
            lblContent5.Name = "lblContent5";
            lblContent5.Size = new Size(884, 80);
            lblContent5.TabIndex = 9;
            lblContent5.Text = resources.GetString("lblContent5.Text");
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.ForeColor = SystemColors.ActiveBorder;
            lblCredits.Location = new Point(212, 807);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(691, 20);
            lblCredits.TabIndex = 10;
            lblCredits.Text = "ABASS Hammed ▪ AURIGNAC Arthur ▪ DOHER Alexis ▪ GODET Adrien ▪ MAS Cédric ▪ NAHARRO Guerby";
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.ForeColor = SystemColors.AppWorkspace;
            lblSession.Location = new Point(312, 787);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(448, 20);
            lblSession.TabIndex = 11;
            lblSession.Text = "IUT Amiens BUT Informatique 2023-2024 ▪ SAE 2.04 ▪ Groupe D-06";
            // 
            // FrmNotice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 836);
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Controls.Add(lblSession);
            Controls.Add(lblCredits);
            Controls.Add(lblContent5);
            Controls.Add(lblSubTitle);
            Controls.Add(lblContent3);
            Controls.Add(lblContent2);
            Controls.Add(lblContent1);
            Controls.Add(lblSubTitle2);
            Controls.Add(lblSubContent);
            Controls.Add(lblSubTitle1);
            Controls.Add(lblTitle);
            KeyPreview = true;
            Name = "FrmNotice";
            Text = "Notice - Calculateur de Masque Réseau IPV4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubTitle1;
        private Label lblSubContent;
        private Label lblSubTitle2;
        private Label lblContent1;
        private Label lblContent2;
        private Label lblContent3;
        private Label lblSubTitle;
        private Label lblContent5;
        private Label lblCredits;
        private Label lblSession;
    }
}