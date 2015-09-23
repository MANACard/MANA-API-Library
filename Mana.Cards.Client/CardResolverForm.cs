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
using System.Text;
using System.Windows.Forms;

namespace Mana.Cards.Client
{
    public partial class CardResolverForm : MetroForm
    {
        public CardInfo Card { get; set; }
        public CardResolverForm()
        {
            InitializeComponent();
        }

        private void ClientCredentialsForm_Load(object sender, EventArgs e)
        {

        }

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

    }
}
