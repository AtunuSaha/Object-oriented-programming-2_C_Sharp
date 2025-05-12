namespace Nexus_Games
{
    partial class NAGAD
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
            this.PASSWORDTextLabel = new System.Windows.Forms.Label();
            this.NagadTextLabel = new System.Windows.Forms.Label();
            this.NagadPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PASSWORDTextLabel
            // 
            this.PASSWORDTextLabel.AutoSize = true;
            this.PASSWORDTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.PASSWORDTextLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORDTextLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.PASSWORDTextLabel.Location = new System.Drawing.Point(89, 103);
            this.PASSWORDTextLabel.Name = "PASSWORDTextLabel";
            this.PASSWORDTextLabel.Size = new System.Drawing.Size(204, 16);
            this.PASSWORDTextLabel.TabIndex = 23;
            this.PASSWORDTextLabel.Text = "Exp: 01843961879 / max 11 digits";
            // 
            // NagadTextLabel
            // 
            this.NagadTextLabel.AutoSize = true;
            this.NagadTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.NagadTextLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NagadTextLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.NagadTextLabel.Location = new System.Drawing.Point(80, 40);
            this.NagadTextLabel.Name = "NagadTextLabel";
            this.NagadTextLabel.Size = new System.Drawing.Size(113, 16);
            this.NagadTextLabel.TabIndex = 22;
            this.NagadTextLabel.Text = "NAGAD NUMBER";
            // 
            // NagadPhoneNumberTextBox
            // 
            this.NagadPhoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.NagadPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NagadPhoneNumberTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NagadPhoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.NagadPhoneNumberTextBox.Location = new System.Drawing.Point(83, 59);
            this.NagadPhoneNumberTextBox.Name = "NagadPhoneNumberTextBox";
            this.NagadPhoneNumberTextBox.Size = new System.Drawing.Size(288, 41);
            this.NagadPhoneNumberTextBox.TabIndex = 20;
            this.NagadPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NagadPhoneNumberTextBox_KeyPress);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PurchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseButton.FlatAppearance.BorderSize = 0;
            this.PurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PurchaseButton.Image = global::Nexus_Games.Properties.Resources.ButtonColour;
            this.PurchaseButton.Location = new System.Drawing.Point(264, 146);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(107, 42);
            this.PurchaseButton.TabIndex = 21;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // NAGAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(454, 229);
            this.Controls.Add(this.PASSWORDTextLabel);
            this.Controls.Add(this.NagadTextLabel);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.NagadPhoneNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NAGAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAGAD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PASSWORDTextLabel;
        private System.Windows.Forms.Label NagadTextLabel;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.TextBox NagadPhoneNumberTextBox;
    }
}