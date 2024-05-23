namespace Reseau
{
    partial class frmHome
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
            lblAdrIPDec = new Label();
            txtDEC1 = new TextBox();
            txtDEC2 = new TextBox();
            txtDEC3 = new TextBox();
            txtDEC4 = new TextBox();
            lblDEC1 = new Label();
            lblDEC2 = new Label();
            lblDEC3 = new Label();
            lblAdrIPBi = new Label();
            txtBI1 = new TextBox();
            txtBI2 = new TextBox();
            txtBI3 = new TextBox();
            txtBI4 = new TextBox();
            lblBI1 = new Label();
            lblBI2 = new Label();
            lblBI3 = new Label();
            lblAdrIPHex = new Label();
            txtHEX1 = new TextBox();
            txtHEX2 = new TextBox();
            txtHEX3 = new TextBox();
            txtHEX4 = new TextBox();
            lblHEX1 = new Label();
            lblHEX2 = new Label();
            lblHEX3 = new Label();
            grpAdrIP = new GroupBox();
            rdoBinaireIP = new RadioButton();
            rdohexaIP = new RadioButton();
            rdoDecIP = new RadioButton();
            txtMsqCIDR = new TextBox();
            lblAdrMsqCIDR = new Label();
            lblMsqBI3 = new Label();
            lblMsqBI2 = new Label();
            lblMsqBI1 = new Label();
            txtMsqBI4 = new TextBox();
            txtMsqBI3 = new TextBox();
            txtMsqBI2 = new TextBox();
            txtMsqBI1 = new TextBox();
            lblAdrMsqBI = new Label();
            lblMsqDEC3 = new Label();
            lblMsqDEC2 = new Label();
            lblMsqDEC1 = new Label();
            txtMsqDEC4 = new TextBox();
            txtMsqDEC3 = new TextBox();
            txtMsqDEC2 = new TextBox();
            txtMsqDEC1 = new TextBox();
            lblAdrMsqDEC = new Label();
            grpAdrMasque = new GroupBox();
            rdoBinaireMsq = new RadioButton();
            rdoCidr = new RadioButton();
            rdoDecmsq = new RadioButton();
            lblMsqSlash = new Label();
            grpFLSM = new GroupBox();
            btnValider = new Button();
            lblMsg = new Label();
            grpAdrIP.SuspendLayout();
            grpAdrMasque.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdrIPDec
            // 
            lblAdrIPDec.AutoSize = true;
            lblAdrIPDec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdrIPDec.Location = new Point(18, 88);
            lblAdrIPDec.Name = "lblAdrIPDec";
            lblAdrIPDec.Size = new Size(76, 20);
            lblAdrIPDec.TabIndex = 0;
            lblAdrIPDec.Text = "Décimal : ";
            // 
            // txtDEC1
            // 
            txtDEC1.Location = new Point(109, 83);
            txtDEC1.Name = "txtDEC1";
            txtDEC1.Size = new Size(62, 30);
            txtDEC1.TabIndex = 1;
            txtDEC1.TextChanged += txtDEC1_TextChanged;
            // 
            // txtDEC2
            // 
            txtDEC2.Location = new Point(188, 83);
            txtDEC2.Name = "txtDEC2";
            txtDEC2.Size = new Size(62, 30);
            txtDEC2.TabIndex = 2;
            txtDEC2.TextChanged += txtDEC2_TextChanged;
            // 
            // txtDEC3
            // 
            txtDEC3.Location = new Point(266, 83);
            txtDEC3.Name = "txtDEC3";
            txtDEC3.Size = new Size(62, 30);
            txtDEC3.TabIndex = 3;
            txtDEC3.TextChanged += txtDEC3_TextChanged;
            // 
            // txtDEC4
            // 
            txtDEC4.Location = new Point(349, 83);
            txtDEC4.Name = "txtDEC4";
            txtDEC4.Size = new Size(62, 30);
            txtDEC4.TabIndex = 4;
            txtDEC4.TextChanged += txtDEC4_TextChanged;
            // 
            // lblDEC1
            // 
            lblDEC1.AutoSize = true;
            lblDEC1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblDEC1.Location = new Point(174, 90);
            lblDEC1.Name = "lblDEC1";
            lblDEC1.Size = new Size(15, 23);
            lblDEC1.TabIndex = 5;
            lblDEC1.Text = ".";
            // 
            // lblDEC2
            // 
            lblDEC2.AutoSize = true;
            lblDEC2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblDEC2.Location = new Point(250, 90);
            lblDEC2.Name = "lblDEC2";
            lblDEC2.Size = new Size(15, 23);
            lblDEC2.TabIndex = 6;
            lblDEC2.Text = ".";
            // 
            // lblDEC3
            // 
            lblDEC3.AutoSize = true;
            lblDEC3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblDEC3.Location = new Point(331, 90);
            lblDEC3.Name = "lblDEC3";
            lblDEC3.Size = new Size(15, 23);
            lblDEC3.TabIndex = 7;
            lblDEC3.Text = ".";
            // 
            // lblAdrIPBi
            // 
            lblAdrIPBi.AutoSize = true;
            lblAdrIPBi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdrIPBi.Location = new Point(18, 142);
            lblAdrIPBi.Name = "lblAdrIPBi";
            lblAdrIPBi.Size = new Size(69, 20);
            lblAdrIPBi.TabIndex = 8;
            lblAdrIPBi.Text = "Binaire : ";
            // 
            // txtBI1
            // 
            txtBI1.Enabled = false;
            txtBI1.Location = new Point(109, 137);
            txtBI1.Name = "txtBI1";
            txtBI1.Size = new Size(62, 30);
            txtBI1.TabIndex = 9;
            txtBI1.TextChanged += txtBI1_TextChanged;
            // 
            // txtBI2
            // 
            txtBI2.Enabled = false;
            txtBI2.Location = new Point(188, 137);
            txtBI2.Name = "txtBI2";
            txtBI2.Size = new Size(62, 30);
            txtBI2.TabIndex = 10;
            txtBI2.TextChanged += txtBI2_TextChanged;
            // 
            // txtBI3
            // 
            txtBI3.Enabled = false;
            txtBI3.Location = new Point(266, 137);
            txtBI3.Name = "txtBI3";
            txtBI3.Size = new Size(62, 30);
            txtBI3.TabIndex = 11;
            txtBI3.TextChanged += txtBI3_TextChanged;
            // 
            // txtBI4
            // 
            txtBI4.Enabled = false;
            txtBI4.Location = new Point(349, 137);
            txtBI4.Name = "txtBI4";
            txtBI4.Size = new Size(62, 30);
            txtBI4.TabIndex = 12;
            txtBI4.TextChanged += txtBI4_TextChanged;
            // 
            // lblBI1
            // 
            lblBI1.AutoSize = true;
            lblBI1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblBI1.Location = new Point(174, 144);
            lblBI1.Name = "lblBI1";
            lblBI1.Size = new Size(15, 23);
            lblBI1.TabIndex = 13;
            lblBI1.Text = ".";
            // 
            // lblBI2
            // 
            lblBI2.AutoSize = true;
            lblBI2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblBI2.Location = new Point(250, 144);
            lblBI2.Name = "lblBI2";
            lblBI2.Size = new Size(15, 23);
            lblBI2.TabIndex = 14;
            lblBI2.Text = ".";
            // 
            // lblBI3
            // 
            lblBI3.AutoSize = true;
            lblBI3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblBI3.Location = new Point(331, 144);
            lblBI3.Name = "lblBI3";
            lblBI3.Size = new Size(15, 23);
            lblBI3.TabIndex = 15;
            lblBI3.Text = ".";
            // 
            // lblAdrIPHex
            // 
            lblAdrIPHex.AutoSize = true;
            lblAdrIPHex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdrIPHex.Location = new Point(18, 197);
            lblAdrIPHex.Name = "lblAdrIPHex";
            lblAdrIPHex.Size = new Size(48, 20);
            lblAdrIPHex.TabIndex = 16;
            lblAdrIPHex.Text = "Hex : ";
            // 
            // txtHEX1
            // 
            txtHEX1.Enabled = false;
            txtHEX1.Location = new Point(109, 192);
            txtHEX1.Name = "txtHEX1";
            txtHEX1.Size = new Size(62, 30);
            txtHEX1.TabIndex = 17;
            txtHEX1.TextChanged += txtHEX1_TextChanged;
            // 
            // txtHEX2
            // 
            txtHEX2.Enabled = false;
            txtHEX2.Location = new Point(188, 192);
            txtHEX2.Name = "txtHEX2";
            txtHEX2.Size = new Size(62, 30);
            txtHEX2.TabIndex = 18;
            txtHEX2.TextChanged += txtHEX2_TextChanged;
            // 
            // txtHEX3
            // 
            txtHEX3.Enabled = false;
            txtHEX3.Location = new Point(266, 192);
            txtHEX3.Name = "txtHEX3";
            txtHEX3.Size = new Size(62, 30);
            txtHEX3.TabIndex = 19;
            txtHEX3.TextChanged += txtHEX3_TextChanged;
            // 
            // txtHEX4
            // 
            txtHEX4.Enabled = false;
            txtHEX4.Location = new Point(349, 192);
            txtHEX4.Name = "txtHEX4";
            txtHEX4.Size = new Size(62, 30);
            txtHEX4.TabIndex = 20;
            txtHEX4.TextChanged += txtHEX4_TextChanged;
            // 
            // lblHEX1
            // 
            lblHEX1.AutoSize = true;
            lblHEX1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblHEX1.Location = new Point(174, 199);
            lblHEX1.Name = "lblHEX1";
            lblHEX1.Size = new Size(15, 23);
            lblHEX1.TabIndex = 21;
            lblHEX1.Text = ".";
            // 
            // lblHEX2
            // 
            lblHEX2.AutoSize = true;
            lblHEX2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblHEX2.Location = new Point(250, 199);
            lblHEX2.Name = "lblHEX2";
            lblHEX2.Size = new Size(15, 23);
            lblHEX2.TabIndex = 22;
            lblHEX2.Text = ".";
            // 
            // lblHEX3
            // 
            lblHEX3.AutoSize = true;
            lblHEX3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblHEX3.Location = new Point(331, 199);
            lblHEX3.Name = "lblHEX3";
            lblHEX3.Size = new Size(15, 23);
            lblHEX3.TabIndex = 23;
            lblHEX3.Text = ".";
            // 
            // grpAdrIP
            // 
            grpAdrIP.Controls.Add(rdoBinaireIP);
            grpAdrIP.Controls.Add(rdohexaIP);
            grpAdrIP.Controls.Add(rdoDecIP);
            grpAdrIP.Controls.Add(lblHEX3);
            grpAdrIP.Controls.Add(lblHEX2);
            grpAdrIP.Controls.Add(lblHEX1);
            grpAdrIP.Controls.Add(txtHEX4);
            grpAdrIP.Controls.Add(txtHEX3);
            grpAdrIP.Controls.Add(txtHEX2);
            grpAdrIP.Controls.Add(txtHEX1);
            grpAdrIP.Controls.Add(lblAdrIPHex);
            grpAdrIP.Controls.Add(lblBI3);
            grpAdrIP.Controls.Add(lblBI2);
            grpAdrIP.Controls.Add(lblBI1);
            grpAdrIP.Controls.Add(txtBI4);
            grpAdrIP.Controls.Add(txtBI3);
            grpAdrIP.Controls.Add(txtBI2);
            grpAdrIP.Controls.Add(txtBI1);
            grpAdrIP.Controls.Add(lblAdrIPBi);
            grpAdrIP.Controls.Add(lblDEC3);
            grpAdrIP.Controls.Add(lblDEC2);
            grpAdrIP.Controls.Add(lblDEC1);
            grpAdrIP.Controls.Add(txtDEC4);
            grpAdrIP.Controls.Add(txtDEC3);
            grpAdrIP.Controls.Add(txtDEC2);
            grpAdrIP.Controls.Add(txtDEC1);
            grpAdrIP.Controls.Add(lblAdrIPDec);
            grpAdrIP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAdrIP.Location = new Point(12, 12);
            grpAdrIP.Name = "grpAdrIP";
            grpAdrIP.Size = new Size(451, 255);
            grpAdrIP.TabIndex = 0;
            grpAdrIP.TabStop = false;
            grpAdrIP.Text = "Adresse IP";
            // 
            // rdoBinaireIP
            // 
            rdoBinaireIP.AutoSize = true;
            rdoBinaireIP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoBinaireIP.Location = new Point(156, 39);
            rdoBinaireIP.Name = "rdoBinaireIP";
            rdoBinaireIP.Size = new Size(78, 24);
            rdoBinaireIP.TabIndex = 26;
            rdoBinaireIP.Text = "Binaire";
            rdoBinaireIP.UseVisualStyleBackColor = true;
            rdoBinaireIP.CheckedChanged += rdoIP_CheckedChanged;
            // 
            // rdohexaIP
            // 
            rdohexaIP.AutoSize = true;
            rdohexaIP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdohexaIP.Location = new Point(285, 39);
            rdohexaIP.Name = "rdohexaIP";
            rdohexaIP.Size = new Size(126, 24);
            rdohexaIP.TabIndex = 25;
            rdohexaIP.Text = "Hexadecimale";
            rdohexaIP.UseVisualStyleBackColor = true;
            rdohexaIP.CheckedChanged += rdoIP_CheckedChanged;
            // 
            // rdoDecIP
            // 
            rdoDecIP.AutoSize = true;
            rdoDecIP.Checked = true;
            rdoDecIP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoDecIP.Location = new Point(18, 39);
            rdoDecIP.Name = "rdoDecIP";
            rdoDecIP.Size = new Size(85, 24);
            rdoDecIP.TabIndex = 24;
            rdoDecIP.TabStop = true;
            rdoDecIP.Text = "Decimal";
            rdoDecIP.UseVisualStyleBackColor = true;
            rdoDecIP.CheckedChanged += rdoIP_CheckedChanged;
            // 
            // txtMsqCIDR
            // 
            txtMsqCIDR.Enabled = false;
            txtMsqCIDR.Location = new Point(120, 191);
            txtMsqCIDR.Name = "txtMsqCIDR";
            txtMsqCIDR.Size = new Size(62, 30);
            txtMsqCIDR.TabIndex = 17;
            txtMsqCIDR.TextChanged += txtMsqCIDR_TextChanged;
            // 
            // lblAdrMsqCIDR
            // 
            lblAdrMsqCIDR.AutoSize = true;
            lblAdrMsqCIDR.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdrMsqCIDR.Location = new Point(18, 196);
            lblAdrMsqCIDR.Name = "lblAdrMsqCIDR";
            lblAdrMsqCIDR.Size = new Size(50, 20);
            lblAdrMsqCIDR.TabIndex = 16;
            lblAdrMsqCIDR.Text = "CIDR :";
            // 
            // lblMsqBI3
            // 
            lblMsqBI3.AutoSize = true;
            lblMsqBI3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqBI3.Location = new Point(331, 143);
            lblMsqBI3.Name = "lblMsqBI3";
            lblMsqBI3.Size = new Size(15, 23);
            lblMsqBI3.TabIndex = 15;
            lblMsqBI3.Text = ".";
            // 
            // lblMsqBI2
            // 
            lblMsqBI2.AutoSize = true;
            lblMsqBI2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqBI2.Location = new Point(250, 143);
            lblMsqBI2.Name = "lblMsqBI2";
            lblMsqBI2.Size = new Size(15, 23);
            lblMsqBI2.TabIndex = 14;
            lblMsqBI2.Text = ".";
            // 
            // lblMsqBI1
            // 
            lblMsqBI1.AutoSize = true;
            lblMsqBI1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqBI1.Location = new Point(174, 143);
            lblMsqBI1.Name = "lblMsqBI1";
            lblMsqBI1.Size = new Size(15, 23);
            lblMsqBI1.TabIndex = 13;
            lblMsqBI1.Text = ".";
            // 
            // txtMsqBI4
            // 
            txtMsqBI4.Enabled = false;
            txtMsqBI4.Location = new Point(349, 136);
            txtMsqBI4.Name = "txtMsqBI4";
            txtMsqBI4.Size = new Size(62, 30);
            txtMsqBI4.TabIndex = 12;
            txtMsqBI4.TextChanged += txtMsqBI4_TextChanged;
            // 
            // txtMsqBI3
            // 
            txtMsqBI3.Enabled = false;
            txtMsqBI3.Location = new Point(266, 136);
            txtMsqBI3.Name = "txtMsqBI3";
            txtMsqBI3.Size = new Size(62, 30);
            txtMsqBI3.TabIndex = 11;
            txtMsqBI3.TextChanged += txtMsqBI3_TextChanged;
            // 
            // txtMsqBI2
            // 
            txtMsqBI2.Enabled = false;
            txtMsqBI2.Location = new Point(188, 136);
            txtMsqBI2.Name = "txtMsqBI2";
            txtMsqBI2.Size = new Size(62, 30);
            txtMsqBI2.TabIndex = 10;
            txtMsqBI2.TextChanged += txtMsqBI2_TextChanged;
            // 
            // txtMsqBI1
            // 
            txtMsqBI1.Enabled = false;
            txtMsqBI1.Location = new Point(109, 136);
            txtMsqBI1.Name = "txtMsqBI1";
            txtMsqBI1.Size = new Size(62, 30);
            txtMsqBI1.TabIndex = 9;
            txtMsqBI1.TextChanged += txtMsqBI1_TextChanged;
            // 
            // lblAdrMsqBI
            // 
            lblAdrMsqBI.AutoSize = true;
            lblAdrMsqBI.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdrMsqBI.Location = new Point(18, 141);
            lblAdrMsqBI.Name = "lblAdrMsqBI";
            lblAdrMsqBI.Size = new Size(69, 20);
            lblAdrMsqBI.TabIndex = 8;
            lblAdrMsqBI.Text = "Binaire : ";
            // 
            // lblMsqDEC3
            // 
            lblMsqDEC3.AutoSize = true;
            lblMsqDEC3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqDEC3.Location = new Point(331, 89);
            lblMsqDEC3.Name = "lblMsqDEC3";
            lblMsqDEC3.Size = new Size(15, 23);
            lblMsqDEC3.TabIndex = 7;
            lblMsqDEC3.Text = ".";
            // 
            // lblMsqDEC2
            // 
            lblMsqDEC2.AutoSize = true;
            lblMsqDEC2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqDEC2.Location = new Point(250, 89);
            lblMsqDEC2.Name = "lblMsqDEC2";
            lblMsqDEC2.Size = new Size(15, 23);
            lblMsqDEC2.TabIndex = 6;
            lblMsqDEC2.Text = ".";
            // 
            // lblMsqDEC1
            // 
            lblMsqDEC1.AutoSize = true;
            lblMsqDEC1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqDEC1.Location = new Point(174, 89);
            lblMsqDEC1.Name = "lblMsqDEC1";
            lblMsqDEC1.Size = new Size(15, 23);
            lblMsqDEC1.TabIndex = 5;
            lblMsqDEC1.Text = ".";
            // 
            // txtMsqDEC4
            // 
            txtMsqDEC4.Location = new Point(349, 82);
            txtMsqDEC4.Name = "txtMsqDEC4";
            txtMsqDEC4.Size = new Size(62, 30);
            txtMsqDEC4.TabIndex = 4;
            txtMsqDEC4.TextChanged += txtMsqDEC4_TextChanged;
            // 
            // txtMsqDEC3
            // 
            txtMsqDEC3.Location = new Point(266, 82);
            txtMsqDEC3.Name = "txtMsqDEC3";
            txtMsqDEC3.Size = new Size(62, 30);
            txtMsqDEC3.TabIndex = 3;
            txtMsqDEC3.TextChanged += txtMsqDEC3_TextChanged;
            // 
            // txtMsqDEC2
            // 
            txtMsqDEC2.Location = new Point(188, 82);
            txtMsqDEC2.Name = "txtMsqDEC2";
            txtMsqDEC2.Size = new Size(62, 30);
            txtMsqDEC2.TabIndex = 2;
            txtMsqDEC2.TextChanged += txtMsqDEC2_TextChanged;
            // 
            // txtMsqDEC1
            // 
            txtMsqDEC1.Location = new Point(109, 82);
            txtMsqDEC1.Name = "txtMsqDEC1";
            txtMsqDEC1.Size = new Size(62, 30);
            txtMsqDEC1.TabIndex = 1;
            txtMsqDEC1.TextChanged += txtMsqDEC1_TextChanged;
            // 
            // lblAdrMsqDEC
            // 
            lblAdrMsqDEC.AutoSize = true;
            lblAdrMsqDEC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdrMsqDEC.Location = new Point(18, 87);
            lblAdrMsqDEC.Name = "lblAdrMsqDEC";
            lblAdrMsqDEC.Size = new Size(76, 20);
            lblAdrMsqDEC.TabIndex = 0;
            lblAdrMsqDEC.Text = "Décimal : ";
            // 
            // grpAdrMasque
            // 
            grpAdrMasque.Controls.Add(rdoBinaireMsq);
            grpAdrMasque.Controls.Add(rdoCidr);
            grpAdrMasque.Controls.Add(rdoDecmsq);
            grpAdrMasque.Controls.Add(lblMsqSlash);
            grpAdrMasque.Controls.Add(txtMsqCIDR);
            grpAdrMasque.Controls.Add(lblAdrMsqCIDR);
            grpAdrMasque.Controls.Add(lblMsqBI3);
            grpAdrMasque.Controls.Add(lblMsqBI2);
            grpAdrMasque.Controls.Add(lblMsqBI1);
            grpAdrMasque.Controls.Add(txtMsqBI4);
            grpAdrMasque.Controls.Add(txtMsqBI3);
            grpAdrMasque.Controls.Add(txtMsqBI2);
            grpAdrMasque.Controls.Add(txtMsqBI1);
            grpAdrMasque.Controls.Add(lblAdrMsqBI);
            grpAdrMasque.Controls.Add(lblMsqDEC3);
            grpAdrMasque.Controls.Add(lblMsqDEC2);
            grpAdrMasque.Controls.Add(lblMsqDEC1);
            grpAdrMasque.Controls.Add(txtMsqDEC4);
            grpAdrMasque.Controls.Add(txtMsqDEC3);
            grpAdrMasque.Controls.Add(txtMsqDEC2);
            grpAdrMasque.Controls.Add(txtMsqDEC1);
            grpAdrMasque.Controls.Add(lblAdrMsqDEC);
            grpAdrMasque.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAdrMasque.Location = new Point(12, 300);
            grpAdrMasque.Name = "grpAdrMasque";
            grpAdrMasque.Size = new Size(451, 244);
            grpAdrMasque.TabIndex = 1;
            grpAdrMasque.TabStop = false;
            grpAdrMasque.Text = "Adresse Masque";
            // 
            // rdoBinaireMsq
            // 
            rdoBinaireMsq.AutoSize = true;
            rdoBinaireMsq.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoBinaireMsq.Location = new Point(156, 40);
            rdoBinaireMsq.Name = "rdoBinaireMsq";
            rdoBinaireMsq.Size = new Size(78, 24);
            rdoBinaireMsq.TabIndex = 29;
            rdoBinaireMsq.Text = "Binaire";
            rdoBinaireMsq.UseVisualStyleBackColor = true;
            rdoBinaireMsq.CheckedChanged += rdoMsq_CheckedChanged;
            // 
            // rdoCidr
            // 
            rdoCidr.AutoSize = true;
            rdoCidr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoCidr.Location = new Point(285, 40);
            rdoCidr.Name = "rdoCidr";
            rdoCidr.Size = new Size(63, 24);
            rdoCidr.TabIndex = 28;
            rdoCidr.Text = "CIDR";
            rdoCidr.UseVisualStyleBackColor = true;
            rdoCidr.CheckedChanged += rdoMsq_CheckedChanged;
            // 
            // rdoDecmsq
            // 
            rdoDecmsq.AutoSize = true;
            rdoDecmsq.Checked = true;
            rdoDecmsq.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoDecmsq.Location = new Point(18, 40);
            rdoDecmsq.Name = "rdoDecmsq";
            rdoDecmsq.Size = new Size(85, 24);
            rdoDecmsq.TabIndex = 27;
            rdoDecmsq.TabStop = true;
            rdoDecmsq.Text = "Decimal";
            rdoDecmsq.UseVisualStyleBackColor = true;
            rdoDecmsq.CheckedChanged += rdoMsq_CheckedChanged;
            // 
            // lblMsqSlash
            // 
            lblMsqSlash.AutoSize = true;
            lblMsqSlash.Location = new Point(103, 195);
            lblMsqSlash.Name = "lblMsqSlash";
            lblMsqSlash.Size = new Size(17, 23);
            lblMsqSlash.TabIndex = 25;
            lblMsqSlash.Text = "\\";
            // 
            // grpFLSM
            // 
            grpFLSM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFLSM.Location = new Point(12, 626);
            grpFLSM.Name = "grpFLSM";
            grpFLSM.Size = new Size(451, 130);
            grpFLSM.TabIndex = 2;
            grpFLSM.TabStop = false;
            grpFLSM.Text = "FLSM";
            // 
            // btnValider
            // 
            btnValider.Enabled = false;
            btnValider.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValider.Location = new Point(369, 831);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 40);
            btnValider.TabIndex = 3;
            btnValider.Text = "Calculer";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMsg.Location = new Point(2, 789);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(181, 20);
            lblMsg.TabIndex = 4;
            lblMsg.Text = "Veuillez remplir les cases.";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 883);
            Controls.Add(lblMsg);
            Controls.Add(btnValider);
            Controls.Add(grpFLSM);
            Controls.Add(grpAdrMasque);
            Controls.Add(grpAdrIP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmHome";
            Text = "Form1";
            grpAdrIP.ResumeLayout(false);
            grpAdrIP.PerformLayout();
            grpAdrMasque.ResumeLayout(false);
            grpAdrMasque.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdrIPDec;
        private TextBox txtDEC1;
        private TextBox txtDEC2;
        private TextBox txtDEC3;
        private TextBox txtDEC4;
        private Label lblDEC1;
        private Label lblDEC2;
        private Label lblDEC3;
        private Label lblAdrIPBi;
        private TextBox txtBI1;
        private TextBox txtBI2;
        private TextBox txtBI3;
        private TextBox txtBI4;
        private Label lblBI1;
        private Label lblBI2;
        private Label lblBI3;
        private Label lblAdrIPHex;
        private TextBox txtHEX1;
        private TextBox txtHEX2;
        private TextBox txtHEX3;
        private TextBox txtHEX4;
        private Label lblHEX1;
        private Label lblHEX2;
        private Label lblHEX3;
        private GroupBox grpAdrIP;
        private Label lblMsqSlash;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtMsqCIDR;
        private Label lblAdrMsqCIDR;
        private Label lblMsqBI3;
        private Label lblMsqBI2;
        private Label lblMsqBI1;
        private TextBox txtMsqBI4;
        private TextBox txtMsqBI3;
        private TextBox txtMsqBI2;
        private TextBox txtMsqBI1;
        private Label lblAdrMsqBI;
        private Label lblMsqDEC3;
        private Label lblMsqDEC2;
        private Label lblMsqDEC1;
        private TextBox txtMsqDEC4;
        private TextBox txtMsqDEC3;
        private TextBox txtMsqDEC2;
        private TextBox txtMsqDEC1;
        private Label lblAdrMsqDEC;
        private GroupBox grpAdrMasque;
        private GroupBox grpFLSM;
        private Button btnValider;
        private Label lblMsg;
        private RadioButton rdoBinaireIP;
        private RadioButton rdohexaIP;
        private RadioButton rdoDecIP;
        private RadioButton rdoBinaireMsq;
        private RadioButton rdoCidr;
        private RadioButton rdoDecmsq;
    }
}
