namespace Mana.Cards.Client
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnFinishSale = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblTotalDiscount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnResolveCard = new System.Windows.Forms.Button();
            this.txtClientName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblMinPoints = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cardProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.txtRedeemValue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtRedeemPoints = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAvailablePoints = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCardBarcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblUnsynced = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pnlOfflineSales = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.salesDetails = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.clientRegistrationControl1 = new Mana.Cards.Client.ClientRegistrationControl();
            this.btnSalesCancellation = new MetroFramework.Controls.MetroButton();
            this.lblPartnerName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.salesDetails.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnFinishSale);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(737, 211);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnFinishSale
            // 
            this.btnFinishSale.Location = new System.Drawing.Point(630, 177);
            this.btnFinishSale.Name = "btnFinishSale";
            this.btnFinishSale.Size = new System.Drawing.Size(103, 23);
            this.btnFinishSale.TabIndex = 4;
            this.btnFinishSale.Text = "Përfundo shitjen";
            this.btnFinishSale.UseSelectable = true;
            this.btnFinishSale.Click += new System.EventHandler(this.btnFinishSale_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.lblTotalDiscount);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.lblTotal);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(390, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(344, 159);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDiscount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalDiscount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDiscount.Location = new System.Drawing.Point(252, 60);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(72, 25);
            this.lblTotalDiscount.Style = MetroFramework.MetroColorStyle.Red;
            this.lblTotalDiscount.TabIndex = 5;
            this.lblTotalDiscount.Text = "€ 45.35";
            this.lblTotalDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalDiscount.UseCustomBackColor = true;
            this.lblTotalDiscount.UseCustomForeColor = true;
            this.lblTotalDiscount.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(175, 47);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(71, 38);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Totali\r\nme zbritje:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotal.Location = new System.Drawing.Point(252, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 25);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "€ 45.35";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(175, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Totali:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnResolveCard);
            this.metroPanel2.Controls.Add(this.txtClientName);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.lblMinPoints);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.cardProgress);
            this.metroPanel2.Controls.Add(this.txtRedeemValue);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.txtRedeemPoints);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.txtAvailablePoints);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.txtCardBarcode);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(381, 203);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnResolveCard
            // 
            this.btnResolveCard.Location = new System.Drawing.Point(292, 7);
            this.btnResolveCard.Name = "btnResolveCard";
            this.btnResolveCard.Size = new System.Drawing.Size(75, 23);
            this.btnResolveCard.TabIndex = 15;
            this.btnResolveCard.Text = "Gjej kartelën";
            this.btnResolveCard.UseVisualStyleBackColor = true;
            this.btnResolveCard.Click += new System.EventHandler(this.btnResolveCard_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Lines = new string[0];
            this.txtClientName.Location = new System.Drawing.Point(139, 53);
            this.txtClientName.MaxLength = 32767;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PasswordChar = '\0';
            this.txtClientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientName.SelectedText = "";
            this.txtClientName.Size = new System.Drawing.Size(147, 23);
            this.txtClientName.TabIndex = 14;
            this.txtClientName.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(9, 57);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Klienti:";
            // 
            // lblMinPoints
            // 
            this.lblMinPoints.AutoSize = true;
            this.lblMinPoints.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMinPoints.Location = new System.Drawing.Point(256, 134);
            this.lblMinPoints.Name = "lblMinPoints";
            this.lblMinPoints.Size = new System.Drawing.Size(17, 19);
            this.lblMinPoints.TabIndex = 12;
            this.lblMinPoints.Text = "0";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(213, 134);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(37, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Min.:";
            // 
            // cardProgress
            // 
            this.cardProgress.Location = new System.Drawing.Point(292, 7);
            this.cardProgress.Maximum = 100;
            this.cardProgress.Name = "cardProgress";
            this.cardProgress.Size = new System.Drawing.Size(32, 23);
            this.cardProgress.Style = MetroFramework.MetroColorStyle.Purple;
            this.cardProgress.TabIndex = 10;
            this.cardProgress.UseSelectable = true;
            this.cardProgress.Visible = false;
            // 
            // txtRedeemValue
            // 
            this.txtRedeemValue.Enabled = false;
            this.txtRedeemValue.Lines = new string[0];
            this.txtRedeemValue.Location = new System.Drawing.Point(139, 169);
            this.txtRedeemValue.MaxLength = 32767;
            this.txtRedeemValue.Name = "txtRedeemValue";
            this.txtRedeemValue.PasswordChar = '\0';
            this.txtRedeemValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRedeemValue.SelectedText = "";
            this.txtRedeemValue.Size = new System.Drawing.Size(67, 23);
            this.txtRedeemValue.TabIndex = 9;
            this.txtRedeemValue.UseSelectable = true;
            this.txtRedeemValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedeemValue_KeyPress);
            this.txtRedeemValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRedeemValue_KeyUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Vlera në EUR:";
            // 
            // txtRedeemPoints
            // 
            this.txtRedeemPoints.Enabled = false;
            this.txtRedeemPoints.Lines = new string[0];
            this.txtRedeemPoints.Location = new System.Drawing.Point(139, 130);
            this.txtRedeemPoints.MaxLength = 32767;
            this.txtRedeemPoints.Name = "txtRedeemPoints";
            this.txtRedeemPoints.PasswordChar = '\0';
            this.txtRedeemPoints.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRedeemPoints.SelectedText = "";
            this.txtRedeemPoints.Size = new System.Drawing.Size(67, 23);
            this.txtRedeemPoints.TabIndex = 7;
            this.txtRedeemPoints.UseSelectable = true;
            this.txtRedeemPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedeemPoints_KeyPress);
            this.txtRedeemPoints.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRedeemPoints_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Pikët për shfrytëzim:";
            // 
            // txtAvailablePoints
            // 
            this.txtAvailablePoints.Enabled = false;
            this.txtAvailablePoints.ForeColor = System.Drawing.Color.Red;
            this.txtAvailablePoints.Lines = new string[0];
            this.txtAvailablePoints.Location = new System.Drawing.Point(139, 92);
            this.txtAvailablePoints.MaxLength = 32767;
            this.txtAvailablePoints.Name = "txtAvailablePoints";
            this.txtAvailablePoints.PasswordChar = '\0';
            this.txtAvailablePoints.ReadOnly = true;
            this.txtAvailablePoints.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAvailablePoints.SelectedText = "";
            this.txtAvailablePoints.Size = new System.Drawing.Size(67, 23);
            this.txtAvailablePoints.TabIndex = 5;
            this.txtAvailablePoints.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Pikët në dispozicion:";
            // 
            // txtCardBarcode
            // 
            this.txtCardBarcode.Lines = new string[0];
            this.txtCardBarcode.Location = new System.Drawing.Point(139, 7);
            this.txtCardBarcode.MaxLength = 32767;
            this.txtCardBarcode.Name = "txtCardBarcode";
            this.txtCardBarcode.PasswordChar = '\0';
            this.txtCardBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardBarcode.SelectedText = "";
            this.txtCardBarcode.Size = new System.Drawing.Size(147, 23);
            this.txtCardBarcode.TabIndex = 3;
            this.txtCardBarcode.UseSelectable = true;
            this.txtCardBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardBarcode_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Kartela *:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblUnsynced
            // 
            this.lblUnsynced.AutoSize = true;
            this.lblUnsynced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUnsynced.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUnsynced.Location = new System.Drawing.Point(720, 232);
            this.lblUnsynced.Name = "lblUnsynced";
            this.lblUnsynced.Size = new System.Drawing.Size(16, 19);
            this.lblUnsynced.TabIndex = 2;
            this.lblUnsynced.Text = "0";
            this.lblUnsynced.UseCustomForeColor = true;
            this.lblUnsynced.Click += new System.EventHandler(this.lblUnsynced_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(493, 231);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(215, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Shitje të pasinkronizuara me server:";
            // 
            // pnlOfflineSales
            // 
            this.pnlOfflineSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOfflineSales.HorizontalScrollbarBarColor = true;
            this.pnlOfflineSales.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlOfflineSales.HorizontalScrollbarSize = 10;
            this.pnlOfflineSales.Location = new System.Drawing.Point(486, 227);
            this.pnlOfflineSales.Name = "pnlOfflineSales";
            this.pnlOfflineSales.Size = new System.Drawing.Size(254, 28);
            this.pnlOfflineSales.TabIndex = 4;
            this.pnlOfflineSales.VerticalScrollbarBarColor = true;
            this.pnlOfflineSales.VerticalScrollbarHighlightOnWheel = false;
            this.pnlOfflineSales.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.salesDetails);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(753, 334);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            // 
            // salesDetails
            // 
            this.salesDetails.Controls.Add(this.metroLabel7);
            this.salesDetails.Controls.Add(this.lblUnsynced);
            this.salesDetails.Controls.Add(this.metroPanel1);
            this.salesDetails.Controls.Add(this.pnlOfflineSales);
            this.salesDetails.Enabled = true;
            this.salesDetails.HorizontalScrollbarBarColor = true;
            this.salesDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.salesDetails.HorizontalScrollbarSize = 10;
            this.salesDetails.Location = new System.Drawing.Point(4, 38);
            this.salesDetails.Name = "salesDetails";
            this.salesDetails.Size = new System.Drawing.Size(745, 292);
            this.salesDetails.TabIndex = 0;
            this.salesDetails.Text = "Shitja";
            this.salesDetails.VerticalScrollbarBarColor = true;
            this.salesDetails.VerticalScrollbarHighlightOnWheel = false;
            this.salesDetails.VerticalScrollbarSize = 10;
            this.salesDetails.Visible = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.clientRegistrationControl1);
            this.metroTabPage1.Enabled = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(745, 292);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Regjistrimi i klientit";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Visible = false;
            // 
            // clientRegistrationControl1
            // 
            this.clientRegistrationControl1.Location = new System.Drawing.Point(4, 4);
            this.clientRegistrationControl1.Name = "clientRegistrationControl1";
            this.clientRegistrationControl1.Size = new System.Drawing.Size(745, 292);
            this.clientRegistrationControl1.TabIndex = 2;
            this.clientRegistrationControl1.UseSelectable = true;
            // 
            // btnSalesCancellation
            // 
            this.btnSalesCancellation.Location = new System.Drawing.Point(665, 396);
            this.btnSalesCancellation.Name = "btnSalesCancellation";
            this.btnSalesCancellation.Size = new System.Drawing.Size(103, 23);
            this.btnSalesCancellation.TabIndex = 6;
            this.btnSalesCancellation.Text = "Anulimi i shitjeve";
            this.btnSalesCancellation.UseSelectable = true;
            this.btnSalesCancellation.Click += new System.EventHandler(this.btnSalesCancellation_Click);
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Location = new System.Drawing.Point(31, 400);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(96, 19);
            this.lblPartnerName.TabIndex = 8;
            this.lblPartnerName.Text = "MANA Partner";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 442);
            this.Controls.Add(this.lblPartnerName);
            this.Controls.Add(this.btnSalesCancellation);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Shitje përmes";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.salesDetails.ResumeLayout(false);
            this.salesDetails.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCardBarcode;
        private MetroFramework.Controls.MetroTextBox txtAvailablePoints;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtRedeemPoints;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRedeemValue;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblTotalDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnFinishSale;
        private MetroFramework.Controls.MetroProgressSpinner cardProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel lblMinPoints;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblUnsynced;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel pnlOfflineSales;
        private MetroFramework.Controls.MetroTextBox txtClientName;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage salesDetails;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private ClientRegistrationControl clientRegistrationControl1;
        private MetroFramework.Controls.MetroButton btnSalesCancellation;
        private MetroFramework.Controls.MetroLabel lblPartnerName;
        private System.Windows.Forms.Button btnResolveCard;
    }
}