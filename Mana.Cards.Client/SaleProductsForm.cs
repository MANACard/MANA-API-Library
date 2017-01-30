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
using System.Runtime.InteropServices;
using Mana.Cards.API.ServiceInterfaces;
using Mana.Cards.Client.CustomControls;
using System.Globalization;
using System.Configuration;
using System.IO;
using Mana.Cards.OfflineAPI.Exceptions;

namespace Mana.Cards.Client
{
    public partial class SaleProductsForm : MetroForm
    {
        private ProductsViewModel products;
        private BindingList<SalesLineItem> salesLineItems = new BindingList<SalesLineItem>();
        private Sale sale = new Sale();
        private CardInfo card;
        private RedeemRule RedeemRule; 


        public SaleProductsForm()
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
        #region Form Load 
        private void UnsyncedSalesForm_Load(object sender, EventArgs e)
        {
            this.lblPartnerName.Text = AuthenticationHelper.GetPartnerName();
            ICardService service = new CardService();
            this.RedeemRule = service.GetRedeemRule();

            this.lblMinPoints.Text = this.RedeemRule.MinimumRedeemablePoints.ToString();

            BuildGrid();
            this.GetProducts();

            if (!Config.UseEmployeeCard)
            {
                txtEmployeeCardBarcode.Visible = lblEmployeeCard.Visible = roundedPanel14.Visible = false;
            }

            this.NewSale();

        }
        #endregion
        #region Grid Methods
        private void BuildGrid()
        {
            gridSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 83, 129);

            gridSales.DataSource = salesLineItems;

            gridSales.Columns["ItemIdentifier"].Visible = false;
            gridSales.Columns["Category"].Visible = false;
            gridSales.Columns["Vat"].Visible = false;

            gridSales.Columns["Barcode"].HeaderText = "Barkodi";
            gridSales.Columns["Barcode"].ReadOnly = true;

            gridSales.Columns["Title"].HeaderText = "Produkti";
            gridSales.Columns["Title"].ReadOnly = true;

            gridSales.Columns["Quantity"].HeaderText = "Sasia";
            gridSales.Columns["Price"].HeaderText = "Cmimi/njësi";
        }
        private void gridSales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ComputeTotals();
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
        #endregion

        #region Background Workers
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            IProductService service = new ProductService();

            try
            {
                this.products = service.GetProducts((int)e.Argument, 7);
                e.Result = this.products;
            }
            catch (AuthenticationFailedException ex)
            {

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IEnumerable<Product> products = ((ProductsViewModel)e.Result).Products;
            this.tableLayoutPanel1.SuspendLayout();

            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                if (control is RoundedPanel)
                {
                    this.tableLayoutPanel1.Controls.Remove(control);
                }
            }
            this.tableLayoutPanel1.ResumeLayout();
            this.tableLayoutPanel1.SuspendLayout();
            foreach (var product in products)
            {

                var button = new Button();
                button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
                button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.Color.White;
                button.Location = new System.Drawing.Point(0, 3);
                button.Name = "button1";
                button.Size = new System.Drawing.Size(80, 23);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Dock = DockStyle.Fill;
                button.Text = product.Title;

                button.UseVisualStyleBackColor = false;
                button.Tag = product;
                button.Click += productButton_Click;
                var rp = new RoundedPanel();

                rp.BackColor = System.Drawing.Color.Transparent;
                rp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
                rp.BorderWidth = 2;
                rp.Controls.Add(button);
                rp.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
                rp.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
                rp.Image = null;
                rp.ImageLocation = new System.Drawing.Point(4, 4);
                rp.Location = new System.Drawing.Point(3, 3);
                rp.Name = "roundedPanel3";
                rp.RoundCornerRadius = 15;
                //                rp.Size = new System.Drawing.Size(160, 34);
                //     rp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;

                this.tableLayoutPanel1.Controls.Add(rp);
            }

