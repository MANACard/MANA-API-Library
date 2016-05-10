using MetroFramework.Forms;
using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Mana.Cards.Client
{
    public partial class ClientCredentialsForm : MetroForm
    {
        public string Phone { get; set; }
        public ClientCredentialsForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
        int nLeftRect,          // x-coordinate of upper-left corner
        int nTopRect,               // y-coordinate of upper-left corner
        int nRightRect,         // x-coordinate of lower-right corner
        int nBottomRect,        // y-coordinate of lower-right corner
        int nWidthEllipse,  // height of ellipse
        int nHeightEllipse  // width of ellipse
);
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
