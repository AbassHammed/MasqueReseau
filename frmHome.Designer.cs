namespace Reseau
{
    /// <summary>
    /// Defines the <see cref="FrmHome" />
    /// </summary>
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        ///  the contents of this method with the code editor
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
            rdoCidr = new RadioButton();
            rdoDecmsq = new RadioButton();
            lblMsqSlash = new Label();
            btnValider = new Button();
            lblMsg = new Label();
            btnInit = new Button();
            grpResults = new GroupBox();
            txtWildcard = new TextBox();
            lblwildCard = new Label();
            txtNbrHost = new TextBox();
            txtNbrIp = new TextBox();
            txtLastIp = new TextBox();
            txtFirstIp = new TextBox();
            txtAdrBroad = new TextBox();
            txtAdrNet = new TextBox();
            lblNbrHost = new Label();
            lblNbrIp = new Label();
            lblLastIp = new Label();
            lblFirstIp = new Label();
            lblAdrBroad = new Label();
            lblAddrNet = new Label();
            lblTypeIp = new Label();
            txtClassName = new TextBox();
            lblClassName = new Label();
            lblTitre = new Label();
            lblSch = new Label();
            lblSession = new Label();
            lblGrp = new Label();
            lblNotice = new Label();
            picQuetion = new PictureBox();
            pnlNotice = new Panel();
            grpAdrIP.SuspendLayout();
            grpAdrMasque.SuspendLayout();
            grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQuetion).BeginInit();
            pnlNotice.SuspendLayout();
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
            txtDEC1.BorderStyle = BorderStyle.FixedSingle;
            txtDEC1.Location = new Point(109, 83);
            txtDEC1.MaxLength = 3;
            txtDEC1.Name = "txtDEC1";
            txtDEC1.Size = new Size(86, 30);
            txtDEC1.TabIndex = 1;
            txtDEC1.TextChanged += textBoxIp_TextChanged;
            txtDEC1.KeyPress += TextBox_KeyPress;
            // 
            // txtDEC2
            // 
            txtDEC2.BorderStyle = BorderStyle.FixedSingle;
            txtDEC2.Location = new Point(225, 83);
            txtDEC2.MaxLength = 3;
            txtDEC2.Name = "txtDEC2";
            txtDEC2.Size = new Size(89, 30);
            txtDEC2.TabIndex = 2;
            txtDEC2.TextChanged += textBoxIp_TextChanged;
            txtDEC2.KeyPress += TextBox_KeyPress;
            // 
            // txtDEC3
            // 
            txtDEC3.BorderStyle = BorderStyle.FixedSingle;
            txtDEC3.Location = new Point(341, 83);
            txtDEC3.MaxLength = 3;
            txtDEC3.Name = "txtDEC3";
            txtDEC3.Size = new Size(89, 30);
            txtDEC3.TabIndex = 3;
            txtDEC3.TextChanged += textBoxIp_TextChanged;
            txtDEC3.KeyPress += TextBox_KeyPress;
            // 
            // txtDEC4
            // 
            txtDEC4.BorderStyle = BorderStyle.FixedSingle;
            txtDEC4.Location = new Point(457, 83);
            txtDEC4.MaxLength = 3;
            txtDEC4.Name = "txtDEC4";
            txtDEC4.Size = new Size(89, 30);
            txtDEC4.TabIndex = 4;
            txtDEC4.TextChanged += textBoxIp_TextChanged;
            txtDEC4.KeyPress += TextBox_KeyPress;
            // 
            // lblDEC1
            // 
            lblDEC1.AutoSize = true;
            lblDEC1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblDEC1.Location = new Point(204, 90);
            lblDEC1.Name = "lblDEC1";
            lblDEC1.Size = new Size(15, 23);
            lblDEC1.TabIndex = 5;
            lblDEC1.Text = ".";
            // 
            // lblDEC2
            // 
            lblDEC2.AutoSize = true;
            lblDEC2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblDEC2.Location = new Point(320, 90);
            lblDEC2.Name = "lblDEC2";
            lblDEC2.Size = new Size(15, 23);
            lblDEC2.TabIndex = 6;
            lblDEC2.Text = ".";
            // 
            // lblDEC3
            // 
            lblDEC3.AutoSize = true;
            lblDEC3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblDEC3.Location = new Point(436, 90);
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
            txtBI1.BorderStyle = BorderStyle.FixedSingle;
            txtBI1.Enabled = false;
            txtBI1.Location = new Point(109, 137);
            txtBI1.MaxLength = 8;
            txtBI1.Name = "txtBI1";
            txtBI1.Size = new Size(89, 30);
            txtBI1.TabIndex = 9;
            txtBI1.TextChanged += textBoxIp_TextChanged;
            txtBI1.KeyPress += BinTextBox_KeyPress;
            // 
            // txtBI2
            // 
            txtBI2.BorderStyle = BorderStyle.FixedSingle;
            txtBI2.Enabled = false;
            txtBI2.Location = new Point(225, 137);
            txtBI2.MaxLength = 8;
            txtBI2.Name = "txtBI2";
            txtBI2.Size = new Size(89, 30);
            txtBI2.TabIndex = 10;
            txtBI2.TextChanged += textBoxIp_TextChanged;
            txtBI2.KeyPress += BinTextBox_KeyPress;
            // 
            // txtBI3
            // 
            txtBI3.BorderStyle = BorderStyle.FixedSingle;
            txtBI3.Enabled = false;
            txtBI3.Location = new Point(341, 137);
            txtBI3.MaxLength = 8;
            txtBI3.Name = "txtBI3";
            txtBI3.Size = new Size(89, 30);
            txtBI3.TabIndex = 11;
            txtBI3.TextChanged += textBoxIp_TextChanged;
            txtBI3.KeyPress += BinTextBox_KeyPress;
            // 
            // txtBI4
            // 
            txtBI4.BorderStyle = BorderStyle.FixedSingle;
            txtBI4.Enabled = false;
            txtBI4.Location = new Point(457, 137);
            txtBI4.MaxLength = 8;
            txtBI4.Name = "txtBI4";
            txtBI4.Size = new Size(89, 30);
            txtBI4.TabIndex = 12;
            txtBI4.TextChanged += textBoxIp_TextChanged;
            txtBI4.KeyPress += BinTextBox_KeyPress;
            // 
            // lblBI1
            // 
            lblBI1.AutoSize = true;
            lblBI1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblBI1.Location = new Point(204, 144);
            lblBI1.Name = "lblBI1";
            lblBI1.Size = new Size(15, 23);
            lblBI1.TabIndex = 13;
            lblBI1.Text = ".";
            // 
            // lblBI2
            // 
            lblBI2.AutoSize = true;
            lblBI2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblBI2.Location = new Point(320, 144);
            lblBI2.Name = "lblBI2";
            lblBI2.Size = new Size(15, 23);
            lblBI2.TabIndex = 14;
            lblBI2.Text = ".";
            // 
            // lblBI3
            // 
            lblBI3.AutoSize = true;
            lblBI3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblBI3.Location = new Point(436, 144);
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
            txtHEX1.BorderStyle = BorderStyle.FixedSingle;
            txtHEX1.Enabled = false;
            txtHEX1.Location = new Point(109, 192);
            txtHEX1.MaxLength = 2;
            txtHEX1.Name = "txtHEX1";
            txtHEX1.Size = new Size(89, 30);
            txtHEX1.TabIndex = 17;
            txtHEX1.TextChanged += textBoxIp_TextChanged;
            // 
            // txtHEX2
            // 
            txtHEX2.BorderStyle = BorderStyle.FixedSingle;
            txtHEX2.Enabled = false;
            txtHEX2.Location = new Point(225, 192);
            txtHEX2.MaxLength = 2;
            txtHEX2.Name = "txtHEX2";
            txtHEX2.Size = new Size(89, 30);
            txtHEX2.TabIndex = 18;
            txtHEX2.TextChanged += textBoxIp_TextChanged;
            // 
            // txtHEX3
            // 
            txtHEX3.BorderStyle = BorderStyle.FixedSingle;
            txtHEX3.Enabled = false;
            txtHEX3.Location = new Point(341, 192);
            txtHEX3.MaxLength = 2;
            txtHEX3.Name = "txtHEX3";
            txtHEX3.Size = new Size(89, 30);
            txtHEX3.TabIndex = 19;
            txtHEX3.TextChanged += textBoxIp_TextChanged;
            // 
            // txtHEX4
            // 
            txtHEX4.BorderStyle = BorderStyle.FixedSingle;
            txtHEX4.Enabled = false;
            txtHEX4.Location = new Point(457, 192);
            txtHEX4.MaxLength = 2;
            txtHEX4.Name = "txtHEX4";
            txtHEX4.Size = new Size(89, 30);
            txtHEX4.TabIndex = 20;
            txtHEX4.TextChanged += textBoxIp_TextChanged;
            // 
            // lblHEX1
            // 
            lblHEX1.AutoSize = true;
            lblHEX1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblHEX1.Location = new Point(204, 199);
            lblHEX1.Name = "lblHEX1";
            lblHEX1.Size = new Size(15, 23);
            lblHEX1.TabIndex = 21;
            lblHEX1.Text = ".";
            // 
            // lblHEX2
            // 
            lblHEX2.AutoSize = true;
            lblHEX2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblHEX2.Location = new Point(320, 199);
            lblHEX2.Name = "lblHEX2";
            lblHEX2.Size = new Size(15, 23);
            lblHEX2.TabIndex = 22;
            lblHEX2.Text = ".";
            // 
            // lblHEX3
            // 
            lblHEX3.AutoSize = true;
            lblHEX3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblHEX3.Location = new Point(436, 199);
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
            grpAdrIP.Location = new Point(12, 65);
            grpAdrIP.Name = "grpAdrIP";
            grpAdrIP.Size = new Size(573, 255);
            grpAdrIP.TabIndex = 0;
            grpAdrIP.TabStop = false;
            grpAdrIP.Text = "Adresse IP";
            // 
            // rdoBinaireIP
            // 
            rdoBinaireIP.Appearance = Appearance.Button;
            rdoBinaireIP.CheckAlign = ContentAlignment.MiddleCenter;
            rdoBinaireIP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoBinaireIP.Location = new Point(225, 39);
            rdoBinaireIP.Name = "rdoBinaireIP";
            rdoBinaireIP.Size = new Size(102, 30);
            rdoBinaireIP.TabIndex = 26;
            rdoBinaireIP.Text = "Binaire";
            rdoBinaireIP.TextAlign = ContentAlignment.MiddleCenter;
            rdoBinaireIP.UseVisualStyleBackColor = true;
            rdoBinaireIP.CheckedChanged += rdoIP_CheckedChanged;
            // 
            // rdohexaIP
            // 
            rdohexaIP.Appearance = Appearance.Button;
            rdohexaIP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdohexaIP.Location = new Point(420, 39);
            rdohexaIP.Name = "rdohexaIP";
            rdohexaIP.Size = new Size(126, 30);
            rdohexaIP.TabIndex = 25;
            rdohexaIP.Text = "Hexadecimale";
            rdohexaIP.TextAlign = ContentAlignment.MiddleCenter;
            rdohexaIP.UseVisualStyleBackColor = true;
            rdohexaIP.CheckedChanged += rdoIP_CheckedChanged;
            // 
            // rdoDecIP
            // 
            rdoDecIP.Appearance = Appearance.Button;
            rdoDecIP.CheckAlign = ContentAlignment.MiddleCenter;
            rdoDecIP.Checked = true;
            rdoDecIP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoDecIP.Location = new Point(18, 39);
            rdoDecIP.Name = "rdoDecIP";
            rdoDecIP.Size = new Size(102, 30);
            rdoDecIP.TabIndex = 24;
            rdoDecIP.TabStop = true;
            rdoDecIP.Text = "Decimal";
            rdoDecIP.TextAlign = ContentAlignment.MiddleCenter;
            rdoDecIP.UseVisualStyleBackColor = true;
            rdoDecIP.CheckedChanged += rdoIP_CheckedChanged;
            // 
            // txtMsqCIDR
            // 
            txtMsqCIDR.BorderStyle = BorderStyle.FixedSingle;
            txtMsqCIDR.Enabled = false;
            txtMsqCIDR.Location = new Point(120, 191);
            txtMsqCIDR.MaxLength = 2;
            txtMsqCIDR.Name = "txtMsqCIDR";
            txtMsqCIDR.Size = new Size(62, 30);
            txtMsqCIDR.TabIndex = 17;
            txtMsqCIDR.TextChanged += textBoxMask_TextChanged;
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
            lblMsqBI3.Location = new Point(436, 143);
            lblMsqBI3.Name = "lblMsqBI3";
            lblMsqBI3.Size = new Size(15, 23);
            lblMsqBI3.TabIndex = 15;
            lblMsqBI3.Text = ".";
            // 
            // lblMsqBI2
            // 
            lblMsqBI2.AutoSize = true;
            lblMsqBI2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqBI2.Location = new Point(320, 143);
            lblMsqBI2.Name = "lblMsqBI2";
            lblMsqBI2.Size = new Size(15, 23);
            lblMsqBI2.TabIndex = 14;
            lblMsqBI2.Text = ".";
            // 
            // lblMsqBI1
            // 
            lblMsqBI1.AutoSize = true;
            lblMsqBI1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqBI1.Location = new Point(204, 143);
            lblMsqBI1.Name = "lblMsqBI1";
            lblMsqBI1.Size = new Size(15, 23);
            lblMsqBI1.TabIndex = 13;
            lblMsqBI1.Text = ".";
            // 
            // txtMsqBI4
            // 
            txtMsqBI4.BorderStyle = BorderStyle.FixedSingle;
            txtMsqBI4.Enabled = false;
            txtMsqBI4.Location = new Point(457, 136);
            txtMsqBI4.MaxLength = 8;
            txtMsqBI4.Name = "txtMsqBI4";
            txtMsqBI4.Size = new Size(89, 30);
            txtMsqBI4.TabIndex = 12;
            txtMsqBI4.KeyPress += BinTextBox_KeyPress;
            txtMsqBI4.Leave += textBoxMask_TextChanged;
            // 
            // txtMsqBI3
            // 
            txtMsqBI3.BorderStyle = BorderStyle.FixedSingle;
            txtMsqBI3.Enabled = false;
            txtMsqBI3.Location = new Point(341, 136);
            txtMsqBI3.MaxLength = 8;
            txtMsqBI3.Name = "txtMsqBI3";
            txtMsqBI3.Size = new Size(89, 30);
            txtMsqBI3.TabIndex = 11;
            txtMsqBI3.KeyPress += BinTextBox_KeyPress;
            txtMsqBI3.Leave += textBoxMask_TextChanged;
            // 
            // txtMsqBI2
            // 
            txtMsqBI2.BorderStyle = BorderStyle.FixedSingle;
            txtMsqBI2.Enabled = false;
            txtMsqBI2.Location = new Point(225, 136);
            txtMsqBI2.MaxLength = 8;
            txtMsqBI2.Name = "txtMsqBI2";
            txtMsqBI2.Size = new Size(89, 30);
            txtMsqBI2.TabIndex = 10;
            txtMsqBI2.KeyPress += BinTextBox_KeyPress;
            txtMsqBI2.Leave += textBoxMask_TextChanged;
            // 
            // txtMsqBI1
            // 
            txtMsqBI1.BorderStyle = BorderStyle.FixedSingle;
            txtMsqBI1.Enabled = false;
            txtMsqBI1.Location = new Point(109, 136);
            txtMsqBI1.MaxLength = 8;
            txtMsqBI1.Name = "txtMsqBI1";
            txtMsqBI1.Size = new Size(89, 30);
            txtMsqBI1.TabIndex = 9;
            txtMsqBI1.KeyPress += BinTextBox_KeyPress;
            txtMsqBI1.Leave += textBoxMask_TextChanged;
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
            lblMsqDEC3.Location = new Point(436, 89);
            lblMsqDEC3.Name = "lblMsqDEC3";
            lblMsqDEC3.Size = new Size(15, 23);
            lblMsqDEC3.TabIndex = 7;
            lblMsqDEC3.Text = ".";
            // 
            // lblMsqDEC2
            // 
            lblMsqDEC2.AutoSize = true;
            lblMsqDEC2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqDEC2.Location = new Point(320, 85);
            lblMsqDEC2.Name = "lblMsqDEC2";
            lblMsqDEC2.Size = new Size(15, 23);
            lblMsqDEC2.TabIndex = 6;
            lblMsqDEC2.Text = ".";
            // 
            // lblMsqDEC1
            // 
            lblMsqDEC1.AutoSize = true;
            lblMsqDEC1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMsqDEC1.Location = new Point(204, 87);
            lblMsqDEC1.Name = "lblMsqDEC1";
            lblMsqDEC1.Size = new Size(15, 23);
            lblMsqDEC1.TabIndex = 5;
            lblMsqDEC1.Text = ".";
            // 
            // txtMsqDEC4
            // 
            txtMsqDEC4.BorderStyle = BorderStyle.FixedSingle;
            txtMsqDEC4.Location = new Point(457, 82);
            txtMsqDEC4.MaxLength = 3;
            txtMsqDEC4.Name = "txtMsqDEC4";
            txtMsqDEC4.Size = new Size(89, 30);
            txtMsqDEC4.TabIndex = 4;
            txtMsqDEC4.KeyPress += TextBox_KeyPress;
            txtMsqDEC4.Leave += textBoxMask_TextChanged;
            // 
            // txtMsqDEC3
            // 
            txtMsqDEC3.BorderStyle = BorderStyle.FixedSingle;
            txtMsqDEC3.Location = new Point(341, 82);
            txtMsqDEC3.MaxLength = 3;
            txtMsqDEC3.Name = "txtMsqDEC3";
            txtMsqDEC3.Size = new Size(89, 30);
            txtMsqDEC3.TabIndex = 3;
            txtMsqDEC3.KeyPress += TextBox_KeyPress;
            txtMsqDEC3.Leave += textBoxMask_TextChanged;
            // 
            // txtMsqDEC2
            // 
            txtMsqDEC2.BorderStyle = BorderStyle.FixedSingle;
            txtMsqDEC2.Location = new Point(225, 78);
            txtMsqDEC2.MaxLength = 3;
            txtMsqDEC2.Name = "txtMsqDEC2";
            txtMsqDEC2.Size = new Size(89, 30);
            txtMsqDEC2.TabIndex = 2;
            txtMsqDEC2.KeyPress += TextBox_KeyPress;
            txtMsqDEC2.Leave += textBoxMask_TextChanged;
            // 
            // txtMsqDEC1
            // 
            txtMsqDEC1.BorderStyle = BorderStyle.FixedSingle;
            txtMsqDEC1.Location = new Point(109, 82);
            txtMsqDEC1.MaxLength = 3;
            txtMsqDEC1.Name = "txtMsqDEC1";
            txtMsqDEC1.Size = new Size(89, 30);
            txtMsqDEC1.TabIndex = 1;
            txtMsqDEC1.KeyPress += TextBox_KeyPress;
            txtMsqDEC1.Leave += textBoxMask_TextChanged;
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
            grpAdrMasque.Location = new Point(12, 349);
            grpAdrMasque.Name = "grpAdrMasque";
            grpAdrMasque.Size = new Size(573, 244);
            grpAdrMasque.TabIndex = 1;
            grpAdrMasque.TabStop = false;
            grpAdrMasque.Text = "Adresse Masque";
            // 
            // rdoCidr
            // 
            rdoCidr.Appearance = Appearance.Button;
            rdoCidr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoCidr.Location = new Point(225, 36);
            rdoCidr.Name = "rdoCidr";
            rdoCidr.Size = new Size(102, 30);
            rdoCidr.TabIndex = 28;
            rdoCidr.Text = "CIDR";
            rdoCidr.TextAlign = ContentAlignment.MiddleCenter;
            rdoCidr.UseVisualStyleBackColor = true;
            rdoCidr.CheckedChanged += rdoMsq_CheckedChanged;
            // 
            // rdoDecmsq
            // 
            rdoDecmsq.Appearance = Appearance.Button;
            rdoDecmsq.Checked = true;
            rdoDecmsq.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoDecmsq.Location = new Point(18, 36);
            rdoDecmsq.Name = "rdoDecmsq";
            rdoDecmsq.Size = new Size(102, 30);
            rdoDecmsq.TabIndex = 27;
            rdoDecmsq.TabStop = true;
            rdoDecmsq.Text = "Decimal";
            rdoDecmsq.TextAlign = ContentAlignment.MiddleCenter;
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
            // btnValider
            // 
            btnValider.Cursor = Cursors.Hand;
            btnValider.Enabled = false;
            btnValider.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValider.Location = new Point(491, 661);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 40);
            btnValider.TabIndex = 3;
            btnValider.Text = "Calculer";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMsg.Location = new Point(12, 608);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(181, 20);
            lblMsg.TabIndex = 4;
            lblMsg.Text = "Veuillez remplir les cases.";
            // 
            // btnInit
            // 
            btnInit.Cursor = Cursors.Hand;
            btnInit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInit.Location = new Point(12, 661);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(145, 40);
            btnInit.TabIndex = 5;
            btnInit.Text = "Réinitialisation";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(txtWildcard);
            grpResults.Controls.Add(lblwildCard);
            grpResults.Controls.Add(txtNbrHost);
            grpResults.Controls.Add(txtNbrIp);
            grpResults.Controls.Add(txtLastIp);
            grpResults.Controls.Add(txtFirstIp);
            grpResults.Controls.Add(txtAdrBroad);
            grpResults.Controls.Add(txtAdrNet);
            grpResults.Controls.Add(lblNbrHost);
            grpResults.Controls.Add(lblNbrIp);
            grpResults.Controls.Add(lblLastIp);
            grpResults.Controls.Add(lblFirstIp);
            grpResults.Controls.Add(lblAdrBroad);
            grpResults.Controls.Add(lblAddrNet);
            grpResults.Controls.Add(lblTypeIp);
            grpResults.Controls.Add(txtClassName);
            grpResults.Controls.Add(lblClassName);
            grpResults.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpResults.Location = new Point(610, 65);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(379, 470);
            grpResults.TabIndex = 6;
            grpResults.TabStop = false;
            grpResults.Text = "Resultat des calculs";
            // 
            // txtWildcard
            // 
            txtWildcard.BackColor = Color.White;
            txtWildcard.BorderStyle = BorderStyle.FixedSingle;
            txtWildcard.Enabled = false;
            txtWildcard.Location = new Point(194, 416);
            txtWildcard.Name = "txtWildcard";
            txtWildcard.Size = new Size(157, 30);
            txtWildcard.TabIndex = 16;
            // 
            // lblwildCard
            // 
            lblwildCard.AutoSize = true;
            lblwildCard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwildCard.Location = new Point(19, 421);
            lblwildCard.Name = "lblwildCard";
            lblwildCard.Size = new Size(84, 20);
            lblwildCard.TabIndex = 15;
            lblwildCard.Text = "WildCard : ";
            // 
            // txtNbrHost
            // 
            txtNbrHost.BackColor = Color.White;
            txtNbrHost.BorderStyle = BorderStyle.FixedSingle;
            txtNbrHost.Enabled = false;
            txtNbrHost.Location = new Point(194, 369);
            txtNbrHost.Name = "txtNbrHost";
            txtNbrHost.Size = new Size(157, 30);
            txtNbrHost.TabIndex = 14;
            // 
            // txtNbrIp
            // 
            txtNbrIp.BackColor = Color.White;
            txtNbrIp.BorderStyle = BorderStyle.FixedSingle;
            txtNbrIp.Enabled = false;
            txtNbrIp.Location = new Point(194, 320);
            txtNbrIp.Name = "txtNbrIp";
            txtNbrIp.Size = new Size(157, 30);
            txtNbrIp.TabIndex = 13;
            // 
            // txtLastIp
            // 
            txtLastIp.BackColor = Color.White;
            txtLastIp.BorderStyle = BorderStyle.FixedSingle;
            txtLastIp.Enabled = false;
            txtLastIp.Location = new Point(194, 134);
            txtLastIp.Name = "txtLastIp";
            txtLastIp.Size = new Size(157, 30);
            txtLastIp.TabIndex = 12;
            // 
            // txtFirstIp
            // 
            txtFirstIp.BackColor = Color.White;
            txtFirstIp.BorderStyle = BorderStyle.FixedSingle;
            txtFirstIp.Enabled = false;
            txtFirstIp.Location = new Point(194, 82);
            txtFirstIp.Name = "txtFirstIp";
            txtFirstIp.Size = new Size(157, 30);
            txtFirstIp.TabIndex = 11;
            // 
            // txtAdrBroad
            // 
            txtAdrBroad.BackColor = Color.White;
            txtAdrBroad.BorderStyle = BorderStyle.FixedSingle;
            txtAdrBroad.Enabled = false;
            txtAdrBroad.Location = new Point(194, 184);
            txtAdrBroad.Name = "txtAdrBroad";
            txtAdrBroad.Size = new Size(157, 30);
            txtAdrBroad.TabIndex = 10;
            // 
            // txtAdrNet
            // 
            txtAdrNet.BackColor = Color.White;
            txtAdrNet.BorderStyle = BorderStyle.FixedSingle;
            txtAdrNet.Enabled = false;
            txtAdrNet.Location = new Point(194, 33);
            txtAdrNet.Name = "txtAdrNet";
            txtAdrNet.Size = new Size(157, 30);
            txtAdrNet.TabIndex = 9;
            // 
            // lblNbrHost
            // 
            lblNbrHost.AutoSize = true;
            lblNbrHost.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNbrHost.Location = new Point(19, 372);
            lblNbrHost.Name = "lblNbrHost";
            lblNbrHost.Size = new Size(155, 20);
            lblNbrHost.TabIndex = 8;
            lblNbrHost.Text = "Nombre de machines";
            // 
            // lblNbrIp
            // 
            lblNbrIp.AutoSize = true;
            lblNbrIp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNbrIp.Location = new Point(19, 325);
            lblNbrIp.Name = "lblNbrIp";
            lblNbrIp.Size = new Size(104, 20);
            lblNbrIp.TabIndex = 7;
            lblNbrIp.Text = "Nombre d'IP :";
            // 
            // lblLastIp
            // 
            lblLastIp.AutoSize = true;
            lblLastIp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastIp.Location = new Point(19, 139);
            lblLastIp.Name = "lblLastIp";
            lblLastIp.Size = new Size(98, 20);
            lblLastIp.TabIndex = 6;
            lblLastIp.Text = "Dernière IP : ";
            // 
            // lblFirstIp
            // 
            lblFirstIp.AutoSize = true;
            lblFirstIp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstIp.Location = new Point(19, 87);
            lblFirstIp.Name = "lblFirstIp";
            lblFirstIp.Size = new Size(100, 20);
            lblFirstIp.TabIndex = 5;
            lblFirstIp.Text = "Première Ip : ";
            // 
            // lblAdrBroad
            // 
            lblAdrBroad.AutoSize = true;
            lblAdrBroad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdrBroad.Location = new Point(19, 189);
            lblAdrBroad.Name = "lblAdrBroad";
            lblAdrBroad.Size = new Size(145, 20);
            lblAdrBroad.TabIndex = 4;
            lblAdrBroad.Text = "Adresse Broadcast : ";
            // 
            // lblAddrNet
            // 
            lblAddrNet.AutoSize = true;
            lblAddrNet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddrNet.Location = new Point(19, 38);
            lblAddrNet.Name = "lblAddrNet";
            lblAddrNet.Size = new Size(106, 20);
            lblAddrNet.TabIndex = 3;
            lblAddrNet.Text = "Adresse NET : ";
            // 
            // lblTypeIp
            // 
            lblTypeIp.AutoSize = true;
            lblTypeIp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTypeIp.ForeColor = Color.Black;
            lblTypeIp.Location = new Point(19, 276);
            lblTypeIp.Name = "lblTypeIp";
            lblTypeIp.Size = new Size(274, 20);
            lblTypeIp.TabIndex = 2;
            lblTypeIp.Text = "Effectuer un calcul pour savoir le type d'IP";
            // 
            // txtClassName
            // 
            txtClassName.BackColor = Color.White;
            txtClassName.BorderStyle = BorderStyle.FixedSingle;
            txtClassName.Enabled = false;
            txtClassName.ForeColor = SystemColors.WindowText;
            txtClassName.Location = new Point(194, 232);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(85, 30);
            txtClassName.TabIndex = 1;
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(19, 237);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(58, 20);
            lblClassName.TabIndex = 0;
            lblClassName.Text = "Classe :";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(310, 21);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(350, 28);
            lblTitre.TabIndex = 7;
            lblTitre.Text = "Calculateur de Masque Réseau IPV4";
            // 
            // lblSch
            // 
            lblSch.AutoSize = true;
            lblSch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSch.Location = new Point(677, 684);
            lblSch.Name = "lblSch";
            lblSch.Size = new Size(256, 20);
            lblSch.TabIndex = 8;
            lblSch.Text = "I.U.T. d'Amiens - B.U.T. Informatique";
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSession.Location = new Point(730, 661);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(142, 20);
            lblSession.TabIndex = 9;
            lblSession.Text = "Session : 2023/2024";
            // 
            // lblGrp
            // 
            lblGrp.AutoSize = true;
            lblGrp.Location = new Point(720, 637);
            lblGrp.Name = "lblGrp";
            lblGrp.Size = new Size(160, 20);
            lblGrp.TabIndex = 10;
            lblGrp.Text = "SAE 2.03 - Groupe D06";
            // 
            // lblNotice
            // 
            lblNotice.AutoSize = true;
            lblNotice.Location = new Point(15, 6);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(53, 20);
            lblNotice.TabIndex = 11;
            lblNotice.Text = "Notice";
            lblNotice.Click += pnlNotice_Click;
            // 
            // picQuetion
            // 
            picQuetion.Image = Properties.Resources.question;
            picQuetion.Location = new Point(72, 2);
            picQuetion.Name = "picQuetion";
            picQuetion.Size = new Size(27, 26);
            picQuetion.SizeMode = PictureBoxSizeMode.Zoom;
            picQuetion.TabIndex = 12;
            picQuetion.TabStop = false;
            picQuetion.Click += pnlNotice_Click;
            // 
            // pnlNotice
            // 
            pnlNotice.Controls.Add(picQuetion);
            pnlNotice.Controls.Add(lblNotice);
            pnlNotice.Location = new Point(881, 540);
            pnlNotice.Name = "pnlNotice";
            pnlNotice.Size = new Size(108, 30);
            pnlNotice.TabIndex = 13;
            pnlNotice.Click += pnlNotice_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 713);
            Controls.Add(pnlNotice);
            Controls.Add(lblGrp);
            Controls.Add(lblSession);
            Controls.Add(lblSch);
            Controls.Add(lblTitre);
            Controls.Add(grpResults);
            Controls.Add(btnInit);
            Controls.Add(lblMsg);
            Controls.Add(btnValider);
            Controls.Add(grpAdrMasque);
            Controls.Add(grpAdrIP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmHome";
            Text = "Calculateur de Masque Réseau IPV4";
            grpAdrIP.ResumeLayout(false);
            grpAdrIP.PerformLayout();
            grpAdrMasque.ResumeLayout(false);
            grpAdrMasque.PerformLayout();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQuetion).EndInit();
            pnlNotice.ResumeLayout(false);
            pnlNotice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Defines the lblAdrIPDec
        /// </summary>
        private Label lblAdrIPDec;

        /// <summary>
        /// Defines the txtDEC1
        /// </summary>
        private TextBox txtDEC1;

        /// <summary>
        /// Defines the txtDEC2
        /// </summary>
        private TextBox txtDEC2;

        /// <summary>
        /// Defines the txtDEC3
        /// </summary>
        private TextBox txtDEC3;

        /// <summary>
        /// Defines the txtDEC4
        /// </summary>
        private TextBox txtDEC4;

        /// <summary>
        /// Defines the lblDEC1
        /// </summary>
        private Label lblDEC1;

        /// <summary>
        /// Defines the lblDEC2
        /// </summary>
        private Label lblDEC2;

        /// <summary>
        /// Defines the lblDEC3
        /// </summary>
        private Label lblDEC3;

        /// <summary>
        /// Defines the lblAdrIPBi
        /// </summary>
        private Label lblAdrIPBi;

        /// <summary>
        /// Defines the txtBI1
        /// </summary>
        private TextBox txtBI1;

        /// <summary>
        /// Defines the txtBI2
        /// </summary>
        private TextBox txtBI2;

        /// <summary>
        /// Defines the txtBI3
        /// </summary>
        private TextBox txtBI3;

        /// <summary>
        /// Defines the txtBI4
        /// </summary>
        private TextBox txtBI4;

        /// <summary>
        /// Defines the lblBI1
        /// </summary>
        private Label lblBI1;

        /// <summary>
        /// Defines the lblBI2
        /// </summary>
        private Label lblBI2;

        /// <summary>
        /// Defines the lblBI3
        /// </summary>
        private Label lblBI3;

        /// <summary>
        /// Defines the lblAdrIPHex
        /// </summary>
        private Label lblAdrIPHex;

        /// <summary>
        /// Defines the txtHEX1
        /// </summary>
        private TextBox txtHEX1;

        /// <summary>
        /// Defines the txtHEX2
        /// </summary>
        private TextBox txtHEX2;

        /// <summary>
        /// Defines the txtHEX3
        /// </summary>
        private TextBox txtHEX3;

        /// <summary>
        /// Defines the txtHEX4
        /// </summary>
        private TextBox txtHEX4;

        /// <summary>
        /// Defines the lblHEX1
        /// </summary>
        private Label lblHEX1;

        /// <summary>
        /// Defines the lblHEX2
        /// </summary>
        private Label lblHEX2;

        /// <summary>
        /// Defines the lblHEX3
        /// </summary>
        private Label lblHEX3;

        /// <summary>
        /// Defines the grpAdrIP
        /// </summary>
        private GroupBox grpAdrIP;

        /// <summary>
        /// Defines the lblMsqSlash
        /// </summary>
        private Label lblMsqSlash;

        /// <summary>
        /// Defines the txtMsqCIDR
        /// </summary>
        private TextBox txtMsqCIDR;

        /// <summary>
        /// Defines the lblAdrMsqCIDR
        /// </summary>
        private Label lblAdrMsqCIDR;

        /// <summary>
        /// Defines the lblMsqBI3
        /// </summary>
        private Label lblMsqBI3;

        /// <summary>
        /// Defines the lblMsqBI2
        /// </summary>
        private Label lblMsqBI2;

        /// <summary>
        /// Defines the lblMsqBI1
        /// </summary>
        private Label lblMsqBI1;

        /// <summary>
        /// Defines the txtMsqBI4
        /// </summary>
        private TextBox txtMsqBI4;

        /// <summary>
        /// Defines the txtMsqBI3
        /// </summary>
        private TextBox txtMsqBI3;

        /// <summary>
        /// Defines the txtMsqBI2
        /// </summary>
        private TextBox txtMsqBI2;

        /// <summary>
        /// Defines the txtMsqBI1
        /// </summary>
        private TextBox txtMsqBI1;

        /// <summary>
        /// Defines the lblAdrMsqBI
        /// </summary>
        private Label lblAdrMsqBI;

        /// <summary>
        /// Defines the lblMsqDEC3
        /// </summary>
        private Label lblMsqDEC3;

        /// <summary>
        /// Defines the lblMsqDEC2
        /// </summary>
        private Label lblMsqDEC2;

        /// <summary>
        /// Defines the lblMsqDEC1
        /// </summary>
        private Label lblMsqDEC1;

        /// <summary>
        /// Defines the txtMsqDEC4
        /// </summary>
        private TextBox txtMsqDEC4;

        /// <summary>
        /// Defines the txtMsqDEC3
        /// </summary>
        private TextBox txtMsqDEC3;

        /// <summary>
        /// Defines the txtMsqDEC2
        /// </summary>
        private TextBox txtMsqDEC2;

        /// <summary>
        /// Defines the txtMsqDEC1
        /// </summary>
        private TextBox txtMsqDEC1;

        /// <summary>
        /// Defines the lblAdrMsqDEC
        /// </summary>
        private Label lblAdrMsqDEC;

        /// <summary>
        /// Defines the grpAdrMasque
        /// </summary>
        private GroupBox grpAdrMasque;

        /// <summary>
        /// Defines the btnValider
        /// </summary>
        private Button btnValider;

        /// <summary>
        /// Defines the lblMsg
        /// </summary>
        private Label lblMsg;

        /// <summary>
        /// Defines the rdoBinaireIP
        /// </summary>
        private RadioButton rdoBinaireIP;

        /// <summary>
        /// Defines the rdohexaIP
        /// </summary>
        private RadioButton rdohexaIP;

        /// <summary>
        /// Defines the rdoDecIP
        /// </summary>
        private RadioButton rdoDecIP;

        /// <summary>
        /// Defines the rdoCidr
        /// </summary>
        private RadioButton rdoCidr;

        /// <summary>
        /// Defines the rdoDecmsq
        /// </summary>
        private RadioButton rdoDecmsq;

        /// <summary>
        /// Defines the btnInit
        /// </summary>
        private Button btnInit;

        /// <summary>
        /// Defines the grpResults
        /// </summary>
        private GroupBox grpResults;

        /// <summary>
        /// Defines the lblClassName
        /// </summary>
        private Label lblClassName;

        /// <summary>
        /// Defines the txtClassName
        /// </summary>
        private TextBox txtClassName;

        /// <summary>
        /// Defines the lblTypeIp
        /// </summary>
        private Label lblTypeIp;

        /// <summary>
        /// Defines the lblAddrNet
        /// </summary>
        private Label lblAddrNet;

        /// <summary>
        /// Defines the lblAdrBroad
        /// </summary>
        private Label lblAdrBroad;

        /// <summary>
        /// Defines the lblFirstIp
        /// </summary>
        private Label lblFirstIp;

        /// <summary>
        /// Defines the lblLastIp
        /// </summary>
        private Label lblLastIp;

        /// <summary>
        /// Defines the lblNbrIp
        /// </summary>
        private Label lblNbrIp;

        /// <summary>
        /// Defines the lblNbrHost
        /// </summary>
        private Label lblNbrHost;

        /// <summary>
        /// Defines the txtAdrNet
        /// </summary>
        private TextBox txtAdrNet;

        /// <summary>
        /// Defines the txtAdrBroad
        /// </summary>
        private TextBox txtAdrBroad;

        /// <summary>
        /// Defines the txtFirstIp
        /// </summary>
        private TextBox txtFirstIp;

        /// <summary>
        /// Defines the txtLastIp
        /// </summary>
        private TextBox txtLastIp;

        /// <summary>
        /// Defines the txtNbrIp
        /// </summary>
        private TextBox txtNbrIp;

        /// <summary>
        /// Defines the txtNbrHost
        /// </summary>
        private TextBox txtNbrHost;

        /// <summary>
        /// Defines the lblwildCard
        /// </summary>
        private Label lblwildCard;

        /// <summary>
        /// Defines the txtWildcard
        /// </summary>
        private TextBox txtWildcard;

        /// <summary>
        /// Defines the lblTitre
        /// </summary>
        private Label lblTitre;

        /// <summary>
        /// Defines the lblSch
        /// </summary>
        private Label lblSch;

        /// <summary>
        /// Defines the lblSession
        /// </summary>
        private Label lblSession;

        /// <summary>
        /// Defines the lblGrp
        /// </summary>
        private Label lblGrp;

        /// <summary>
        /// Defines the lblNotice
        /// </summary>
        private Label lblNotice;
        private PictureBox picQuetion;
        private Panel pnlNotice;
    }
}
