using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Providers;
using MetroFramework;
using MetroFramework.Forms;
using StructureMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Mana.Cards.API.Domain;
using Mana.Cards.API.Services;
using Mana.Cards.Client.Registration.Extensions;
using Mana.Cards.API.Helpers;
namespace Mana.Cards.Client
{
    public partial class SalesCancellationForm : MetroForm
    {
        public SalesCancellationForm()
        {
            InitializeComponent();
        }

        private void LoadSales()
        {

            var service = new SaleService();


            gridSales.DataSource = null;

            gridSales.DataSource = service.GetRecentSales(txtCardBarcode.Text, 10);


            gridSales.Columns["Id"].Visible = false;
            gridSales.Columns["TransactionId"].HeaderText = "ID";

            gridSales.Columns["Total"].HeaderText = "Totali";
            gridSales.Columns["TotalPaid"].HeaderText = "Totali i paguar";
            gridSales.Columns["Date"].HeaderText = "Data";

            gridSales.Refresh();

            gridSales.ClearSelection();
        }
        private void UnsyncedSalesForm_Load(object sender, EventArgs e)
        {
            this.lblPartnerName.Text = AuthenticationHelper.GetPartnerName();
            gridSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 83, 129);

        }

        private void gridSales_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {
                    SelectionForeColor = SystemColors.HighlightText,
                    SelectionBackColor = Color.FromArgb(0, 83, 129)
                };
            }
        }

        private void gridSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedId = gridSales["Id", e.RowIndex].Value.ToString();

            var clientCred = new ClientCredentialsForm();

            var result = clientCred.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
                SelectSale(Int32.Parse(selectedId), txtCardBarcode.Text, clientCred.Phone);
        }

        private void SelectSale(int id, string cardBarcode, string phone)
        {
            var service = new SaleService();


            try
            {
                bool result = service.CancelSale(id, cardBarcode, phone);

                if (result)
                {
                    MetroMessageBox.Show(this, "Shitja u anulua me sukses", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadSales();
                }
            }
            catch (UnauthorizedCancellationException)
            {
                MetroMessageBox.Show(this, "Ju nuk jeni të autorizuar ta anuloni këtë shitje", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (txtCardBarcode.Text.IsNullOrWhiteSpace())
            {
                MetroMessageBox.Show(this, "Ju lutemi shtypni barkodin e karteles", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.LoadSales();
            }
        }

        private void btnSelectSale_Click(object sender, EventArgs e)
        {

            var clientCred = new ClientCredentialsForm();
            

            if (gridSales.SelectedRows.Count != 0)
            {
                var row = gridSales.SelectedRows[0];


                if (gridSales["Id", row.Index] != null)
                {
                    var result = clientCred.ShowDialog();

                    if (result == DialogResult.OK)
                        SelectSale(Int32.Parse(gridSales["Id", row.Index].Value.ToString()), txtCardBarcode.Text, clientCred.Phone);
                }
            }
        }

        private void loadSalesBtn_Click(object sender, EventArgs e)
        {
            if (txtCardBarcode.Text.IsNullOrWhiteSpace())
            {
                MetroMessageBox.Show(this, "Ju lutemi shtypni barkodin e karteles", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.LoadSales();
            }
        }

        private void btnResolveCard_Click(object sender, EventArgs e)
        {
            var form = new CardResolverForm();

            var result = form.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtCardBarcode.Text = form.Card.Barcode;
                this.LoadSales();

            }
        }
    }
}
