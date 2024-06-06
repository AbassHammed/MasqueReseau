namespace Reseau
{
    /// <summary>
    /// Defines the <see cref="FrmNotice" />
    /// </summary>
    public partial class FrmNotice : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmNotice"/> class.
        /// </summary>
        public FrmNotice()
        {
            InitializeComponent();
        }

        // Correspond à l'événement KeyDown, permet de récupérer les touches appuyées par l'utilisateur
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) // Si la touche appuyée est Echap
            {
                Close(); // Ferme la fenêtre
                return true; // Indique que la touche est bien traitée
            }
            return base.ProcessCmdKey(ref msg, keyData); // Indique que la touche n'est pas traitée
        }
    }
}
