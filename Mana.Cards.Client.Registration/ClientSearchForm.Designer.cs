namespace Mana.Cards.Client
{
    partial class ClientSearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientSearchForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.firstnameTxt = new MetroFramework.Controls.MetroTextBox();
            this.lastnameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.emailTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.search = new MetroFramework.Controls.MetroButton();
            this.phoneTxt = new MetroFramework.Controls.MetroTextBox();
            this.clientsGrid = new MetroFramework.Controls.MetroGrid();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundSearcher = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Emri:";
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Lines = new string[0];
            this.firstnameTxt.Location = new System.Drawing.Point(60, 15);
            this.firstnameTxt.MaxLength = 32767;
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.PasswordChar = '\0';
            this.firstnameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstnameTxt.SelectedText = "";
            this.firstnameTxt.Size = new System.Drawing.Size(165, 23);
            this.firstnameTxt.TabIndex = 1;
            this.firstnameTxt.UseSelectable = true;
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Lines = new string[0];
            this.lastnameTxt.Location = new System.Drawing.Point(457, 15);
            this.lastnameTxt.MaxLength = 32767;
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.PasswordChar = '\0';
            this.lastnameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastnameTxt.SelectedText = "";
            this.lastnameTxt.Size = new System.Drawing.Size(165, 23);
            this.lastnameTxt.TabIndex = 3;
            this.lastnameTxt.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(389, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mbiemri:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(389, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Nr. tel:";
            // 
            // emailTxt
            // 
            this.emailTxt.Lines = new string[0];
            this.emailTxt.Location = new System.Drawing.Point(60, 55);
            this.emailTxt.MaxLength = 32767;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTxt.SelectedText = "";
            this.emailTxt.Size = new System.Drawing.Size(165, 23);
            this.emailTxt.TabIndex = 5;
            this.emailTxt.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(1, 59);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "E-maili:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.search);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.phoneTxt);
            this.metroPanel1.Controls.Add(this.firstnameTxt);
            this.metroPanel1.Controls.Add(this.emailTxt);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.lastnameTxt);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(633, 120);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(457, 92);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(165, 23);
            this.search.TabIndex = 10;
            this.search.Text = "Kërko";
            this.search.UseSelectable = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Lines = new string[0];
            this.phoneTxt.Location = new System.Drawing.Point(457, 55);
            this.phoneTxt.MaxLength = 32767;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.Size = new System.Drawing.Size(165, 23);
            this.phoneTxt.TabIndex = 7;
            this.phoneTxt.UseSelectable = true;
            // 
            // clientsGrid
            // 
            this.clientsGrid.AllowUserToAddRows = false;
            this.clientsGrid.AllowUserToDeleteRows = false;
            this.clientsGrid.AllowUserToResizeRows = false;
            this.clientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firstname,
            this.Lastname,
            this.Phone,
            this.Email,
            this.Birthyear,
            this.City});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientsGrid.EnableHeadersVisualStyles = false;
            this.clientsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGrid.Location = new System.Drawing.Point(24, 189);
            this.clientsGrid.MultiSelect = false;
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.ReadOnly = true;
            this.clientsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clientsGrid.RowHeadersVisible = false;
            this.clientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGrid.Size = new System.Drawing.Size(633, 150);
            this.clientsGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.clientsGrid.TabIndex = 9;
            this.clientsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsGrid_CellDoubleClick);
            this.clientsGrid.SelectionChanged += new System.EventHandler(this.clientsGrid_SelectionChanged);
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Emri";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Mbiemri";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Telefoni";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-maili";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Birthyear
            // 
            this.Birthyear.HeaderText = "Viti i lindjes";
            this.Birthyear.Name = "Birthyear";
            this.Birthyear.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "Qyteti";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // backgroundSearcher
            // 
            this.backgroundSearcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSearcher_DoWork);
            this.backgroundSearcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSearcher_RunWorkerCompleted);
            // 
            // ClientSearchForm
            // 
            this.AcceptButton = this.search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 352);
            this.Controls.Add(this.clientsGrid);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientSearchForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Kërko klient";
            this.Load += new System.EventHandler(this.ClientSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox firstnameTxt;
        private MetroFramework.Controls.MetroTextBox lastnameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox emailTxt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid clientsGrid;
        private MetroFramework.Controls.MetroButton search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.ComponentModel.BackgroundWorker backgroundSearcher;
        private MetroFramework.Controls.MetroTextBox phoneTxt;
    }
}