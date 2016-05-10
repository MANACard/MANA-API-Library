using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Mana.Cards.API.Services;
using Mana.Cards.Client.CostumControls;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Mana.Cards.Client
{
    public partial class TransactionAmountForm : MetroForm
    {

        public Sale Sale; 

        #region CTOR
        public TransactionAmountForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));

            Sale = new Sale();
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
        #endregion

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RoundedTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Sale.Items = new List<SalesLineItem>();

            Sale.Items.Add(new SalesLineItem { 
                Barcode = Config.DefaultProductBarcode,
                Quantity = 1,
                Price = Decimal.Parse(txtPhone.Text),
                Title = Config.DefaultProductTitle
            });

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

    }
}
