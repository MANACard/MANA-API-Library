using MetroFramework.Forms;
using System;


namespace Mana.Cards.Client
{
    public partial class ClientCredentialsForm : MetroForm
    {
        public string Phone { get; set; }
        public ClientCredentialsForm()
        {
            InitializeComponent();
        }

        private void ClientCredentialsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            Phone = txtPhone.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

    }
}
