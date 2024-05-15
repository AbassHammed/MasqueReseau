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
            if (!verifyIp())
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Veuillez remplir les champs correctement";
                btnValider.Enabled = false;
            }
            else if (!verifyMsq())
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Veuillez respecter les limites";
                btnValider.Enabled = false;
            }
            else
            {
                lblMsg.ForeColor = Color.Green;
                lblMsg.Text = "Tous les champs sont correctement remplis";
                btnValider.Enabled = true;
            }


        }

        private void setValuesIp(bool DecEnable = true, bool BiEnable = true, bool HexEnable = true)
        {
            txtDEC1.Enabled = DecEnable;
            txtDEC2.Enabled = DecEnable;
            txtDEC3.Enabled = DecEnable;
            txtDEC4.Enabled = DecEnable;
            txtBI1.Enabled = BiEnable;
            txtBI2.Enabled = BiEnable;
            txtBI3.Enabled = BiEnable;
            txtBI4.Enabled = BiEnable;
            txtHEX1.Enabled = HexEnable;
            txtHEX2.Enabled = HexEnable;
            txtHEX3.Enabled = HexEnable;
            txtHEX4.Enabled = HexEnable;
        }

        private void setValuesMsq(bool DecEnable = true, bool BiEnable = true, bool EnableCidr = true)
        {
            txtMsqDEC1.Enabled = DecEnable;
            txtMsqDEC2.Enabled = DecEnable;
            txtMsqDEC3.Enabled = DecEnable;
            txtMsqDEC4.Enabled = DecEnable;
            txtMsqBI1.Enabled = BiEnable;
            txtMsqBI2.Enabled = BiEnable;
            txtMsqBI3.Enabled = BiEnable;
            txtMsqBI4.Enabled = BiEnable;
            txtMsqCIDR.Enabled = EnableCidr;
        }


        private bool verifyIpDec()
        {
            if (Utils.ChampsRemplis(txtDEC1) || Utils.ChampsRemplis(txtDEC2) || Utils.ChampsRemplis(txtDEC3) || Utils.ChampsRemplis(txtDEC4))
                setValuesIp(DecEnable: true, BiEnable: false, HexEnable: false);
            else
                setValuesIp();


            return Utils.ChampsEntiers(txtDEC1, txtDEC2, txtDEC3, txtDEC4) && Utils.ChampsRemplis(txtDEC1, txtDEC2, txtDEC3, txtDEC4) && Utils.ChampsDansLaLimite(255, txtDEC1, txtDEC2, txtDEC3, txtDEC4);
        }


        private bool verifyIpBi()
        {
            if (Utils.ChampsRemplis(txtBI1) || Utils.ChampsRemplis(txtBI2) || Utils.ChampsRemplis(txtBI3) || Utils.ChampsRemplis(txtBI4))
                setValuesIp(BiEnable: true, DecEnable: false, HexEnable: false);
            else
                setValuesIp();

            return Utils.ChampsBinaires(txtBI1, txtBI2, txtBI3, txtBI4) && Utils.ChampsRemplis(txtBI1, txtBI2, txtBI3, txtBI4);
        }

        private bool verifyIpHex()
        {
            if (Utils.ChampsRemplis(txtHEX1) || Utils.ChampsRemplis(txtHEX2) || Utils.ChampsRemplis(txtHEX3) || Utils.ChampsRemplis(txtHEX4))
                setValuesIp(HexEnable: true, DecEnable: false, BiEnable: false);
            else
                setValuesIp();

            return Utils.ChampsHexadecimaux(txtHEX1, txtHEX2, txtHEX3, txtHEX4) && Utils.ChampsRemplis(txtHEX1, txtHEX2, txtHEX3, txtHEX4);
        }


        private bool verifyIp()
        {
            return verifyIpDec() || verifyIpBi() || verifyIpHex();
        }

        private bool verifyMsqDec()
        {
            if (Utils.ChampsRemplis(txtMsqDEC1) || Utils.ChampsRemplis(txtMsqDEC2) || Utils.ChampsRemplis(txtMsqDEC3) || Utils.ChampsRemplis(txtMsqDEC4))
                setValuesMsq(DecEnable: true, BiEnable: false, EnableCidr: false);
            else
                setValuesMsq();

            return Utils.ChampsEntiers(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4) && Utils.ChampsRemplis(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4) && Utils.ChampsDansLaLimite(255, txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4);
        }

        private bool verifyMsqBi()
        {
            if (Utils.ChampsRemplis(txtMsqBI1) || Utils.ChampsRemplis(txtMsqBI2) || Utils.ChampsRemplis(txtMsqBI3) || Utils.ChampsRemplis(txtMsqBI4))
                setValuesMsq(BiEnable: true, DecEnable: false, EnableCidr: false);
            else
                setValuesMsq();

            return Utils.ChampsBinaires(txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4) && Utils.ChampsRemplis(txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4);
        }

        private bool verifyMsqCidr()
        {
            if (Utils.ChampsRemplis(txtMsqCIDR))
                setValuesMsq(EnableCidr: true, BiEnable: false, DecEnable: false);
            else
                setValuesMsq();
            return Utils.ChampsEntiers(txtMsqCIDR) && Utils.ChampsRemplis(txtMsqCIDR) && Utils.ChampsDansLaLimite(32, txtMsqCIDR);
        }


        private bool verifyMsq()
        {
            return verifyMsqDec() || verifyMsqBi() || verifyMsqCidr();
        }



    }
}
