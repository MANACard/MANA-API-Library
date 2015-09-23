namespace Mana.Cards.Client
{
    partial class ClientRegistrationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.agree = new System.Windows.Forms.CheckBox();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.city = new System.Windows.Forms.TextBox();
            this.gender = new MetroFramework.Controls.MetroComboBox();
            this.card = new MetroFramework.Controls.MetroTextBox();
            this.cardLabel = new MetroFramework.Controls.MetroLabel();
            this.address = new MetroFramework.Controls.MetroTextBox();
            this.registerClient = new MetroFramework.Controls.MetroButton();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.phone = new MetroFramework.Controls.MetroTextBox();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.phoneLabel = new MetroFramework.Controls.MetroLabel();
            this.lastName = new MetroFramework.Controls.MetroTextBox();
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.firstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.birthdateLabel = new MetroFramework.Controls.MetroLabel();
            this.cityLabel = new MetroFramework.Controls.MetroLabel();
            this.searchClient = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clearFieldsBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.linkLabel1);
            this.metroPanel5.Controls.Add(this.agree);
            this.metroPanel5.Controls.Add(this.birth_date);
            this.metroPanel5.Controls.Add(this.city);
            this.metroPanel5.Controls.Add(this.gender);
            this.metroPanel5.Controls.Add(this.card);
            this.metroPanel5.Controls.Add(this.cardLabel);
            this.metroPanel5.Controls.Add(this.address);
            this.metroPanel5.Controls.Add(this.registerClient);
            this.metroPanel5.Controls.Add(this.metroLabel15);
            this.metroPanel5.Controls.Add(this.email);
            this.metroPanel5.Controls.Add(this.phone);
            this.metroPanel5.Controls.Add(this.emailLabel);
            this.metroPanel5.Controls.Add(this.firstNameLabel);
            this.metroPanel5.Controls.Add(this.phoneLabel);
            this.metroPanel5.Controls.Add(this.lastName);
            this.metroPanel5.Controls.Add(this.lastNameLabel);
            this.metroPanel5.Controls.Add(this.firstName);
            this.metroPanel5.Controls.Add(this.metroLabel18);
            this.metroPanel5.Controls.Add(this.birthdateLabel);
            this.metroPanel5.Controls.Add(this.cityLabel);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(8, 47);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(730, 228);
            this.metroPanel5.TabIndex = 16;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(526, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "kushtet dhe afatet";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.BackColor = System.Drawing.Color.Transparent;
            this.agree.Location = new System.Drawing.Point(461, 166);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(70, 17);
            this.agree.TabIndex = 9;
            this.agree.Text = "Pajtohem";
            this.agree.UseVisualStyleBackColor = false;
            // 
            // birth_date
            // 
            this.birth_date.CustomFormat = "dd/MM/yyyy";
            this.birth_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_date.Location = new System.Drawing.Point(461, 55);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(158, 20);
            this.birth_date.TabIndex = 6;
            // 
            // city
            // 
            this.city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.city.BackColor = System.Drawing.SystemColors.Control;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(461, 12);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(158, 22);
            this.city.TabIndex = 5;
            this.city.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.ItemHeight = 23;
            this.gender.Location = new System.Drawing.Point(461, 91);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(158, 29);
            this.gender.Style = MetroFramework.MetroColorStyle.Purple;
            this.gender.TabIndex = 7;
            this.gender.UseSelectable = true;
            // 
            // card
            // 
            this.card.Lines = new string[0];
            this.card.Location = new System.Drawing.Point(461, 133);
            this.card.MaxLength = 32767;
            this.card.Name = "card";
            this.card.PasswordChar = '\0';
            this.card.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.card.SelectedText = "";
            this.card.Size = new System.Drawing.Size(158, 23);
            this.card.TabIndex = 8;
            this.card.UseSelectable = true;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(380, 134);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(53, 19);
            this.cardLabel.TabIndex = 30;
            this.cardLabel.Text = "Kartela:";
            // 
            // address
            // 
            this.address.Lines = new string[0];
            this.address.Location = new System.Drawing.Point(134, 171);
            this.address.MaxLength = 32767;
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address.SelectedText = "";
            this.address.Size = new System.Drawing.Size(158, 23);
            this.address.TabIndex = 4;
            this.address.UseSelectable = true;
            // 
            // registerClient
            // 
            this.registerClient.Location = new System.Drawing.Point(461, 192);
            this.registerClient.Name = "registerClient";
            this.registerClient.Size = new System.Drawing.Size(158, 23);
            this.registerClient.TabIndex = 10;
            this.registerClient.Text = "Regjistro klientin";
            this.registerClient.UseSelectable = true;
            this.registerClient.Click += new System.EventHandler(this.registerClient_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(60, 174);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(53, 19);
            this.metroLabel15.TabIndex = 28;
            this.metroLabel15.Text = "Adresa:";
            // 
            // email
            // 
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(134, 130);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(158, 23);
            this.email.TabIndex = 3;
            this.email.UseSelectable = true;
            // 
            // phone
            // 
            this.phone.Lines = new string[0];
            this.phone.Location = new System.Drawing.Point(134, 91);
            this.phone.MaxLength = 32767;
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phone.SelectedText = "";
            this.phone.Size = new System.Drawing.Size(158, 23);
            this.phone.TabIndex = 2;
            this.phone.UseSelectable = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(60, 133);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 19);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "E-maili:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(60, 11);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(39, 19);
            this.firstNameLabel.TabIndex = 18;
            this.firstNameLabel.Text = "Emri:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(60, 91);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(46, 19);
            this.phoneLabel.TabIndex = 22;
            this.phoneLabel.Text = "Nr. tel:";
            // 
            // lastName
            // 
            this.lastName.Lines = new string[0];
            this.lastName.Location = new System.Drawing.Point(134, 49);
            this.lastName.MaxLength = 32767;
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastName.SelectedText = "";
            this.lastName.Size = new System.Drawing.Size(158, 23);
            this.lastName.TabIndex = 1;
            this.lastName.UseSelectable = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(60, 50);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(62, 19);
            this.lastNameLabel.TabIndex = 20;
            this.lastNameLabel.Text = "Mbiemri:";
            // 
            // firstName
            // 
            this.firstName.Lines = new string[0];
            this.firstName.Location = new System.Drawing.Point(134, 11);
            this.firstName.MaxLength = 32767;
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstName.SelectedText = "";
            this.firstName.Size = new System.Drawing.Size(158, 23);
            this.firstName.TabIndex = 0;
            this.firstName.UseSelectable = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(380, 94);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(44, 19);
            this.metroLabel18.TabIndex = 16;
            this.metroLabel18.Text = "Gjinia:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(380, 54);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(59, 19);
            this.birthdateLabel.TabIndex = 14;
            this.birthdateLabel.Text = "D.lindjes:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(380, 12);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(81, 19);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "Vendbanimi:";
            // 
            // searchClient
            // 
            this.searchClient.Location = new System.Drawing.Point(470, 18);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(130, 23);
            this.searchClient.TabIndex = 15;
            this.searchClient.Text = "Kërko klient ekzistues";
            this.searchClient.UseSelectable = true;
            this.searchClient.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // clearFieldsBtn
            // 
            this.clearFieldsBtn.Location = new System.Drawing.Point(606, 18);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.Size = new System.Drawing.Size(130, 23);
            this.clearFieldsBtn.TabIndex = 17;
            this.clearFieldsBtn.Text = "Pastro fushat";
            this.clearFieldsBtn.UseSelectable = true;
            this.clearFieldsBtn.Click += new System.EventHandler(this.clearFieldsBtn_Click);
            // 
            // ClientRegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearFieldsBtn);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.searchClient);
            this.Name = "ClientRegistrationControl";
            this.Size = new System.Drawing.Size(745, 292);
            this.Load += new System.EventHandler(this.ClientRegistrationControl_Load);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroTextBox card;
        private MetroFramework.Controls.MetroLabel cardLabel;
        private MetroFramework.Controls.MetroTextBox address;
        private MetroFramework.Controls.MetroButton registerClient;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox phone;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel firstNameLabel;
        private MetroFramework.Controls.MetroLabel phoneLabel;
        private MetroFramework.Controls.MetroTextBox lastName;
        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroTextBox firstName;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel birthdateLabel;
        private MetroFramework.Controls.MetroLabel cityLabel;
        private MetroFramework.Controls.MetroButton searchClient;
        private MetroFramework.Controls.MetroComboBox gender;
        private System.Windows.Forms.TextBox city;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroButton clearFieldsBtn;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.CheckBox agree;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
