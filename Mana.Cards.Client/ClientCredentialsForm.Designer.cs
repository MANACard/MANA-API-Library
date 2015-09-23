using System.Drawing;

namespace Mana.Cards.Client
{
    partial class ClientCredentialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientCredentialsForm));
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelSale = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(153, 79);
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
            this.metroLabel2.Location = new System.Drawing.Point(23, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nr. tel. i klientit *:";
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(187, 124);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(113, 23);
            this.btnCancelSale.TabIndex = 1;
            this.btnCancelSale.Text = "Anulo shitjen";
            this.btnCancelSale.UseSelectable = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // ClientCredentialsForm
            // 
            this.AcceptButton = this.btnCancelSale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 182);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientCredentialsForm";
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
     
        private MetroFramework.Controls.MetroButton btnCancelSale;
    }
}