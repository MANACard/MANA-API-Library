using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Providers;
using Mana.Cards.OfflineAPI.Exceptions;
using Mana.Cards.OfflineAPI.Services;
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
using Mana.Cards.API.Helpers;
using System.Runtime.InteropServices;

namespace Mana.Cards.Client
{
    public partial class SalesProviderForm : MetroForm
    {
        private ISaleProvider _salesProvider;

        public SalesProviderForm(ISaleProvider salesProvider)
        {
            this._salesProvider = salesProvider;
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
            gridSales.DataSource = null;

            try
            {
                var saleList = _salesProvider.GetSales();

                var sales = saleList.Select(x => x.SaleDescriptor);

                var salesTable = this.ToDataTable(sales);



                gridSales.DataSource = salesTable;

                for (int i = 1; i < gridSales.Columns.Count; i++)
                {
                    gridSales.Columns[i].HeaderText = sales.FirstOrDefault().Fields.FirstOrDefault(x => x.Name == gridSales.Columns[i].Name).DisplayName;
                }

                gridSales.Refresh();

                gridSales.ClearSelection();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private DataTable ToDataTable(IEnumerable<SaleDescriptor> items)
        {
            var data = items.ToArray();
            if (data.Count() == 0) return null;

            var dt = new DataTable();

            dt.Columns.Add("ID");

            foreach (var field in data.FirstOrDefault().Fields)
            {
                dt.Columns.Add(field.Name);
            }
            foreach (var d in data)
            {

                dt.Rows.Add(new[] { d.Id }.Union(d.Fields.Select(x => x.Value.ToString())).ToArray());
            }
            return dt;
        }
        private void UnsyncedSalesForm_Load(object sender, EventArgs e)
        {
            this.lblPartnerName.Text = AuthenticationHelper.GetPartnerName();
            this.LoadSales();
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

            SelectSale(selectedId);
        }

        private void SelectSale(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var sale = _salesProvider.GetSale(id);

                if (sale != null)
                {
                    var form = new SalesForm(sale);
                    form.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Shitja nuk u gjet");
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadSales();
        }

        private void btnSelectSale_Click(object sender, EventArgs e)
        {
            if (gridSales.SelectedRows.Count != 0)
            {
                var row = gridSales.SelectedRows[0];


                if (gridSales["Id", row.Index] != null)
                {
                    SelectSale(gridSales["Id", row.Index].Value.ToString());
                }
            }
        }

        private void btnSaleCancellation_Click(object sender, EventArgs e)
        {
            var form = new SalesCancellationForm();

            form.Show();
        }
    }
}
