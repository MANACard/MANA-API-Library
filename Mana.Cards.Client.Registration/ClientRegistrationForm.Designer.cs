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
            this.SuspendLayout();
            // 
            // clientRegistrationControl1
            // 
            this.clientRegistrationControl1.Location = new System.Drawing.Point(24, 64);
            this.clientRegistrationControl1.Name = "clientRegistrationControl1";
            this.clientRegistrationControl1.Size = new System.Drawing.Size(751, 344);
            this.clientRegistrationControl1.TabIndex = 0;
            this.clientRegistrationControl1.UseSelectable = true;
            // 
            // ClientRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 431);
            this.Controls.Add(this.clientRegistrationControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientRegistrationForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Regjistrimi i klientëve";
            this.Load += new System.EventHandler(this.ClientRegistrationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClientRegistrationControl clientRegistrationControl1;
    }
}

