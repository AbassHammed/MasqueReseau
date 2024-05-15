using Reseau.lib;
namespace Reseau
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void txtDEC1_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtDEC2_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtDEC3_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtDEC4_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtBI1_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtBI2_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtBI3_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtBI4_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtHEX1_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtHEX2_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtHEX3_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtHEX4_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqDEC1_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqDEC2_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqDEC3_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqDEC4_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqBI1_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqBI2_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqBI3_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqBI4_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMsqCIDR_TextChanged(object sender, EventArgs e)
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
                SetMessage("Tous les champs sont correctement remplis", Color.Green, true);
        }

        private void SetMessage(string message, Color color, bool isEnabled)
        {
            lblMsg.ForeColor = color;
            lblMsg.Text = message;
            btnValider.Enabled = isEnabled;
        }

        private void SetValuesIp(bool decEnable = true, bool biEnable = true, bool hexEnable = true)
        {
            SetControlState([txtDEC1, txtDEC2, txtDEC3, txtDEC4], decEnable);
            SetControlState([txtBI1, txtBI2, txtBI3, txtBI4], biEnable);
            SetControlState([txtHEX1, txtHEX2, txtHEX3, txtHEX4], hexEnable);
        }

        private void SetValuesMsq(bool decEnable = true, bool biEnable = true, bool enableCidr = true)
        {
            SetControlState([txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4], decEnable);
            SetControlState([txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4], biEnable);
            txtMsqCIDR.Enabled = enableCidr;
        }

        private void SetControlState(Control[] controls, bool state)
        {
            foreach (var control in controls)
                control.Enabled = state;
        }

        private bool VerifyIp()
        {
            bool decValid = VerifyIpDec();
            bool biValid = VerifyIpBi();
            bool hexValid = VerifyIpHex();

            if (decValid) SetValuesIp(decEnable: true, biEnable: false, hexEnable: false);
            else if (biValid) SetValuesIp(decEnable: false, biEnable: true, hexEnable: false);
            else if (hexValid) SetValuesIp(decEnable: false, biEnable: false, hexEnable: true);
            else SetValuesIp(decEnable: true, biEnable: true, hexEnable: true);

            return decValid || biValid || hexValid;
        }

        private bool VerifyMsq()
        {
            bool decValid = VerifyMsqDec();
            bool biValid = VerifyMsqBi();
            bool cidrValid = VerifyMsqCidr();

            if (decValid) SetValuesMsq(decEnable: true, biEnable: false, enableCidr: false);
            else if (biValid) SetValuesMsq(decEnable: false, biEnable: true, enableCidr: false);
            else if (cidrValid) SetValuesMsq(decEnable: false, biEnable: false, enableCidr: true);
            else SetValuesMsq();

            return decValid || biValid || cidrValid;
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




    }
}
