using System.IO;
using System.Runtime.CompilerServices;
using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Mana.Cards.API.Services;
using Mana.Cards.OfflineAPI.Exceptions;
using Mana.Cards.OfflineAPI.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mana.Cards.Client
{
    public partial class SalesForm : MetroForm
    {
        #region Properties
        private Sale sale;
        private CardInfo card;

        private bool ProcessMode;
        private bool ExternalRedeem;
        private bool DisableCancellation;
        private bool DisableSale;

        private string salesFileName;
        private string WriteToPath { get; set; }
        private string RandomToken { get; set; }

        public SaleInfo SaleInfo { get; set; }

        public RedeemRule RedeemRule { get; set; }

     

        #endregion

        #region CTORs
        public SalesForm(string[][] SaleData)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.BackColor = Color.FromArgb(198, 191, 185);
            WireUpEvents();

            sale = GetSale(SaleData);

            this.Initialize();
        }

        public SalesForm(List<SalesLineItem> items)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.BackColor = Color.FromArgb(198, 191, 185);
            WireUpEvents();

            this.sale = new Sale()
            {
                Items = items
            };

            this.Initialize();
        }
        public SalesForm(Sale sale, string writeToPath, string salesFileName, bool externalRedeem = false, bool disableCancellation = false, bool disableSale = false)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
       
           
          
            this.BackColor = Color.FromArgb(198, 191, 185);
            WireUpEvents();

            this.sale = sale;
            this.WriteToPath = writeToPath;
            this.ProcessMode = true;
            this.salesFileName = salesFileName;
            this.ExternalRedeem = externalRedeem;
            this.DisableCancellation = disableCancellation;
            this.DisableSale = disableSale;

            this.Initialize();
        }

        public SalesForm(Sale sale, bool externalRedeem = false, bool disableCancellation = false, bool disableSale = false)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.BackColor = Color.FromArgb(198, 191, 185);
            WireUpEvents();

            this.sale = sale;
            this.ExternalRedeem = externalRedeem;
            this.DisableCancellation = disableCancellation;
            this.DisableSale = disableSale;

            this.Initialize();
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

        #region Initialize
    private void Initialize()
        {
            this.RandomToken = RandomTokenHelper.GenerateToken();
            lblTotal.Text = lblTotalDiscount.Text = sale.Total.ToString("C" + Config.DecimalScale, CultureInfo.GetCultureInfo("de-DE"));
            lblTotal.Text = lblTotalDiscount.Text = sale.Total.ToString("C" + Config.DecimalScale, CultureInfo.GetCultureInfo("de-DE"));

            ICardService service = new CardService();
            this.RedeemRule = service.GetRedeemRule();

            lblMinPoints.Text = this.RedeemRule.MinimumRedeemablePoints.ToString();

            this.txtEmployeeCardBarcode.Text = EmployeeCardStore.Instance.Get();

            if (ExternalRedeem)
            {
                if (this.sale.Redeem.Points > 0)
                {
                    txtRedeemPoints.Text = this.sale.Redeem.Points.ToString();
                    txtRedeemPoints_KeyUp(null, null);
                }
                else if (this.sale.Redeem.Value > 0)
                {
                    txtRedeemValue.Text = this.sale.Redeem.Value.ToString();
                    txtRedeemValue_KeyUp(null, null);
                }


                txtRedeemValue.Enabled = txtRedeemPoints.Enabled = false;
            }

            if (this.DisableCancellation)
            {
                btnSalesCancellation.Visible = false;
            }


            if (sale.Id.HasValue)
            {
                editModeLbl.Visible = true;
            }
            pnlOfflineSales.Visible = metroLabel7.Visible = lblUnsynced.Visible = Config.EnableOfflineAPI;
            btnFinishSale.Enabled = !DisableSale;
        }
        #endregion

        #region GetSale
        private Sale GetSale(string[][] SaleData)
        {
            var theSale = new Sale { Items = new List<SalesLineItem>() };


            foreach (var item in SaleData)
            {
                theSale.Items.Add(SaleLineItemsParser.GetSalesLineItem(item));
            }

            return theSale;
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

                EmployeeCardStore.Instance.Set(this.sale.EmployeeCardBarcode);
                int redeem_points = 0;

                Int32.TryParse(txtRedeemPoints.Text, out redeem_points);

                this.sale.Redeem.Points = redeem_points;

                bool closeForm = false;

                try
                {
                    var saleInfo = service.SubmitSale(this.sale, this.RandomToken);

                    this.SaleInfo = saleInfo;


                    if (ProcessMode)
                    {
                        string[] obj = new string[] { this.SaleInfo.Id.ToString(), 
                            this.SaleInfo.RedeemedMonetaryValue.ToString(), 
                            this.SaleInfo.RedeemedPoints.ToString(), 
                            this.SaleInfo.RewardedPoints.ToString(), 
                            this.SaleInfo.Total.ToString(),
                            this.SaleInfo.RewardedValue.ToString(),
                            this.SaleInfo.DiscountValue.ToString()};

                        string o = string.Join(",", obj);

                        var outputFile = Path.GetFileName(Path.ChangeExtension(this.salesFileName, "mana"));

                        System.IO.File.WriteAllLines(String.Format("{0}\\{1}",
                            this.WriteToPath, outputFile),
                            new string[] { o });


                    }

                    //print ag

                    var printCouponOnCollect = Convert.ToBoolean(ConfigurationManager.AppSettings["PrintCouponOnCollect"]);
                    var printCouponOnReedem = Convert.ToBoolean(ConfigurationManager.AppSettings["PrintCouponOnReedem"]);
                    var openCouponFile = Convert.ToBoolean(ConfigurationManager.AppSettings["OpenCouponFile"]);

                    var couponsPath = ConfigurationManager.AppSettings["CouponsPath"];

                    if (!Directory.Exists(couponsPath))
                        Directory.CreateDirectory(couponsPath);

                    var print = new CouponPrinter(this.SaleInfo, couponsPath, txtClientName.Text,
   this.SaleInfo.AvailablePoints.ToString(), lblTotalDiscount.Text, txtCardBarcode.Text, openCouponFile, printCouponOnCollect, printCouponOnReedem);


                    closeForm = true;
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
                    closeForm = true;
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
                    Environment.Exit(500);
                }

                if (closeForm)
                {
                    this.Close();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Ju lutemi plotësoni fushat e kërkuara", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region ValidateFields
        private bool ValidateFields()
        {
            if (String.IsNullOrEmpty(txtCardBarcode.Text))
            {
                return false;
            }

            return true;
        }
        #endregion

        #region UI Events

        private void WireUpEvents()
        {
            this.clientRegistrationControl1.OnSuccessfulRegistration += new ClientRegistrationControl.RegistrationHandler(clientRegistrationControl1_OnSuccessfulRegistration);
        }

        private void clientRegistrationControl1_OnSuccessfulRegistration()
        {
            this.metroTabControl1.SelectedIndex = 0;
        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            lblUnsynced.Text = new SyncService().GetUnsyncedCount().ToString();
            txtCardBarcode.Select();
            this.lblPartnerName.Text = AuthenticationHelper.GetPartnerName();
            this.BringToFront();
            this.Focus();
            txtCardBarcode.Focus();
      
        }


        private void txtCardBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cardProgress.Show();
                txtRedeemPoints.Enabled = false;
                txtRedeemValue.Enabled = false;
                e.SuppressKeyPress = true;
                if(!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as CardInfo;

            if (result != null)
            {
                this.card = result;

                txtClientName.Text = String.Format("{0} {1}", this.card.ClientFirstName, this.card.ClientLastName);
                txtAvailablePoints.Text = this.card.AvailablePoints.ToString();


                txtRedeemPoints.Enabled = !ExternalRedeem;
                txtRedeemValue.Enabled = !ExternalRedeem;
            }
            cardProgress.Hide();
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
        private void txtRedeemPoints_KeyUp(object sender, KeyEventArgs e)
        {
            int points = 0;
            Int32.TryParse(txtRedeemPoints.Text, out points);
            decimal value = (points * this.RedeemRule.MonetaryValuePerPoint);

            UpdateDiscount(value);
            txtRedeemValue.Text = value.ToString();
        }

        private void txtRedeemValue_KeyUp(object sender, KeyEventArgs e)
        {
            decimal value = 0;
            Decimal.TryParse(txtRedeemValue.Text, out value);

            int points = (int)(value / this.RedeemRule.MonetaryValuePerPoint);

            txtRedeemPoints.Text = points.ToString();
            UpdateDiscount(value);
        }

        private void UpdateDiscount(decimal value)
        {
            decimal totalDiscount = (sale.Total - value);
            totalDiscount = totalDiscount < 0 ? 0 : totalDiscount;

            lblTotalDiscount.Text = value > 0 ? totalDiscount.ToString("C", CultureInfo.GetCultureInfo("de-DE")) : sale.Total.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
        }
        private void btnFinishSale_Click(object sender, EventArgs e)
        {
            btnFinishSale.Enabled = false;
            this.SubmitSale();
            btnFinishSale.Enabled = true;
        }
        private void lblUnsynced_Click(object sender, EventArgs e)
        {
            var form = new UnsyncedSalesForm();
            form.Show();
        }

        private void btnSalesCancellation_Click(object sender, EventArgs e)
        {
            var form = new SalesCancellationForm();

            form.Show();
        }
        private void btnResolveCard_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var form = new CardResolverForm();

            var result = form.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtCardBarcode.Text = form.Card.Barcode;
                txtCardBarcode.Focus();
                SendKeys.Send("{ENTER}");
                //txtCardBarcode_KeyDown(this,(char)Keys.Enter);


            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            cardProgress.Show();
            txtRedeemPoints.Enabled = false;
            txtRedeemValue.Enabled = false;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ChangeSelectedButton(true);
        }



        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ChangeSelectedButton(false);
        }
        #endregion

        #region Methods
        private void ChangeSelectedButton(bool SalesMode)
        {

            btnSale.ForeColor = SalesMode ? Color.White : Color.FromArgb(182, 31, 67);
            btnSale.BackColor = SalesMode ? Color.FromArgb(182, 31, 67) : Color.Transparent;
            btnAddClient.ForeColor = SalesMode ? Color.FromArgb(182, 31, 67) : Color.White;
            btnAddClient.BackColor = SalesMode ? Color.Transparent : Color.FromArgb(182, 31, 67);
            rpAddClient.GradientStartColor = SalesMode ? Color.Transparent : Color.FromArgb(182, 31, 67);
            rpAddClient.GradientEndColor = SalesMode ? Color.Transparent : Color.FromArgb(182, 31, 67);
            rpSale.GradientStartColor = SalesMode ? Color.FromArgb(182, 31, 67) : Color.Transparent;
            rpSale.GradientEndColor = SalesMode ? Color.FromArgb(182, 31, 67) : Color.Transparent;

            splitContainer1.Panel1Collapsed = !SalesMode;
            splitContainer1.Panel2Collapsed = SalesMode;
            if (!SalesMode)
            {
                clientRegistrationControl1.Focus();
                clientRegistrationControl1.firstName.Focus();

            }
            else
            {
                txtCardBarcode.Focus();
            }

        }
        #endregion
    }
}
