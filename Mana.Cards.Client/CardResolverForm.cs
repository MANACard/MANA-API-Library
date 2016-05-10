using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Services;
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
    public partial class CardResolverForm : MetroForm
    {
        #region Properties
        public CardInfo Card { get; set; }
        #endregion

        #region CTOR
        public CardResolverForm()
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
        #endregion

        #region Form Events
        private void ClientCredentialsForm_Load(object sender, EventArgs e)
        {
            this.ShadowType = MetroFormShadowType.SystemShadow;
        }
        #endregion

        #region button Events
        private void btnFindCard_Click(object sender, EventArgs e)
        {
            this.btnFindCard.Enabled = false;
            var service = new CardService();

            try
            {
                this.Card = service.Resolve(birth_date.Value, txtPhone.Text);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (CardNotFoundException)
            {
                MetroMessageBox.Show(this, "Kartela nuk u gjet", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.btnFindCard.Enabled = true;

        }

        #endregion

    }
}
