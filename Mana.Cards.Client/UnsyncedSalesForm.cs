using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Mana.Cards.OfflineAPI.Exceptions;
using Mana.Cards.OfflineAPI.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Mana.Cards.Client
{
    public partial class UnsyncedSalesForm : MetroForm
    {
        public UnsyncedSalesForm()
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

        private void LoadSales()
        {

            var service = new SyncService();

            gridSales.DataSource = null;

            var sales = service.GetUnsyncedSales().Select(x => new
            {
                Barcode = x.Sale.CardBarcode,
                Total = x.Sale.Total,
                Date = x.Date
            }).OrderByDescending(x => x.Date).ToList();
            gridSales.DataSource = sales;
            gridSales.Columns["Barcode"].HeaderText = "Kartela";
            gridSales.Columns["Total"].HeaderText = "Totali";
            gridSales.Columns["Date"].HeaderText = "Data";
            gridSales.Refresh();

            gridSales.ClearSelection();
        }
        private void UnsyncedSalesForm_Load(object sender, EventArgs e)
        {
            this.lblPartnerName.Text = AuthenticationHelper.GetPartnerName();
            this.LoadSales();
            gridSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 83, 129);

        }

        private void btnSynchronize_Click(object sender, EventArgs e)
        {
            btnSynchronize.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                new SyncService().StartSync();
                MetroMessageBox.Show(this, "Sinkronizimi perfundoi me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (AuthenticationFailedException)
            {
                MetroMessageBox.Show(this, "Auth error", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WebException)
            {
                MetroMessageBox.Show(this, "Ka ndodhur një gabim. Ju lutemi provoni përsëri", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CouldNotSubmitSaleException)
            {
                MetroMessageBox.Show(this, "Sinkronizimi per disa shitje nuk ishte i mundur. Ju lutemi provoni me vone.", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSynchronize.Enabled = true;
            this.LoadSales();
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
    }
}
