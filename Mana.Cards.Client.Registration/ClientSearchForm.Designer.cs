using Mana.Cards.Client.CostumControls;

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
            this.backgroundSearcher = new System.ComponentModel.BackgroundWorker();
            this.roundedPanel1 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.roundedPanel2 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.roundedPanel11 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.search = new System.Windows.Forms.Button();
            this.roundedPanel3 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.firstnameTxt = new Mana.Cards.Client.CostumControls.RoundedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel6 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.phoneTxt = new Mana.Cards.Client.CostumControls.RoundedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel5 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.lastnameTxt = new Mana.Cards.Client.CostumControls.RoundedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel4 = new Mana.Cards.Client.CostumControls.RoundedPanel();
            this.emailTxt = new Mana.Cards.Client.CostumControls.RoundedTextBox();
            this.clientsGrid = new MetroFramework.Controls.MetroGrid();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel11.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel6.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
            // 
            // backgroundSearcher
            // 
            this.backgroundSearcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSearcher_DoWork);
            this.backgroundSearcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSearcher_RunWorkerCompleted);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.clientsGrid);
            this.roundedPanel1.Controls.Add(this.metroLabel5);
            this.roundedPanel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.Image = null;
            this.roundedPanel1.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel1.Location = new System.Drawing.Point(1, 24);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RoundCornerRadius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(696, 361);
            this.roundedPanel1.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Controls.Add(this.roundedPanel11);
            this.roundedPanel2.Controls.Add(this.roundedPanel3);
            this.roundedPanel2.Controls.Add(this.metroLabel2);
            this.roundedPanel2.Controls.Add(this.metroLabel4);
            this.roundedPanel2.Controls.Add(this.roundedPanel6);
            this.roundedPanel2.Controls.Add(this.metroLabel1);
            this.roundedPanel2.Controls.Add(this.roundedPanel5);
            this.roundedPanel2.Controls.Add(this.metroLabel3);
            this.roundedPanel2.Controls.Add(this.roundedPanel4);
            this.roundedPanel2.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel2.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel2.Image = null;
            this.roundedPanel2.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel2.Location = new System.Drawing.Point(17, 43);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RoundCornerRadius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(656, 137);
            this.roundedPanel2.TabIndex = 2;
            // 
            // roundedPanel11
            // 
            this.roundedPanel11.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.BorderWidth = 2;
            this.roundedPanel11.Controls.Add(this.search);
            this.roundedPanel11.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.Image = null;
            this.roundedPanel11.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel11.Location = new System.Drawing.Point(456, 96);
            this.roundedPanel11.Name = "roundedPanel11";
            this.roundedPanel11.RoundCornerRadius = 15;
            this.roundedPanel11.Size = new System.Drawing.Size(176, 34);
            this.roundedPanel11.TabIndex = 4;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(3, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(165, 23);
            this.search.TabIndex = 0;
            this.search.Text = "Kërko";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.BorderColor = System.Drawing.Color.Gray;
            this.roundedPanel3.BorderWidth = 2;
            this.roundedPanel3.Controls.Add(this.firstnameTxt);
            this.roundedPanel3.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel3.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel3.Image = null;
            this.roundedPanel3.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel3.Location = new System.Drawing.Point(72, 24);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.RoundCornerRadius = 15;
            this.roundedPanel3.Size = new System.Drawing.Size(176, 34);
            this.roundedPanel3.TabIndex = 0;
            // 
            // firstnameTxt
            // 
            // 
            // 
            // 
            this.firstnameTxt.CustomButton.Image = null;
            this.firstnameTxt.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.firstnameTxt.CustomButton.Name = "";
            this.firstnameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstnameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstnameTxt.CustomButton.TabIndex = 1;
            this.firstnameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstnameTxt.CustomButton.UseSelectable = true;
            this.firstnameTxt.CustomButton.Visible = false;
            this.firstnameTxt.Lines = new string[0];
            this.firstnameTxt.Location = new System.Drawing.Point(3, 3);
            this.firstnameTxt.MaxLength = 32767;
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.PasswordChar = '\0';
            this.firstnameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstnameTxt.SelectedText = "";
            this.firstnameTxt.SelectionLength = 0;
            this.firstnameTxt.SelectionStart = 0;
            this.firstnameTxt.Size = new System.Drawing.Size(165, 23);
            this.firstnameTxt.TabIndex = 0;
            this.firstnameTxt.UseSelectable = true;
            this.firstnameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstnameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.metroLabel2.Location = new System.Drawing.Point(385, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mbiemri:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.metroLabel4.Location = new System.Drawing.Point(7, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "E-maili:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel6.BorderColor = System.Drawing.Color.Gray;
            this.roundedPanel6.BorderWidth = 2;
            this.roundedPanel6.Controls.Add(this.phoneTxt);
            this.roundedPanel6.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel6.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel6.Image = null;
            this.roundedPanel6.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel6.Location = new System.Drawing.Point(456, 56);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.RoundCornerRadius = 15;
            this.roundedPanel6.Size = new System.Drawing.Size(176, 34);
            this.roundedPanel6.TabIndex = 3;
            // 
            // phoneTxt
            // 
            // 
            // 
            // 
            this.phoneTxt.CustomButton.Image = null;
            this.phoneTxt.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.phoneTxt.CustomButton.Name = "";
            this.phoneTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTxt.CustomButton.TabIndex = 1;
            this.phoneTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTxt.CustomButton.UseSelectable = true;
            this.phoneTxt.CustomButton.Visible = false;
            this.phoneTxt.Lines = new string[0];
            this.phoneTxt.Location = new System.Drawing.Point(3, 3);
            this.phoneTxt.MaxLength = 32767;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.SelectionLength = 0;
            this.phoneTxt.SelectionStart = 0;
            this.phoneTxt.Size = new System.Drawing.Size(165, 23);
            this.phoneTxt.TabIndex = 0;
            this.phoneTxt.UseSelectable = true;
            this.phoneTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.metroLabel1.Location = new System.Drawing.Point(7, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Emri:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel5.BorderColor = System.Drawing.Color.Gray;
            this.roundedPanel5.BorderWidth = 2;
            this.roundedPanel5.Controls.Add(this.lastnameTxt);
            this.roundedPanel5.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel5.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel5.Image = null;
            this.roundedPanel5.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel5.Location = new System.Drawing.Point(456, 16);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.RoundCornerRadius = 15;
            this.roundedPanel5.Size = new System.Drawing.Size(176, 34);
            this.roundedPanel5.TabIndex = 2;
            // 
            // lastnameTxt
            // 
            // 
            // 
            // 
            this.lastnameTxt.CustomButton.Image = null;
            this.lastnameTxt.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.lastnameTxt.CustomButton.Name = "";
            this.lastnameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastnameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastnameTxt.CustomButton.TabIndex = 1;
            this.lastnameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastnameTxt.CustomButton.UseSelectable = true;
            this.lastnameTxt.CustomButton.Visible = false;
            this.lastnameTxt.Lines = new string[0];
            this.lastnameTxt.Location = new System.Drawing.Point(3, 3);
            this.lastnameTxt.MaxLength = 32767;
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.PasswordChar = '\0';
            this.lastnameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastnameTxt.SelectedText = "";
            this.lastnameTxt.SelectionLength = 0;
            this.lastnameTxt.SelectionStart = 0;
            this.lastnameTxt.Size = new System.Drawing.Size(165, 23);
            this.lastnameTxt.TabIndex = 0;
            this.lastnameTxt.UseSelectable = true;
            this.lastnameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastnameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.metroLabel3.Location = new System.Drawing.Point(385, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Nr. tel:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel4.BorderColor = System.Drawing.Color.Gray;
            this.roundedPanel4.BorderWidth = 2;
            this.roundedPanel4.Controls.Add(this.emailTxt);
            this.roundedPanel4.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel4.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel4.Image = null;
            this.roundedPanel4.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel4.Location = new System.Drawing.Point(72, 64);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.RoundCornerRadius = 15;
            this.roundedPanel4.Size = new System.Drawing.Size(176, 34);
            this.roundedPanel4.TabIndex = 1;
            // 
            // emailTxt
            // 
            // 
            // 
            // 
            this.emailTxt.CustomButton.Image = null;
            this.emailTxt.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.emailTxt.CustomButton.Name = "";
            this.emailTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTxt.CustomButton.TabIndex = 1;
            this.emailTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTxt.CustomButton.UseSelectable = true;
            this.emailTxt.CustomButton.Visible = false;
            this.emailTxt.Lines = new string[0];
            this.emailTxt.Location = new System.Drawing.Point(3, 3);
            this.emailTxt.MaxLength = 32767;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTxt.SelectedText = "";
            this.emailTxt.SelectionLength = 0;
            this.emailTxt.SelectionStart = 0;
            this.emailTxt.Size = new System.Drawing.Size(165, 23);
            this.emailTxt.TabIndex = 0;
            this.emailTxt.UseSelectable = true;
            this.emailTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientsGrid.EnableHeadersVisualStyles = false;
            this.clientsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGrid.Location = new System.Drawing.Point(17, 186);
            this.clientsGrid.MultiSelect = false;
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.ReadOnly = true;
            this.clientsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clientsGrid.RowHeadersVisible = false;
            this.clientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGrid.Size = new System.Drawing.Size(656, 148);
            this.clientsGrid.Style = MetroFramework.MetroColorStyle.Red;
            this.clientsGrid.TabIndex = 0;
            this.clientsGrid.UseStyleColors = true;
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.metroLabel5.Location = new System.Drawing.Point(17, 15);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(104, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Kërko klient";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // ClientSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 381);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientSearchForm";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Kërko klient";
            this.Load += new System.EventHandler(this.ClientSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel11.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private RoundedTextBox firstnameTxt;
        private RoundedTextBox lastnameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private RoundedTextBox emailTxt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid clientsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.ComponentModel.BackgroundWorker backgroundSearcher;
        private RoundedTextBox phoneTxt;
        private CostumControls.RoundedPanel roundedPanel6;
        private CostumControls.RoundedPanel roundedPanel5;
        private CostumControls.RoundedPanel roundedPanel4;
        private CostumControls.RoundedPanel roundedPanel3;
        private CostumControls.RoundedPanel roundedPanel1;
        private CostumControls.RoundedPanel roundedPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private RoundedPanel roundedPanel11;
        private System.Windows.Forms.Button search;
    }
}