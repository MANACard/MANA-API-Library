using Mana.Cards.Client.CostumControls;

namespace Mana.Cards.Client
{
    partial class SalesCancellationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCancellationForm));
            this.gridSales = new MetroFramework.Controls.MetroGrid();
            this.txtCardBarcode = new Mana.Cards.Client.CostumControls.RoundedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblPartnerName = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel1 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.roundedPanel2 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.roundedPanel5 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.loadSalesBtn = new System.Windows.Forms.Button();
            this.roundedPanel4 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.btnResolveCard = new System.Windows.Forms.Button();
            this.roundedPanel8 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.roundedPanel11 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.btnSelectSale = new System.Windows.Forms.Button();
            this.roundedPanel3 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel8.SuspendLayout();
            this.roundedPanel11.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSales
            // 
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToDeleteRows = false;
            this.gridSales.AllowUserToResizeRows = false;
            this.gridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.EnableHeadersVisualStyles = false;
            this.gridSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSales.Location = new System.Drawing.Point(9, 75);
            this.gridSales.MultiSelect = false;
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSales.RowHeadersVisible = false;
            this.gridSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSales.Size = new System.Drawing.Size(756, 232);
            this.gridSales.Style = MetroFramework.MetroColorStyle.Purple;
            this.gridSales.TabIndex = 5;
            this.gridSales.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellDoubleClick);
            this.gridSales.SelectionChanged += new System.EventHandler(this.gridSales_SelectionChanged);
            // 
            // txtCardBarcode
            // 
            // 
            // 
            // 
            this.txtCardBarcode.CustomButton.Image = null;
            this.txtCardBarcode.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtCardBarcode.CustomButton.Name = "";
            this.txtCardBarcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCardBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCardBarcode.CustomButton.TabIndex = 1;
            this.txtCardBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCardBarcode.CustomButton.UseSelectable = true;
            this.txtCardBarcode.CustomButton.Visible = false;
            this.txtCardBarcode.Lines = new string[0];
            this.txtCardBarcode.Location = new System.Drawing.Point(3, 3);
            this.txtCardBarcode.MaxLength = 32767;
            this.txtCardBarcode.Name = "txtCardBarcode";
            this.txtCardBarcode.PasswordChar = '\0';
            this.txtCardBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardBarcode.SelectedText = "";
            this.txtCardBarcode.SelectionLength = 0;
            this.txtCardBarcode.SelectionStart = 0;
            this.txtCardBarcode.Size = new System.Drawing.Size(147, 23);
            this.txtCardBarcode.TabIndex = 0;
            this.txtCardBarcode.UseSelectable = true;
            this.txtCardBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCardBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.metroLabel1.Location = new System.Drawing.Point(9, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Kartela *:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPartnerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPartnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.lblPartnerName.Location = new System.Drawing.Point(18, 375);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(107, 19);
            this.lblPartnerName.TabIndex = 10;
            this.lblPartnerName.Text = "MANA Partner";
            this.lblPartnerName.UseCustomBackColor = true;
            this.lblPartnerName.UseCustomForeColor = true;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.lblPartnerName);
            this.roundedPanel1.Controls.Add(this.metroLabel3);
            this.roundedPanel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.Image = null;
            this.roundedPanel1.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel1.Location = new System.Drawing.Point(6, 26);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RoundCornerRadius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(826, 405);
            this.roundedPanel1.TabIndex = 14;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Controls.Add(this.roundedPanel5);
            this.roundedPanel2.Controls.Add(this.roundedPanel4);
            this.roundedPanel2.Controls.Add(this.roundedPanel8);
            this.roundedPanel2.Controls.Add(this.gridSales);
            this.roundedPanel2.Controls.Add(this.roundedPanel11);
            this.roundedPanel2.Controls.Add(this.roundedPanel3);
            this.roundedPanel2.Controls.Add(this.metroLabel1);
            this.roundedPanel2.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel2.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel2.Image = null;
            this.roundedPanel2.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel2.Location = new System.Drawing.Point(17, 47);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RoundCornerRadius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(782, 318);
            this.roundedPanel2.TabIndex = 13;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel5.BorderWidth = 2;
            this.roundedPanel5.Controls.Add(this.loadSalesBtn);
            this.roundedPanel5.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel5.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel5.Image = null;
            this.roundedPanel5.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel5.Location = new System.Drawing.Point(256, 40);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.RoundCornerRadius = 15;
            this.roundedPanel5.Size = new System.Drawing.Size(116, 34);
            this.roundedPanel5.TabIndex = 40;
            // 
            // loadSalesBtn
            // 
            this.loadSalesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.loadSalesBtn.FlatAppearance.BorderSize = 0;
            this.loadSalesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.loadSalesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.loadSalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSalesBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadSalesBtn.ForeColor = System.Drawing.Color.White;
            this.loadSalesBtn.Location = new System.Drawing.Point(3, 3);
            this.loadSalesBtn.Name = "loadSalesBtn";
            this.loadSalesBtn.Size = new System.Drawing.Size(105, 23);
            this.loadSalesBtn.TabIndex = 0;
            this.loadSalesBtn.Text = "Shfaq shitjet";
            this.loadSalesBtn.UseVisualStyleBackColor = false;
            this.loadSalesBtn.Click += new System.EventHandler(this.loadSalesBtn_Click);
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel4.BorderWidth = 2;
            this.roundedPanel4.Controls.Add(this.btnResolveCard);
            this.roundedPanel4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel4.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel4.Image = null;
            this.roundedPanel4.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel4.Location = new System.Drawing.Point(378, 40);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.RoundCornerRadius = 15;
            this.roundedPanel4.Size = new System.Drawing.Size(116, 34);
            this.roundedPanel4.TabIndex = 22;
            // 
            // btnResolveCard
            // 
            this.btnResolveCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.btnResolveCard.FlatAppearance.BorderSize = 0;
            this.btnResolveCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnResolveCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.btnResolveCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolveCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolveCard.ForeColor = System.Drawing.Color.White;
            this.btnResolveCard.Location = new System.Drawing.Point(3, 3);
            this.btnResolveCard.Name = "btnResolveCard";
            this.btnResolveCard.Size = new System.Drawing.Size(105, 23);
            this.btnResolveCard.TabIndex = 0;
            this.btnResolveCard.Text = "Gjej kartelën";
            this.btnResolveCard.UseVisualStyleBackColor = false;
            this.btnResolveCard.Click += new System.EventHandler(this.btnResolveCard_Click);
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.BorderWidth = 2;
            this.roundedPanel8.Controls.Add(this.btnRefresh);
            this.roundedPanel8.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.Image = null;
            this.roundedPanel8.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel8.Location = new System.Drawing.Point(543, 40);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.RoundCornerRadius = 15;
            this.roundedPanel8.Size = new System.Drawing.Size(116, 34);
            this.roundedPanel8.TabIndex = 39;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Fresko";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // roundedPanel11
            // 
            this.roundedPanel11.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.BorderWidth = 2;
            this.roundedPanel11.Controls.Add(this.btnSelectSale);
            this.roundedPanel11.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.Image = null;
            this.roundedPanel11.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel11.Location = new System.Drawing.Point(662, 40);
            this.roundedPanel11.Name = "roundedPanel11";
            this.roundedPanel11.RoundCornerRadius = 15;
            this.roundedPanel11.Size = new System.Drawing.Size(105, 34);
            this.roundedPanel11.TabIndex = 38;
            // 
            // btnSelectSale
            // 
            this.btnSelectSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.btnSelectSale.FlatAppearance.BorderSize = 0;
            this.btnSelectSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.btnSelectSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSale.ForeColor = System.Drawing.Color.White;
            this.btnSelectSale.Location = new System.Drawing.Point(3, 3);
            this.btnSelectSale.Name = "btnSelectSale";
            this.btnSelectSale.Size = new System.Drawing.Size(94, 23);
            this.btnSelectSale.TabIndex = 0;
            this.btnSelectSale.Text = "Anulo shitjen";
            this.btnSelectSale.UseVisualStyleBackColor = false;
            this.btnSelectSale.Click += new System.EventHandler(this.btnSelectSale_Click);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.BorderColor = System.Drawing.Color.Gray;
            this.roundedPanel3.BorderWidth = 2;
            this.roundedPanel3.Controls.Add(this.txtCardBarcode);
            this.roundedPanel3.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel3.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel3.Image = null;
            this.roundedPanel3.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel3.Location = new System.Drawing.Point(92, 40);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.RoundCornerRadius = 15;
            this.roundedPanel3.Size = new System.Drawing.Size(159, 34);
            this.roundedPanel3.TabIndex = 37;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.metroLabel3.Location = new System.Drawing.Point(18, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(145, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Anulimi i shitjeve";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // SalesCancellationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 431);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesCancellationForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Anulimi i shitjeve";
            this.Load += new System.EventHandler(this.UnsyncedSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel8.ResumeLayout(false);
            this.roundedPanel11.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridSales;
        private RoundedTextBox txtCardBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblPartnerName;
        private CostumControls.RoundedPanel roundedPanel1;
        private CostumControls.RoundedPanel roundedPanel2;
        private CostumControls.RoundedPanel roundedPanel11;
        private System.Windows.Forms.Button btnSelectSale;
        private CostumControls.RoundedPanel roundedPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private CostumControls.RoundedPanel roundedPanel5;
        private System.Windows.Forms.Button loadSalesBtn;
        private CostumControls.RoundedPanel roundedPanel4;
        private System.Windows.Forms.Button btnResolveCard;
        private CostumControls.RoundedPanel roundedPanel8;
        private System.Windows.Forms.Button btnRefresh;
    }
}