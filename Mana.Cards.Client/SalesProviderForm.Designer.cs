namespace Mana.Cards.Client
{
    partial class SalesProviderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesProviderForm));
            this.roundedPanel1 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.roundedPanel2 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.roundedPanel4 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.btnSelectSale = new System.Windows.Forms.Button();
            this.roundedPanel3 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.roundedPanel8 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.btnSaleCancellation = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gridSales = new MetroFramework.Controls.MetroGrid();
            this.lblPartnerName = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.lblPartnerName);
            this.roundedPanel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.Image = null;
            this.roundedPanel1.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel1.Location = new System.Drawing.Point(3, 23);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RoundCornerRadius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(800, 375);
            this.roundedPanel1.TabIndex = 15;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Controls.Add(this.roundedPanel4);
            this.roundedPanel2.Controls.Add(this.roundedPanel3);
            this.roundedPanel2.Controls.Add(this.roundedPanel8);
            this.roundedPanel2.Controls.Add(this.metroLabel3);
            this.roundedPanel2.Controls.Add(this.gridSales);
            this.roundedPanel2.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel2.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel2.Image = null;
            this.roundedPanel2.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel2.Location = new System.Drawing.Point(21, 17);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RoundCornerRadius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(759, 324);
            this.roundedPanel2.TabIndex = 13;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel4.BorderWidth = 2;
            this.roundedPanel4.Controls.Add(this.btnSelectSale);
            this.roundedPanel4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel4.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel4.Image = null;
            this.roundedPanel4.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel4.Location = new System.Drawing.Point(639, 30);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.RoundCornerRadius = 15;
            this.roundedPanel4.Size = new System.Drawing.Size(104, 34);
            this.roundedPanel4.TabIndex = 24;
            // 
            // btnSelectSale
            // 
            this.btnSelectSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.btnSelectSale.FlatAppearance.BorderSize = 0;
            this.btnSelectSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnSelectSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.btnSelectSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSale.ForeColor = System.Drawing.Color.White;
            this.btnSelectSale.Location = new System.Drawing.Point(3, 3);
            this.btnSelectSale.Name = "btnSelectSale";
            this.btnSelectSale.Size = new System.Drawing.Size(93, 23);
            this.btnSelectSale.TabIndex = 0;
            this.btnSelectSale.Text = "Zgjedh shitjen";
            this.btnSelectSale.UseVisualStyleBackColor = false;
            this.btnSelectSale.Click += new System.EventHandler(this.btnSelectSale_Click);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel3.BorderWidth = 2;
            this.roundedPanel3.Controls.Add(this.btnRefresh);
            this.roundedPanel3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel3.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel3.Image = null;
            this.roundedPanel3.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel3.Location = new System.Drawing.Point(546, 30);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.RoundCornerRadius = 15;
            this.roundedPanel3.Size = new System.Drawing.Size(87, 34);
            this.roundedPanel3.TabIndex = 23;
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
            this.btnRefresh.Size = new System.Drawing.Size(77, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Fresko";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.BorderWidth = 2;
            this.roundedPanel8.Controls.Add(this.btnSaleCancellation);
            this.roundedPanel8.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.Image = null;
            this.roundedPanel8.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel8.Location = new System.Drawing.Point(20, 30);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.RoundCornerRadius = 15;
            this.roundedPanel8.Size = new System.Drawing.Size(116, 34);
            this.roundedPanel8.TabIndex = 22;
            // 
            // btnSaleCancellation
            // 
            this.btnSaleCancellation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.btnSaleCancellation.FlatAppearance.BorderSize = 0;
            this.btnSaleCancellation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnSaleCancellation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.btnSaleCancellation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleCancellation.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold);
            this.btnSaleCancellation.ForeColor = System.Drawing.Color.White;
            this.btnSaleCancellation.Location = new System.Drawing.Point(3, 3);
            this.btnSaleCancellation.Name = "btnSaleCancellation";
            this.btnSaleCancellation.Size = new System.Drawing.Size(105, 23);
            this.btnSaleCancellation.TabIndex = 0;
            this.btnSaleCancellation.Text = "Anulimi i shitjeve";
            this.btnSaleCancellation.UseVisualStyleBackColor = false;
            this.btnSaleCancellation.Click += new System.EventHandler(this.btnSaleCancellation_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.metroLabel3.Location = new System.Drawing.Point(13, 2);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Zgjedh shitjen";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // gridSales
            // 
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToDeleteRows = false;
            this.gridSales.AllowUserToResizeRows = false;
            this.gridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.EnableHeadersVisualStyles = false;
            this.gridSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSales.Location = new System.Drawing.Point(13, 68);
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
            this.gridSales.Size = new System.Drawing.Size(724, 245);
            this.gridSales.Style = MetroFramework.MetroColorStyle.Purple;
            this.gridSales.TabIndex = 0;
            this.gridSales.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellDoubleClick);
            this.gridSales.SelectionChanged += new System.EventHandler(this.gridSales_SelectionChanged);
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPartnerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPartnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.lblPartnerName.Location = new System.Drawing.Point(20, 344);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(107, 19);
            this.lblPartnerName.TabIndex = 9;
            this.lblPartnerName.Text = "MANA Partner";
            this.lblPartnerName.UseCustomBackColor = true;
            this.lblPartnerName.UseCustomForeColor = true;
            // 
            // SalesProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 395);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesProviderForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Zgjedh shitjen";
            this.Load += new System.EventHandler(this.UnsyncedSalesForm_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridSales;
        private MetroFramework.Controls.MetroLabel lblPartnerName;
        private CostumControls.RoundedPanel roundedPanel1;
        private CostumControls.RoundedPanel roundedPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private CostumControls.RoundedPanel roundedPanel4;
        private System.Windows.Forms.Button btnSelectSale;
        private CostumControls.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Button btnRefresh;
        private CostumControls.RoundedPanel roundedPanel8;
        private System.Windows.Forms.Button btnSaleCancellation;
    }
}