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
            this.btnSelectSale = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtCardBarcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.loadSalesBtn = new MetroFramework.Controls.MetroButton();
            this.lblPartnerName = new MetroFramework.Controls.MetroLabel();
            this.btnResolveCard = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.EnableHeadersVisualStyles = false;
            this.gridSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSales.Location = new System.Drawing.Point(24, 106);
            this.gridSales.MultiSelect = false;
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSales.RowHeadersVisible = false;
            this.gridSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSales.Size = new System.Drawing.Size(756, 235);
            this.gridSales.Style = MetroFramework.MetroColorStyle.Purple;
            this.gridSales.TabIndex = 5;
            this.gridSales.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellDoubleClick);
            this.gridSales.SelectionChanged += new System.EventHandler(this.gridSales_SelectionChanged);
            // 
            // btnSelectSale
            // 
            this.btnSelectSale.Location = new System.Drawing.Point(677, 63);
            this.btnSelectSale.Name = "btnSelectSale";
            this.btnSelectSale.Size = new System.Drawing.Size(103, 23);
            this.btnSelectSale.TabIndex = 4;
            this.btnSelectSale.Text = "Anulo shitjen";
            this.btnSelectSale.UseSelectable = true;
            this.btnSelectSale.Click += new System.EventHandler(this.btnSelectSale_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(557, 63);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Fresko";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtCardBarcode
            // 
            this.txtCardBarcode.Lines = new string[0];
            this.txtCardBarcode.Location = new System.Drawing.Point(92, 62);
            this.txtCardBarcode.MaxLength = 32767;
            this.txtCardBarcode.Name = "txtCardBarcode";
            this.txtCardBarcode.PasswordChar = '\0';
            this.txtCardBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardBarcode.SelectedText = "";
            this.txtCardBarcode.Size = new System.Drawing.Size(147, 23);
            this.txtCardBarcode.TabIndex = 0;
            this.txtCardBarcode.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Kartela *:";
            // 
            // loadSalesBtn
            // 
            this.loadSalesBtn.Location = new System.Drawing.Point(245, 62);
            this.loadSalesBtn.Name = "loadSalesBtn";
            this.loadSalesBtn.Size = new System.Drawing.Size(103, 23);
            this.loadSalesBtn.TabIndex = 1;
            this.loadSalesBtn.Text = "Shfaq shitjet";
            this.loadSalesBtn.UseSelectable = true;
            this.loadSalesBtn.Click += new System.EventHandler(this.loadSalesBtn_Click);
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Location = new System.Drawing.Point(24, 344);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(96, 19);
            this.lblPartnerName.TabIndex = 10;
            this.lblPartnerName.Text = "MANA Partner";
            // 
            // btnResolveCard
            // 
            this.btnResolveCard.Location = new System.Drawing.Point(354, 62);
            this.btnResolveCard.Name = "btnResolveCard";
            this.btnResolveCard.Size = new System.Drawing.Size(103, 23);
            this.btnResolveCard.TabIndex = 2;
            this.btnResolveCard.Text = "Gjej kartelën";
            this.btnResolveCard.UseSelectable = true;
            this.btnResolveCard.Click += new System.EventHandler(this.btnResolveCard_Click);
            // 
            // SalesCancellationForm
            // 
            this.AcceptButton = this.loadSalesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 373);
            this.Controls.Add(this.btnResolveCard);
            this.Controls.Add(this.lblPartnerName);
            this.Controls.Add(this.loadSalesBtn);
            this.Controls.Add(this.txtCardBarcode);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSelectSale);
            this.Controls.Add(this.gridSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesCancellationForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Anulimi i shitjeve";
            this.Load += new System.EventHandler(this.UnsyncedSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridSales;
        private MetroFramework.Controls.MetroButton btnSelectSale;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtCardBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton loadSalesBtn;
        private MetroFramework.Controls.MetroLabel lblPartnerName;
        private MetroFramework.Controls.MetroButton btnResolveCard;
    }
}