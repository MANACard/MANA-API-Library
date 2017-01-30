using Mana.Cards.Client.CustomControls;
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
            this.txtPhone = new Mana.Cards.Client.CustomControls.RoundedTextBox();
            this.roundedPanel1 = new Mana.Cards.Client.CustomControls.RoundedPanel();
            this.roundedPanel2 = new Mana.Cards.Client.CustomControls.RoundedPanel();
            this.roundedPanel11 = new Mana.Cards.Client.CustomControls.RoundedPanel();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.roundedPanel3 = new Mana.Cards.Client.CustomControls.RoundedPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel11.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(3, 3);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(147, 23);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.roundedPanel1.Image = null;
            this.roundedPanel1.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel1.Location = new System.Drawing.Point(2, 21);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RoundCornerRadius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(380, 180);
            this.roundedPanel1.TabIndex = 14;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Controls.Add(this.roundedPanel11);
            this.roundedPanel2.Controls.Add(this.roundedPanel3);
            this.roundedPanel2.Controls.Add(this.metroLabel3);
            this.roundedPanel2.Controls.Add(this.metroLabel2);
            this.roundedPanel2.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel2.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel2.Image = null;
            this.roundedPanel2.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel2.Location = new System.Drawing.Point(21, 17);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RoundCornerRadius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(334, 142);
            this.roundedPanel2.TabIndex = 13;
            // 
            // roundedPanel11
            // 
            this.roundedPanel11.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.BorderWidth = 2;
            this.roundedPanel11.Controls.Add(this.btnCancelSale);
            this.roundedPanel11.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.roundedPanel11.Image = null;
            this.roundedPanel11.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel11.Location = new System.Drawing.Point(201, 97);
            this.roundedPanel11.Name = "roundedPanel11";
            this.roundedPanel11.RoundCornerRadius = 15;
            this.roundedPanel11.Size = new System.Drawing.Size(105, 34);
            this.roundedPanel11.TabIndex = 38;
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.btnCancelSale.FlatAppearance.BorderSize = 0;
            this.btnCancelSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.btnCancelSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Location = new System.Drawing.Point(3, 3);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(94, 23);
            this.btnCancelSale.TabIndex = 0;
            this.btnCancelSale.Text = "Anulo shitjen";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.BorderColor = System.Drawing.Color.Gray;
            this.roundedPanel3.BorderWidth = 2;
            this.roundedPanel3.Controls.Add(this.txtPhone);
            this.roundedPanel3.GradientEndColor = System.Drawing.Color.White;
            this.roundedPanel3.GradientStartColor = System.Drawing.Color.White;
            this.roundedPanel3.Image = null;
            this.roundedPanel3.ImageLocation = new System.Drawing.Point(4, 4);
            this.roundedPanel3.Location = new System.Drawing.Point(147, 40);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.RoundCornerRadius = 15;
            this.roundedPanel3.Size = new System.Drawing.Size(159, 34);
            this.roundedPanel3.TabIndex = 37;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(31)))), ((int)(((byte)(67)))));
            this.metroLabel3.Location = new System.Drawing.Point(13, 2);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(267, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Shtypni të dhënat e mëposhtme";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.metroLabel2.Location = new System.Drawing.Point(13, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Nr. tel. i klientit *:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // ClientCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 197);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientCredentialsForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Shtypni të dhënat e mëposhtme";
            this.Load += new System.EventHandler(this.ClientCredentialsForm_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel11.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedTextBox txtPhone;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomControls.RoundedPanel roundedPanel11;
        private System.Windows.Forms.Button btnCancelSale;
        private CustomControls.RoundedPanel roundedPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}