using Mana.Cards.API.Helpers;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mana.Cards.Client.Registration
{
    public partial class ClientRegistrationForm : MetroForm
    {
        public ClientRegistrationForm()
        {  
            InitializeComponent();
        }

        private void btnSalesCancellation_Click(object sender, EventArgs e)
        {

        }

        private void ClientRegistrationForm_Load(object sender, EventArgs e)
        {
            this.lblPartnerName.Text = AuthenticationHelper.GetPartnerName();
        }
    }
}
