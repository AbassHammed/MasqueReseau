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
            if (FilledAndInt())
            {
                lblMsg.ForeColor = Color.Green;
                lblMsg.Text = "Une condition permettant de faire les calculs est remplie";
                btnValider.Enabled = true;
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Veuillez remplir les champs correctement";
                btnValider.Enabled = false;
            }


        }

        private bool FilledAndInt()
        {
            bool ipFilled = ChampsRemplisEtEntiers(txtDEC1, txtDEC2, txtDEC3, txtDEC4) ||
                            ChampsRemplisEtEntiers(txtBI1, txtBI2, txtBI3, txtBI4) ||
                            ChampsRemplis(txtHEX1, txtHEX2, txtHEX3, txtHEX4);
            bool msgFilled = ChampsRemplisEtEntiers(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4) ||
                             ChampsRemplisEtEntiers(txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4) ||
                             int.TryParse(txtMsqCIDR.Text, out _);
            return ipFilled && msgFilled;
        }

        private bool ChampsRemplisEtEntiers(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text) || !int.TryParse(champ.Text, out _))
                    return false;
            return true;
        }

        private bool ChampsRemplis(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text))
                    return false;
            return true;
        }

        private bool ChampsDansLaLimite(int limite, params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (!int.TryParse(champ.Text, out int valeur) || valeur < 0 || valeur > limite)
                    return false;
            return true;
        }



    }
}
