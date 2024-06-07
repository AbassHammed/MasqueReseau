namespace Reseau
{
    using Reseau.lib;

    /*
    Groupe D-06
    ABASS Hammed
    AURIGNAC Arthur
    DOHER Alexis
    GODET Adrien
    MAS Cédric
    NAHARRO Guerby

    SAE 2.03
    2023/2024
    */

    /// <summary>
    /// Defines the <see cref="FrmHome" />
    /// </summary>
    public partial class FrmHome : Form
    {
        private FrmNotice frmNotice;
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmHome"/> class.
        /// </summary>
        public FrmHome()
        {
            InitializeComponent();
            frmNotice = new FrmNotice();
        }

        /// <summary>
        /// The TextBox_KeyPress
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère pressé est un chiffre.
            // Si le caractère n'est pas un chiffre, on ignore l'entrée.
            if (!char.IsDigit(e.KeyChar))
            {
                // Si ce n'est pas un chiffre et ce n'est pas la touche Backspace (pour permettre de corriger les entrées),
                // on marque l'événement comme traité, ce qui empêche le caractère d'être ajouté au TextBox.
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }

        /// <summary>
        /// The BinTextBox_KeyPress
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/></param>
        private void BinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permettre uniquement les touches '0', '1' et les touches de contrôle comme Backspace
            if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloque la touche
                SetMessage("Champs binaires, seulement '0' et '1'", Color.Red, false);
            }
        }

        /// <summary>
        /// The textBoxIp_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {
            CheckIpFields();
            VerifyMaskIPMatch();
        }

        /// <summary>
        /// The textBoxMask_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void textBoxMask_TextChanged(object sender, EventArgs e)
        {
            CheckMaskFields();
            VerifyMaskIPMatch();
        }

        /// <summary>
        /// Vérifie les champs de saisie de l'adresse IP et affiche des messages d'erreur spécifiques.
        /// </summary>
        private void CheckIpFields()
        {
            // Vérifie si l'adresse IP n'est valide
            if (!VerifyIpAddress())
            {
                // Message d'erreur générique si la validation échoue
                string errorMessage = "Adresse IP invalide : ";

                // Vérifie le format sélectionné et ajoute des détails spécifiques
                if (rdoDecIP.Checked && !Utils.adjustTextBoxValuesBaseOnLimits(0, 255, txtDEC1, txtDEC2, txtDEC3, txtDEC4))
                    errorMessage += "Les octets doivent être entre 0 et 255.";
                else if (rdoBinaireIP.Checked && Utils.IsEmpty(txtBI1, txtBI2, txtBI3, txtBI4))
                    errorMessage += "Veuillez remplir tous les champs binaires.";
                else if (rdohexaIP.Checked && !Utils.ChampsHexadecimaux(txtHEX1, txtHEX2, txtHEX3, txtHEX4))
                    errorMessage += "Les octets hexadécimaux doivent être entre 00 et FF.";

                // Affiche le message d'erreur spécifique (ou générique si aucun détail n'est disponible)
                SetMessage(errorMessage, Color.Red, false);
            }
            else
            {
                // Si l'adresse IP est valide, convertit l'adresse IP dans d'autres formats (selon le bouton radio sélectionné)
                ConvertOnVerifyIP();

                // Affiche un message de succès
                SetMessage("Tous les champs IP sont correctement remplis", Color.Green, false);
            }
        }

        /// <summary>
        /// Vérifie les champs de saisie du masque de sous-réseau et affiche des messages d'erreur spécifiques.
        /// </summary>
        private void CheckMaskFields()
        {
            // Vérifie si le masque de sous-réseau n'est pas valide
            if (!VerifyMaskAddress())
            {
                // Message d'erreur générique si la validation échoue
                string errorMessage = "Masque de sous-réseau invalide : ";

                // Vérifie le format sélectionné et ajoute des détails spécifiques
                if (rdoDecmsq.Checked && !Utils.adjustMask(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4))
                    errorMessage += "Les octets doivent être entre 0 et 255, et les bits à 1 doivent être contigus.";
                else if (rdoCidr.Checked && !Utils.adjustTextBoxValuesBaseOnLimits(0, 32, txtMsqCIDR))
                    errorMessage += "La valeur CIDR doit être entre 8 et 32.";

                // Affiche le message d'erreur spécifique (ou générique si aucun détail n'est disponible)
                SetMessage(errorMessage, Color.Red, false);
            }
            else
            {
                // Si le masque est valide, convertit le masque dans d'autres formats (selon le bouton radio sélectionné)
                ConvertOnVerifyMask();

                // Affiche un message de succès
                SetMessage("Tous les champs de masque sont correctement remplis", Color.Green, false);
            }
        }


        /// <summary>
        /// Affiche un message d'état pour l'utilisateur et active ou désactive le bouton "Calculer".
        /// </summary>
        /// <param name="message">The message<see cref="string"/></param>
        /// <param name="color">The color<see cref="Color"/></param>
        /// <param name="isEnabled">The isEnabled<see cref="bool"/></param>
        private void SetMessage(string message, Color color, bool isEnabled)
        {
            lblMsg.ForeColor = color;
            lblMsg.Text = message;
            btnValider.Enabled = isEnabled;
        }

        /// <summary>
        /// Déclenche la conversion de l'adresse IP depuis le format spécifié par l'utilisateur.
        /// Le format peut être décimal, binaire ou hexadécimal
        /// </summary>
        private void ConvertOnVerifyIP()
        {
            if (rdoDecIP.Checked)
                ConvertFromDecimalIP();
            else if (rdoBinaireIP.Checked)
                ConvertFromBinaryIP();
            else if (rdohexaIP.Checked)
                ConvertFromHexaIP();
        }

        /// <summary>
        /// Déclenche la conversion de l'adresse IP depuis le format spécifié par l'utilisateur.
        /// Le format peut être décimal ou CIDR
        /// </summary>
        private void ConvertOnVerifyMask()
        {
            if (rdoDecmsq.Checked)
                ConvertFromDecimalMsq();
            else if (rdoCidr.Checked)
                ConvertFromCidr();
        }

        /// <summary>
        /// Vérifie la validité de l'adresse IP entrée selon le format sélectionné (décimal, binaire, hexadécimal)
        /// </summary>
        /// <returns>True si l'adresse IP est valide selon le format spécifié, False sinon</returns>
        private bool VerifyIpAddress()
        {
            if (rdoDecIP.Checked)
                return Utils.adjustTextBoxValuesBaseOnLimits(0, 255, txtDEC1, txtDEC2, txtDEC3, txtDEC4);
            else if (rdoBinaireIP.Checked)
                return !Utils.IsEmpty(txtBI1, txtBI2, txtBI3, txtBI4);
            else if (rdohexaIP.Checked)
                return Utils.ChampsHexadecimaux(txtHEX1, txtHEX2, txtHEX3, txtHEX4);
            else
                return false;
        }

        /// <summary>
        /// Vérifie la validité de l'adresse de masque selon le format sélectionné (décimal ou CIDR)
        /// </summary>
        /// <returns>True si l'adresse de masque est valide selon le format spécifié, False sinon</returns>
        private bool VerifyMaskAddress()
        {
            if (rdoDecmsq.Checked)
                return Utils.adjustMask(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4);
            else if (rdoCidr.Checked)
                return Utils.adjustTextBoxValuesBaseOnLimits(8, 32, txtMsqCIDR);
            else
                return false;
        }

        /// <summary>
        /// Gère les événements de changement d'état des boutons radio pour activer ou désactiver les champs de saisie de l'adresse IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoIP_CheckedChanged(object sender, EventArgs e)
        {
            // Cast l'objet sender en RadioButton pour accéder à ses propriétés.
            RadioButton rdo = (RadioButton)sender;
            if (rdo.Checked)
            {
                // On verifie ici l'objet qui a génére l'evenement pour savoir quels champs doivent être activés
                if (rdo == rdoDecIP)
                    EnableIpFields(true, false, false);
                else if (rdo == rdoBinaireIP)
                    EnableIpFields(false, true, false);
                else if (rdo == rdohexaIP)
                    EnableIpFields(false, false, true);
            }
        }

        /// <summary>
        /// Gère les événements de changement d'état des boutons radio pour activer ou désactiver les champs de saisie de masques de sous-réseau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoMsq_CheckedChanged(object sender, EventArgs e)
        {
            // Cast l'objet sender en RadioButton pour accéder à ses propriétés.
            RadioButton rdo = (RadioButton)sender;
            if (rdo.Checked)
            {
                // On verifie ici l'objet qui a génére l'evenement pour savoir quels champs doivent être activés
                if (rdo == rdoDecmsq)
                    EnableMaskFields(true, false, false);
                else if (rdo == rdoCidr)
                    EnableMaskFields(false, false, true);
            }
        }

        /// <summary>
        /// Active ou desactive les champs de l'IP
        /// </summary>
        /// <param name="DecState"></param>
        /// <param name="BiState"></param>
        /// <param name="HexState"></param>
        private void EnableIpFields(bool DecState, bool BiState, bool HexState)
        {
            // Vider les champs de saisie
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

        /// <summary>
        /// Active ou désactive les champs de saisie pour les masques de sous-réseau en format décimal, binaire et CIDR,
        /// et nettoie leur contenu
        /// </summary>
        /// <param name="DecState">État activé/désactivé pour les champs de format décimal</param>
        /// <param name="BiState">État activé/désactivé pour les champs de format binaire</param>
        /// <param name="CidrState">État activé/désactivé pour le champ de format CIDR</param>
        private void EnableMaskFields(bool DecState, bool BiState, bool CidrState)
        {
            // Vide le contenu de tous les champs liés aux masques de sous-réseau, à la fois en formats décimal et binaire, ainsi que le champ CIDR.
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

        /// <summary>
        /// Convertit l'adresse IP de décimal en binaire et hexadécimal
        /// </summary>
        private void ConvertFromDecimalIP()
        {
            // Convertir l'adresse IP en binaire
            string[] binary = Utils.DecimalToBinary(txtDEC1, txtDEC2, txtDEC3, txtDEC4).Split('.');
            txtBI1.Text = binary[0];
            txtBI2.Text = binary[1];
            txtBI3.Text = binary[2];
            txtBI4.Text = binary[3];

            // Convertir l'adresse IP en hexadécimal
            string[] hexValues = Utils.DecimalToHex(txtDEC1, txtDEC2, txtDEC3, txtDEC4).Split('.');
            txtHEX1.Text = hexValues[0];
            txtHEX2.Text = hexValues[1];
            txtHEX3.Text = hexValues[2];
            txtHEX4.Text = hexValues[3];
        }

        /// <summary>
        /// Vérifie la correspondance entre l'adresse IP et le masque de sous-réseau, et met à jour le message d'état.
        /// </summary>
        private void VerifyMaskIPMatch()
        {

            // Vérifie si tous les champs d'adresse IP et de masque sont remplis
            if (!Utils.IsEmpty(txtDEC1, txtDEC2, txtDEC3, txtDEC4, txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4))
            {
                // Formate les valeurs des TextBox en chaînes d'adresse IP et de masque
                string Ip = string.Format("{0}.{1}.{2}.{3}", txtDEC1.Text, txtDEC2.Text, txtDEC3.Text, txtDEC4.Text);
                string Mask = string.Format("{0}.{1}.{2}.{3}", txtMsqDEC1.Text, txtMsqDEC2.Text, txtMsqDEC3.Text, txtMsqDEC4.Text);

                // Utilise la méthode 'validateIPAndMask' de la classe Utils pour vérifier la correspondance
                if (Utils.validateIPAndMask(Ip, Mask))
                {
                    // Si la correspondance est valide, affiche un message de succès et active le bouton "Valider"
                    SetMessage("Tous les champs sont corrects", Color.Green, true);
                }
                else
                {
                    // Si la correspondance n'est pas valide, affiche un message d'erreur et désactive le bouton "Valider"
                    SetMessage("Les adresses IP et masque ne correspondent pas", Color.Red, false);
                }
            }
        }


        /// <summary>
        /// Conversion de l'adresse de masque de sous-réseau de décimal en binaire et CIDR
        /// </summary>
        private void ConvertFromDecimalMsq()
        {
            // Convertir le masque de sous-réseau en binaire
            string[] binary = Utils.DecimalToBinary(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4).Split('.');
            txtMsqBI1.Text = binary[0];
            txtMsqBI2.Text = binary[1];
            txtMsqBI3.Text = binary[2];
            txtMsqBI4.Text = binary[3];

            // Convertir le masque de sous-réseau en CIDR
            string cidr = string.Format("{0}.{1}.{2}.{3}", txtMsqDEC1.Text, txtMsqDEC2.Text, txtMsqDEC3.Text, txtMsqDEC4.Text);
            txtMsqCIDR.Text = Utils.DecimalToCidr(cidr);
        }

        /// <summary>
        /// Convertit l'adresse IP de binaire en décimal et hexadécimal
        /// </summary>
        private void ConvertFromBinaryIP()
        {
            // Convertir l'adresse IP en décimal
            string[] decValue = Utils.BinaryToDecimal(txtBI1, txtBI2, txtBI3, txtBI4).Split('.');
            txtDEC1.Text = decValue[0];
            txtDEC2.Text = decValue[1];
            txtDEC3.Text = decValue[2];
            txtDEC4.Text = decValue[3];

            // Convertir l'adresse IP en hexadécimal
            string[] hexValue = Utils.BinaryToHex(txtBI1, txtBI2, txtBI3, txtBI4).Split('.');
            txtHEX1.Text = hexValue[0];
            txtHEX2.Text = hexValue[1];
            txtHEX3.Text = hexValue[2];
            txtHEX4.Text = hexValue[3];
        }

        /// <summary>
        /// Convertit l'adresse IP de hexadécimal en décimal et binaire
        /// </summary>
        private void ConvertFromHexaIP()
        {
            // Convertir l'adresse IP en décimal
            string[] decValues = Utils.HexToDecimal(txtHEX1, txtHEX2, txtHEX3, txtHEX4).Split('.');
            txtDEC1.Text = decValues[0];
            txtDEC2.Text = decValues[1];
            txtDEC3.Text = decValues[2];
            txtDEC4.Text = decValues[3];

            // Convertir l'adresse IP en binaire
            string[] binaryValues = Utils.HexToBinary(txtHEX1, txtHEX2, txtHEX3, txtHEX4).Split('.');
            txtBI1.Text = binaryValues[0];
            txtBI2.Text = binaryValues[1];
            txtBI3.Text = binaryValues[2];
            txtBI4.Text = binaryValues[3];
        }

        /// <summary>
        /// Convertit le CIDR de masque de sous-réseau en formats décimal et binaire, et met à jour l'interface utilisateur avec ces valeurs
        /// </summary>
        private void ConvertFromCidr()
        {
            // Conversion du masque de sous-réseau en décimale
            string[] decValues = Utils.CidrToDecimal(txtMsqCIDR.Text).Split('.');
            // Mettre à jour l'interface utilisateur
            txtMsqDEC1.Text = decValues[0];
            txtMsqDEC2.Text = decValues[1];
            txtMsqDEC3.Text = decValues[2];
            txtMsqDEC4.Text = decValues[3];

            // Conversion du masque de sous-réseau en binaire
            string[] binaryValues = Utils.CidrToBinary(txtMsqCIDR.Text).Split('.');
            // Mettre à jour l'interface utilisateur
            txtMsqBI1.Text = binaryValues[0];
            txtMsqBI2.Text = binaryValues[1];
            txtMsqBI3.Text = binaryValues[2];
            txtMsqBI4.Text = binaryValues[3];
        }

        /// <summary>
        /// The btnInit_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInit_Click(object sender, EventArgs e)
        {
            Utils.Vider(txtDEC1, txtDEC2, txtDEC3, txtDEC4, txtBI1, txtBI2, txtBI3, txtBI4, txtHEX1, txtHEX2, txtHEX3, txtHEX4);
            Utils.Vider(txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4, txtMsqBI1, txtMsqBI2, txtMsqBI3, txtMsqBI4, txtMsqCIDR);
            Utils.Vider(txtClassName, txtAdrBroad, txtAdrNet, txtFirstIp, txtLastIp, txtNbrHost, txtNbrIp, txtWildcard);
            lblTypeIp.Text = "Effectuer un calcul pour savoir le type d'IP";
            rdoDecIP.Checked = true;
            rdoDecmsq.Checked = true;
            EnableIpFields(true, false, false);
            EnableMaskFields(true, false, false);
            SetMessage("", Color.Red, false);
        }

        /// <summary>
        /// Gère le clic sur le bouton "Calculer".
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Vérifie si les champs d'adresse IP et de masque sont remplis
            if (!Utils.IsEmpty(txtDEC1, txtDEC2, txtDEC3, txtDEC4, txtMsqDEC1, txtMsqDEC2, txtMsqDEC3, txtMsqDEC4))
            {
                // Récupère l'adresse IP et le masque depuis les champs de texte
                string Ip = string.Format("{0}.{1}.{2}.{3}", txtDEC1.Text, txtDEC2.Text, txtDEC3.Text, txtDEC4.Text);
                string Mask = string.Format("{0}.{1}.{2}.{3}", txtMsqDEC1.Text, txtMsqDEC2.Text, txtMsqDEC3.Text, txtMsqDEC4.Text);

                // Crée une instance de la classe IPAddressCalculator pour effectuer les calculs
                IPAddressCalculator calculator = new(Ip, Mask);

                // Affiche les résultats des calculs dans les champs de texte correspondants
                txtClassName.Text = calculator.GetIPAddressClass();
                txtAdrBroad.Text = calculator.GetBroadcastAddress();
                txtAdrNet.Text = calculator.GetNetworkAddress();
                txtFirstIp.Text = calculator.GetFirstIPAddress();
                txtLastIp.Text = calculator.GetLastIPAddress();
                txtNbrHost.Text = calculator.GetNumberOfHosts();
                txtNbrIp.Text = calculator.GetNumberOfIPAddresses();
                lblTypeIp.Text = calculator.GetIPAddressType();
                txtWildcard.Text = calculator.GetWildcardMask();
            }
        }

        /// <summary>
        /// Gère le clic sur le panneau d'affichage de la notice.
        /// </summary>
        private void pnlNotice_Click(object sender, EventArgs e)
        {
            // Affiche la fenêtre de notice (FrmNotice) en tant que boîte de dialogue modale
            frmNotice.ShowDialog(this);
        }

        // Correspond à l'événement KeyDown, permet de récupérer les touches appuyées par l'utilisateur
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.P)
            {
                frmNotice.ShowDialog(this); // Affiche la fenêtre de notice (FrmNotice) en tant que boîte de dialogue modale
                return true; // Indique que la touche est bien traitée
            }
            return base.ProcessCmdKey(ref msg, keyData); // Indique que la touche n'est pas traitée
        }
    }
}
