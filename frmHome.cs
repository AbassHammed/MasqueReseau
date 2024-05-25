using Reseau.lib;
using System.Diagnostics;
namespace Reseau
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permettre uniquement les touches '0', '1' et les touches de contrôle comme Backspace
            if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloque la touche
                SetMessage("Champs binaires, seulement '0' et '1'", Color.Red, false);
            }
        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {
            CheckIpFields();
            btnValider.Enabled = VerifyIpAddress() && VerifyMaskAddress();
        }

        private void textBoxMask_TextChanged(object sender, EventArgs e)
        {
            CheckMaskFields();
            btnValider.Enabled = VerifyIpAddress() && VerifyMaskAddress();
        }

        private void CheckIpFields()
        {
            if (!VerifyIpAddress())
            {
                SetMessage("Veuillez remplir les champs correctement", Color.Red, false);
            }
            else
            {
                ConvertOnVerifyIP();
                SetMessage("Tous les champs IP sont correctement remplis", Color.Green, false);
            }
        }

        private void CheckMaskFields()
        {
            if (!VerifyMaskAddress())
            {
                SetMessage("Veuillez respecter les limites du masque", Color.Red, false);
            }
            else
            {
                ConvertOnVerifyMask();
                SetMessage("Tous les champs de masque sont correctement remplis", Color.Green, false);
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
        }

        private void ConvertOnVerifyMask()
        {
            if (rdoDecmsq.Checked)
                ConvertFromDecimalMsq();
            else if (rdoBinaireMsq.Checked)
                ConvertFromBinaryMsq();
            else if (rdoCidr.Checked)
                ConvertFromCidr();
        }

        private bool VerifyIpAddress()
        {
            if (rdoDecIP.Checked)
            {
                Utils.adjustIpDec(0, 255, txtDEC1, txtDEC2, txtDEC3, txtDEC4);
                return VerifyIpDecimal();
            }
            else if (rdoBinaireIP.Checked)
                return VerifyIpBinary();
            else if (rdohexaIP.Checked)
                return VerifyIpHexadecimal();
            else
                return false;
        }

        private bool VerifyMaskAddress()
        {
            if (rdoDecmsq.Checked)
            {
                Utils.adjustMaskDec(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4);
                return VerifyMaskDecimal();
            }
            else if (rdoBinaireMsq.Checked)
                return VerifyMaskBinary();
            else if (rdoCidr.Checked)
                return VerifyMaskCidr();
            else
                return false;
        }

        private bool VerifyIpDecimal() =>
            Utils.ChampsDansLaLimite(255, txtDEC1, txtDEC2, txtDEC3, txtDEC4);

        private bool VerifyIpBinary() =>
            Utils.ChampsBinaires(txtBI1, txtBI2, txtBI3, txtBI4);

        private bool VerifyIpHexadecimal() =>
            Utils.ChampsHexadecimaux(txtHEX1, txtHEX2, txtHEX3, txtHEX4);

        private bool VerifyMaskDecimal() =>
            Utils.ChampsDansLaLimite(255, txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4);

        private bool VerifyMaskBinary() =>
            Utils.ChampsBinaires(txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4);

        private bool VerifyMaskCidr() =>
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
                    EnableMaskFields(true, false, false);
                else if (rdo == rdoBinaireMsq)
                    EnableMaskFields(false, true, false);
                else if (rdo == rdoCidr)
                    EnableMaskFields(false, false, true);
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

        private void EnableMaskFields(bool DecState, bool BiState, bool CidrState)
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
            string[] binary = Utils.DecimalToBinary(txtDEC1, txtDEC2, txtDEC3, txtDEC4).Split('.');
            txtBI1.Text = binary[0];
            txtBI2.Text = binary[1];
            txtBI3.Text = binary[2];
            txtBI4.Text = binary[3];

            string[] hexValues = Utils.DecimalToHex(txtDEC1, txtDEC2, txtDEC3, txtDEC4).Split('.');
            txtHEX1.Text = hexValues[0];
            txtHEX2.Text = hexValues[1];
            txtHEX3.Text = hexValues[2];
            txtHEX4.Text = hexValues[3];
        }

        private void ConvertFromDecimalMsq()
        {
            string[] binary = Utils.DecimalToBinary(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4).Split('.');
            txtMsqBI1.Text = binary[0];
            txtMsqBI2.Text = binary[1];
            txtMsqBI3.Text = binary[2];
            txtMsqBI4.Text = binary[3];

            string cidr = string.Format("{0}.{1}.{2}.{3}", txtMsqDEC1.Text, txtMsqDEC2.Text, txtMsqDEC3.Text, txtMsqDEC4.Text);
            txtMsqCIDR.Text = Utils.DecimalToCidr(cidr);
        }

        private void ConvertFromBinaryIP()
        {
            string[] decValue = Utils.BinaryToDecimal(txtBI1, txtBI2, txtBI3, txtBI4).Split('.');
            txtDEC1.Text = decValue[0];
            txtDEC2.Text = decValue[1];
            txtDEC3.Text = decValue[2];
            txtDEC4.Text = decValue[3];

            string[] hexValue = Utils.BinaryToHex(txtBI1, txtBI2, txtBI3, txtBI4).Split('.');
            txtHEX1.Text = hexValue[0];
            txtHEX2.Text = hexValue[1];
            txtHEX3.Text = hexValue[2];
            txtHEX4.Text = hexValue[3];
        }

        private void ConvertFromBinaryMsq()
        {
            string[] decValues = Utils.BinaryToDecimal(txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4).Split('.');
            txtMsqDEC1.Text = decValues[0];
            txtMsqDEC2.Text = decValues[1];
            txtMsqDEC3.Text = decValues[2];
            txtMsqDEC4.Text = decValues[3];

            string cidr = string.Format("{0}.{1}.{2}.{3}", txtMsqBI1.Text, txtMsqBI2.Text, txtMsqBI3.Text, txtMsqBI4.Text);
            txtMsqCIDR.Text = Utils.BinaryToCidr(cidr);
        }

        private void ConvertFromHexaIP()
        {
            string[] decValues = Utils.HexToDecimal(txtHEX1, txtHEX2, txtHEX3, txtHEX4).Split('.');
            txtDEC1.Text = decValues[0];
            txtDEC2.Text = decValues[1];
            txtDEC3.Text = decValues[2];
            txtDEC4.Text = decValues[3];

            string[] binaryValues = Utils.HexToBinary(txtHEX1, txtHEX2, txtHEX3, txtHEX4).Split('.');
            txtBI1.Text = binaryValues[0];
            txtBI2.Text = binaryValues[1];
            txtBI3.Text = binaryValues[2];
            txtBI4.Text = binaryValues[3];
        }

        private void ConvertFromCidr()
        {
            string[] decValues = Utils.CidrToDecimal(txtMsqCIDR.Text).Split('.');
            txtMsqDEC1.Text = decValues[0];
            txtMsqDEC2.Text = decValues[1];
            txtMsqDEC3.Text = decValues[2];
            txtMsqDEC4.Text = decValues[3];

            string[] binaryValues = Utils.CidrToBinary(txtMsqCIDR.Text).Split('.');
            txtMsqBI1.Text = binaryValues[0];
            txtMsqBI2.Text = binaryValues[1];
            txtMsqBI3.Text = binaryValues[2];
            txtMsqBI4.Text = binaryValues[3];

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Utils.Vider(txtDEC1, txtDEC2, txtDEC3, txtDEC4, txtBI1, txtBI2, txtBI3, txtBI4, txtHEX1, txtHEX2, txtHEX3, txtHEX4);
            Utils.Vider(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4, txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4, txtMsqCIDR);
            rdoDecIP.Checked = true;
            rdoDecmsq.Checked = true;
            EnableIpFields(true, false, false);
            EnableMaskFields(true, false, false);
            SetMessage("", Color.Red, false);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Validation en cours...");
        }


    }
}
