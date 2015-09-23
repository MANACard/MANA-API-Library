namespace Mana.Cards.Client
{
    partial class CardResolverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardResolverForm));
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnFindCard = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(153, 69);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(147, 23);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Nr. tel. i klientit *:";
            // 
            // btnFindCard
            // 
            this.btnFindCard.Location = new System.Drawing.Point(197, 153);
            this.btnFindCard.Name = "btnFindCard";
            this.btnFindCard.Size = new System.Drawing.Size(103, 23);
            this.btnFindCard.TabIndex = 2;
            this.btnFindCard.Text = "Gjej kartelën";
            this.btnFindCard.UseSelectable = true;
            this.btnFindCard.Click += new System.EventHandler(this.btnFindCard_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Ditëlindja *:";
            // 
            // birth_date
            // 
            this.birth_date.CustomFormat = "dd/MM/yyyy";
            this.birth_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_date.Location = new System.Drawing.Point(153, 109);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(147, 20);
            this.birth_date.TabIndex = 1;
            // 
            // CardResolverForm
            // 
            this.AcceptButton = this.btnFindCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 195);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnFindCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CardResolverForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Shtypni të dhënat e mëposhtme";
            this.Load += new System.EventHandler(this.ClientCredentialsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnFindCard;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker birth_date;
    }
}