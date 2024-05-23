using Reseau.lib;
namespace Reseau
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void CheckFields()
        {
            if (!VerifyIp())
                SetMessage("Veuillez remplir les champs correctement", Color.Red, false);
            else if (!VerifyMsq())
                SetMessage("Veuillez respecter les limites", Color.Red, false);
            else
            {
                ConvertOnVerifyIP();
                ConvertOnVerifyMsq();
                SetMessage("Tous les champs sont correctement remplis", Color.Green, true);
            }
        }


        private void SetMessage(string message, Color color, bool isEnabled)
        {
            lblMsg.ForeColor = color;
            lblMsg.Text = message;
            btnValider.Enabled = isEnabled;
        }

        private void ConvertOnVerifyIP()
        {
            if (rdoDecIP.Checked)
                ConvertFromDecimalIP();
            else if (rdoBinaireIP.Checked)
                ConvertFromBinaryIP();
            else if (rdohexaIP.Checked)
                ConvertFromHexaIP();
            else
                SetMessage("Veuillez choisir une option", Color.Red, false);
        }

        private void ConvertOnVerifyMsq()
        {
            if (rdoDecmsq.Checked)
                ConvertFromDecimalMsq();
            else if (rdoBinaireMsq.Checked)
                ConvertFromBinaryMsq();
            else if (rdoCidr.Checked)
                ConvertFromCidr();
            else
                SetMessage("Veuillez choisir une option", Color.Red, false);
        }

        private bool VerifyIp()
        {
            if (rdoDecIP.Checked)
                return VerifyIpDec();
            else if (rdoBinaireIP.Checked)
                return VerifyIpBi();
            else if (rdohexaIP.Checked)
                return VerifyIpHex();
            else
                return false;
        }

        private bool VerifyMsq()
        {
            if (rdoDecmsq.Checked)
                return VerifyMsqDec();
            else if (rdoBinaireMsq.Checked)
                return VerifyMsqBi();
            else if (rdoCidr.Checked)
                return VerifyMsqCidr();
            else
                return false;
        }

        private bool VerifyIpDec() =>
            Utils.ChampsEntiers(txtDEC1, txtDEC2, txtDEC3, txtDEC4) &&
            Utils.ChampsRemplis(txtDEC1, txtDEC2, txtDEC3, txtDEC4) &&
            Utils.ChampsDansLaLimite(255, txtDEC1, txtDEC2, txtDEC3, txtDEC4);

        private bool VerifyIpBi() =>
            Utils.ChampsBinaires(txtBI1, txtBI2, txtBI3, txtBI4) &&
            Utils.ChampsRemplis(txtBI1, txtBI2, txtBI3, txtBI4);

        private bool VerifyIpHex() =>
            Utils.ChampsHexadecimaux(txtHEX1, txtHEX2, txtHEX3, txtHEX4) &&
            Utils.ChampsRemplis(txtHEX1, txtHEX2, txtHEX3, txtHEX4);

        private bool VerifyMsqDec() =>
            Utils.ChampsEntiers(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4) &&
            Utils.ChampsRemplis(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4) &&
            Utils.ChampsDansLaLimite(255, txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4);

        private bool VerifyMsqBi() =>
            Utils.ChampsBinaires(txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4) &&
            Utils.ChampsRemplis(txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4);

        private bool VerifyMsqCidr() =>
            Utils.ChampsEntiers(txtMsqCIDR) &&
            Utils.ChampsRemplis(txtMsqCIDR) &&
            Utils.ChampsDansLaLimite(32, txtMsqCIDR);


        private void rdoIP_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if (rdo.Checked)
            {
                if (rdo == rdoDecIP)
                    EnableIpFields(true, false, false);
                else if (rdo == rdoBinaireIP)
                    EnableIpFields(false, true, false);
                else if (rdo == rdohexaIP)
                    EnableIpFields(false, false, true);
            }
        }

        private void rdoMsq_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if (rdo.Checked)
            {
                if (rdo == rdoDecmsq)
                    EnableMsqFields(true, false, false);
                else if (rdo == rdoBinaireMsq)
                    EnableMsqFields(false, true, false);
                else if (rdo == rdoCidr)
                    EnableMsqFields(false, false, true);
            }
        }

        private void EnableIpFields(bool DecState, bool BiState, bool HexState)
        {
            Utils.Vider(txtDEC1, txtDEC2, txtDEC3, txtDEC4, txtBI1, txtBI2, txtBI3, txtBI4, txtHEX1, txtHEX2, txtHEX3, txtHEX4);
            txtDEC1.Enabled = DecState;
            txtDEC2.Enabled = DecState;
            txtDEC3.Enabled = DecState;
            txtDEC4.Enabled = DecState;
            txtBI1.Enabled = BiState;
            txtBI2.Enabled = BiState;
            txtBI3.Enabled = BiState;
            txtBI4.Enabled = BiState;
            txtHEX1.Enabled = HexState;
            txtHEX2.Enabled = HexState;
            txtHEX3.Enabled = HexState;
            txtHEX4.Enabled = HexState;
        }

        private void EnableMsqFields(bool DecState, bool BiState, bool CidrState)
        {
            Utils.Vider(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4, txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4, txtMsqCIDR);
            txtMsqDEC1.Enabled = DecState;
            txtMsqDEC2.Enabled = DecState;
            txtMsqDEC3.Enabled = DecState;
            txtMsqDEC4.Enabled = DecState;
            txtMsqBI1.Enabled = BiState;
            txtMsqBI2.Enabled = BiState;
            txtMsqBI3.Enabled = BiState;
            txtMsqBI4.Enabled = BiState;
            txtMsqCIDR.Enabled = CidrState;
        }

        private void ConvertFromDecimalIP()
        {
            txtBI1.Text = Utils.DecimalToBinary(txtDEC1.Text);
            txtBI2.Text = Utils.DecimalToBinary(txtDEC2.Text);
            txtBI3.Text = Utils.DecimalToBinary(txtDEC3.Text);
            txtBI4.Text = Utils.DecimalToBinary(txtDEC4.Text);

            txtHEX1.Text = Utils.DecimalToHex(txtDEC1.Text);
            txtHEX2.Text = Utils.DecimalToHex(txtDEC2.Text);
            txtHEX3.Text = Utils.DecimalToHex(txtDEC3.Text);
            txtHEX4.Text = Utils.DecimalToHex(txtDEC4.Text);
        }

        private void ConvertFromDecimalMsq()
        {
            txtMsqBI1.Text = Utils.DecimalToBinary(txtMsqDEC1.Text);
            txtMsqBI2.Text = Utils.DecimalToBinary(txtMsqDEC2.Text);
            txtMsqBI3.Text = Utils.DecimalToBinary(txtMsqDEC3.Text);
            txtMsqBI4.Text = Utils.DecimalToBinary(txtMsqDEC4.Text);

            string cidr = string.Format("{0}.{1}.{2}.{3}", txtMsqDEC1.Text, txtMsqDEC2.Text, txtMsqDEC3.Text, txtMsqDEC4.Text);
            txtMsqCIDR.Text = Utils.DecimalToCidr(cidr);
        }

        private void ConvertFromBinaryIP()
        {
            txtDEC1.Text = Utils.BinaryToDecimal(txtBI1.Text);
            txtDEC2.Text = Utils.BinaryToDecimal(txtBI2.Text);
            txtDEC3.Text = Utils.BinaryToDecimal(txtBI3.Text);
            txtDEC4.Text = Utils.BinaryToDecimal(txtBI4.Text);

            txtHEX1.Text = Utils.BinaryToHex(txtBI1.Text);
            txtHEX2.Text = Utils.BinaryToHex(txtBI2.Text);
            txtHEX3.Text = Utils.BinaryToHex(txtBI3.Text);
            txtHEX4.Text = Utils.BinaryToHex(txtBI4.Text);
        }

        private void ConvertFromBinaryMsq()
        {
            txtMsqDEC1.Text = Utils.BinaryToDecimal(txtMsqBI1.Text);
            txtMsqDEC2.Text = Utils.BinaryToDecimal(txtMsqBI2.Text);
            txtMsqDEC3.Text = Utils.BinaryToDecimal(txtMsqBI3.Text);
            txtMsqDEC4.Text = Utils.BinaryToDecimal(txtMsqBI4.Text);

            string cidr = string.Format("{0}.{1}.{2}.{3}", txtMsqBI1.Text, txtMsqBI2.Text, txtMsqBI3.Text, txtMsqBI4.Text);
            txtMsqCIDR.Text = Utils.BinaryToCidr(cidr);
        }

        private void ConvertFromHexaIP()
        {
            txtDEC1.Text = Utils.HexToDecimal(txtHEX1.Text);
            txtDEC2.Text = Utils.HexToDecimal(txtHEX2.Text);
            txtDEC3.Text = Utils.HexToDecimal(txtHEX3.Text);
            txtDEC4.Text = Utils.HexToDecimal(txtHEX4.Text);

            txtBI1.Text = Utils.HexToBinary(txtHEX1.Text);
            txtBI2.Text = Utils.HexToBinary(txtHEX2.Text);
            txtBI3.Text = Utils.HexToBinary(txtHEX3.Text);
            txtBI4.Text = Utils.HexToBinary(txtHEX4.Text);
        }

        private void ConvertFromCidr()
        {
            string cidr = Utils.CidrToDecimal(txtMsqCIDR.Text);
            txtMsqDEC1.Text = cidr.Split('.')[0];
            txtMsqDEC2.Text = cidr.Split('.')[1];
            txtMsqDEC3.Text = cidr.Split('.')[2];
            txtMsqDEC4.Text = cidr.Split('.')[3];

            string binary = Utils.CidrToBinary(txtMsqCIDR.Text);
            txtMsqBI1.Text = binary.Split('.')[0];
            txtMsqBI2.Text = binary.Split('.')[1];
            txtMsqBI3.Text = binary.Split('.')[2];
            txtMsqBI4.Text = binary.Split('.')[3];

        }
    }
}
