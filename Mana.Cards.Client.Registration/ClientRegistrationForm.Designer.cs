namespace Mana.Cards.Client.Registration
{
    partial class ClientRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegistrationForm));
            this.clientRegistrationControl1 = new Mana.Cards.Client.ClientRegistrationControl();
            this.lblPartnerName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // clientRegistrationControl1
            // 
            this.clientRegistrationControl1.Location = new System.Drawing.Point(24, 64);
            this.clientRegistrationControl1.Name = "clientRegistrationControl1";
            this.clientRegistrationControl1.Size = new System.Drawing.Size(751, 281);
            this.clientRegistrationControl1.TabIndex = 0;
            this.clientRegistrationControl1.UseSelectable = true;
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Location = new System.Drawing.Point(34, 351);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(96, 19);
            this.lblPartnerName.TabIndex = 10;
            this.lblPartnerName.Text = "MANA Partner";
            // 
            // ClientRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 384);
            this.Controls.Add(this.lblPartnerName);
            this.Controls.Add(this.clientRegistrationControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientRegistrationForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Regjistrimi i klientëve";
            this.Load += new System.EventHandler(this.ClientRegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientRegistrationControl clientRegistrationControl1;
        private MetroFramework.Controls.MetroLabel lblPartnerName;
    }
}