            this.tableLayoutPanel1.ResumeLayout();
            btnPrevious.Enabled = this.products.HasPrevious();
            btnNext.Enabled = this.products.HasNext();
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = new CardService().GetCardInfo(txtCardBarcode.Text);
            }
            catch (CardNotFoundException)
            {
                MetroMessageBox.Show(this, "Kartela nuk ekziston", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as CardInfo;

            if (result != null)
            {
                this.card = result;

                txtClientName.Text = String.Format("{0} {1}", this.card.ClientFirstName, this.card.ClientLastName);
                txtAvailablePoints.Text = this.card.AvailablePoints.ToString();

                txtRedeemPoints.Enabled = true;
                txtRedeemValue.Enabled = true;
            }
            cardProgress.Hide();
        }
        #endregion
        #region Text Events
        private void txtCardBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cardProgress.Show();
                txtRedeemPoints.Enabled = false;
                txtRedeemValue.Enabled = false;
                e.SuppressKeyPress = true;
                if (!backgroundWorker2.IsBusy)
                    backgroundWorker2.RunWorkerAsync();
            }
        }
        private void txtRedeemValue_KeyUp(object sender, KeyEventArgs e)
        {
            decimal value = 0;
            Decimal.TryParse(txtRedeemValue.Text, out value);

            int points = (int)(value / this.RedeemRule.MonetaryValuePerPoint);

            txtRedeemPoints.Text = points.ToString();
           
            ComputeTotals();
        }

        private void txtRedeemPoints_KeyUp(object sender, KeyEventArgs e)
        {
            int points = 0;
            Int32.TryParse(txtRedeemPoints.Text, out points);
            decimal value = (points * this.RedeemRule.MonetaryValuePerPoint);

            txtRedeemValue.Text = value.ToString();
            ComputeTotals();
        }

        private void txtRedeemPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtRedeemValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Button Events
        private void lblUnsynced_Click(object sender, EventArgs e)
        {
            var form = new UnsyncedSalesForm();
            form.Show();
        }
        void productButton_Click(object sender, EventArgs e)
        {
            var product = (Product)((Button)sender).Tag;

            this.salesLineItems.Add(new SalesLineItem()
            {

                Barcode = product.Barcode,
                Title = product.Title,
                Price = product.Price.HasValue ? product.Price.Value : 0,
                Quantity = 1
            });
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.GetProducts(this.products.Meta.Page + 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.GetProducts(this.products.Meta.Page - 1);
        }

        private void btnSalesCancellation_Click(object sender, EventArgs e)
        {
            var form = new SalesCancellationForm();

            form.BringToFront();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new CardResolverForm();

            var result = form.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtCardBarcode.Text = form.Card.Barcode;
                txtCardBarcode.Focus();
                SendKeys.Send("{ENTER}");

            }
        }
        private void btnFinishSale_Click(object sender, EventArgs e)
        {
            btnFinishSale.Enabled = false;
            this.SubmitSale();
            btnFinishSale.Enabled = true;
        }
        #endregion

        #region ValidateFields
        private bool ValidateFields()
        {
            if (String.IsNullOrEmpty(txtCardBarcode.Text) || this.salesLineItems.Count == 0)
            {
                return false;
            }

            return true;
        }
        #endregion
        #region NewSale
        public void NewSale() {
            this.sale = new Sale();
            this.sale.TransactionId = RandomTokenHelper.GenerateToken();
            this.salesLineItems.Clear();
            this.ComputeTotals();

            this.txtCardBarcode.Text = "";
            this.txtClientName.Text = "";

        }
        #endregion
        #region SubmitSale
        private void SubmitSale()
        {
            ISaleService service = new OfflineAPI.Services.SaleService();

            if (ValidateFields())
            {
                this.sale.CardBarcode = txtCardBarcode.Text;
                this.sale.EmployeeCardBarcode = txtEmployeeCardBarcode.Text;
                this.sale.Items = this.salesLineItems.ToList();

                EmployeeCardStore.Instance.Set(this.sale.EmployeeCardBarcode);
                int redeem_points = 0;

                Int32.TryParse(txtRedeemPoints.Text, out redeem_points);

                this.sale.Redeem.Points = redeem_points;

                bool submitted = false;

                try
                {
                    var saleInfo = service.SubmitSale(this.sale, this.sale.TransactionId);

                    if (!string.IsNullOrEmpty(saleInfo.CustomMessage))
                    {
                        MetroMessageBox.Show(this, saleInfo.CustomMessage, "Informate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    submitted = true;


                    //print ag

                    var printCouponOnCollect = Convert.ToBoolean(ConfigurationManager.AppSettings["PrintCouponOnCollect"]);
                    var printCouponOnReedem = Convert.ToBoolean(ConfigurationManager.AppSettings["PrintCouponOnReedem"]);
                    var openCouponFile = Convert.ToBoolean(ConfigurationManager.AppSettings["OpenCouponFile"]);

                    var couponsPath = ConfigurationManager.AppSettings["CouponsPath"];

                    if (!Directory.Exists(couponsPath))
                        Directory.CreateDirectory(couponsPath);
                    
                    var print = new CouponPrinter(saleInfo, couponsPath, txtClientName.Text, saleInfo.AvailablePoints.ToString(), lblTotalDiscount.Text, txtCardBarcode.Text, openCouponFile, printCouponOnCollect, printCouponOnReedem);
                }
                catch (NotEnoughPointsAvailableException)
                {
                    MetroMessageBox.Show(this, "Ju nuk keni mjaft pikë në dispozicion", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MorePointsRequiredException)
                {
                    MetroMessageBox.Show(this, "Numri i pikëve të kërkuara për shfrytëzim nuk tejkalon minimumin e kërkuar", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (CardNotActiveException)
                {
                    MetroMessageBox.Show(this, "Kartela ende nuk është aktive", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (CardNotFoundException)
                {
                    MetroMessageBox.Show(this, "Kartela nuk ekziston", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (AuthenticationFailedException)
                {
                    MetroMessageBox.Show(this, "Auth error", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SaleAlreadySubmittedException)
                {
                    MetroMessageBox.Show(this, "Shitja tashmë është regjistruar", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (WebException)
                {
                    MetroMessageBox.Show(this, "Ka ndodhur një gabim. Ju lutemi provoni përsëri", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (CouldNotSubmitSaleException e)
                {
                    MetroMessageBox.Show(this, "Shitja është regjistruar lokalisht, mirëpo nuk ka arritur në server. Për shkak të kësaj, shfrytëzimi i pikëve është i pamundur. Sistemi do të provojë më vonë përsëri.", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.NewSale();
                }
                catch (UnauthorizedCancellationException)
                {
                    MetroMessageBox.Show(this, "Numri i kartelës nuk është i njejtë me atë me të cilën është bërë shitja.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SaleAlreadyCanceledException)
                {
                    MetroMessageBox.Show(this, "Kjo shitje tashmë është anuluar", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (submitted)
                {
                    this.NewSale();
                }

            }
            else
            {
                MetroMessageBox.Show(this, "Ju lutemi plotësoni fushat e kërkuara", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
        #region ComputeTotals
        private void ComputeTotals()
        {
            var total = this.salesLineItems.Sum(x => x.Price * x.Quantity);

            decimal redeemValue = 0;

            Decimal.TryParse(txtRedeemValue.Text, out redeemValue);

            this.lblTotal.Text = total.ToString("C", CultureInfo.GetCultureInfo("de-DE"));


            this.lblTotalDiscount.Text = (total - redeemValue).ToString("C", CultureInfo.GetCultureInfo("de-DE"));

        }
        #endregion
        #region GetProducts
        private void GetProducts(int page = 1)
        {
            this.btnNext.Enabled = false;
            this.btnPrevious.Enabled = false;

            backgroundWorker1.RunWorkerAsync(page);
        }
        #endregion
    }
}
