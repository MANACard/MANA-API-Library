namespace Mana.Cards.Client
{
    partial class UnsyncedSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnsyncedSalesForm));
            this.gridSales = new MetroFramework.Controls.MetroGrid();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPartnerName = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel1 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.roundedPanel2 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel8 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.btnSynchronize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel8.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.EnableHeadersVisualStyles = false;
            this.gridSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSales.Location = new System.Drawing.Point(11, 35);
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
            this.gridSales.Size = new System.Drawing.Size(738, 226);
            this.gridSales.Style = MetroFramework.MetroColorStyle.Purple;
            this.gridSales.TabIndex = 0;
            this.gridSales.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridSales.SelectionChanged += new System.EventHandler(this.gridSales_SelectionChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPartnerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPartnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.lblPartnerName.Location = new System.Drawing.Point(11, 295);
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
            this.roundedPanel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.Image = null;
            this.roundedPanel1.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel1.Location = new System.Drawing.Point(1, 21);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RoundCornerRadius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(790, 331);
            this.roundedPanel1.TabIndex = 15;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Controls.Add(this.roundedPanel8);
            this.roundedPanel2.Controls.Add(this.metroLabel3);
            this.roundedPanel2.Controls.Add(this.gridSales);
            this.roundedPanel2.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel2.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel2.Image = null;
            this.roundedPanel2.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel2.Location = new System.Drawing.Point(11, 17);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RoundCornerRadius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(762, 275);
            this.roundedPanel2.TabIndex = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.metroLabel3.Location = new System.Drawing.Point(11, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(211, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Shitjet e pa-sinkronizuara";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.BorderWidth = 2;
            this.roundedPanel8.Controls.Add(this.btnSynchronize);
            this.roundedPanel8.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.roundedPanel8.Image = null;
            this.roundedPanel8.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel8.Location = new System.Drawing.Point(624, 3);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.RoundCornerRadius = 15;
            this.roundedPanel8.Size = new System.Drawing.Size(125, 34);
            this.roundedPanel8.TabIndex = 23;
            // 
            // btnSynchronize
            // 
            this.btnSynchronize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.btnSynchronize.FlatAppearance.BorderSize = 0;
            this.btnSynchronize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnSynchronize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.btnSynchronize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSynchronize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSynchronize.ForeColor = System.Drawing.Color.White;
            this.btnSynchronize.Location = new System.Drawing.Point(3, 3);
            this.btnSynchronize.Name = "btnSynchronize";
            this.btnSynchronize.Size = new System.Drawing.Size(114, 23);
            this.btnSynchronize.TabIndex = 0;
            this.btnSynchronize.Text = "Fillo sinkronizimin";
            this.btnSynchronize.UseVisualStyleBackColor = false;
            this.btnSynchronize.Click += new System.EventHandler(this.btnSynchronize_Click);
            // 
            // UnsyncedSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 348);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "UnsyncedSalesForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Shitjet e pa-sinkronizuara";
            this.Load += new System.EventHandler(this.UnsyncedSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridSales;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel lblPartnerName;
        private CostumControls.RoundedPanel roundedPanel1;
        private CostumControls.RoundedPanel roundedPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private CostumControls.RoundedPanel roundedPanel8;
        private System.Windows.Forms.Button btnSynchronize;
    }
}