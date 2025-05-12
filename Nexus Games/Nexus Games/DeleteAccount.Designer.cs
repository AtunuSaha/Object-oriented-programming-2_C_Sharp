namespace Nexus_Games
{
    partial class DeleteAccount
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
            this.BackLabelButton = new System.Windows.Forms.Label();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitLabelButton = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PASSWORDTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackLabelButton
            // 
            this.BackLabelButton.AutoSize = true;
            this.BackLabelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLabelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLabelButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.BackLabelButton.Location = new System.Drawing.Point(3, 9);
            this.BackLabelButton.Name = "BackLabelButton";
            this.BackLabelButton.Size = new System.Drawing.Size(59, 16);
            this.BackLabelButton.TabIndex = 71;
            this.BackLabelButton.Text = "<- BACK";
            this.BackLabelButton.Click += new System.EventHandler(this.BackLabelButton_Click);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinimizeLabel.Location = new System.Drawing.Point(626, 0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(20, 25);
            this.MinimizeLabel.TabIndex = 70;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // ExitLabelButton
            // 
            this.ExitLabelButton.AutoSize = true;
            this.ExitLabelButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabelButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabelButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitLabelButton.Location = new System.Drawing.Point(652, 0);
            this.ExitLabelButton.Name = "ExitLabelButton";
            this.ExitLabelButton.Size = new System.Drawing.Size(22, 25);
            this.ExitLabelButton.TabIndex = 69;
            this.ExitLabelButton.Text = "x";
            this.ExitLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabelButton.Click += new System.EventHandler(this.ExitLabelButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(112, 207);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(438, 41);
            this.PasswordTextBox.TabIndex = 73;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PASSWORDTextLabel
            // 
            this.PASSWORDTextLabel.AutoSize = true;
            this.PASSWORDTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.PASSWORDTextLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORDTextLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.PASSWORDTextLabel.Location = new System.Drawing.Point(109, 172);
            this.PASSWORDTextLabel.Name = "PASSWORDTextLabel";
            this.PASSWORDTextLabel.Size = new System.Drawing.Size(134, 16);
            this.PASSWORDTextLabel.TabIndex = 72;
            this.PASSWORDTextLabel.Text = "VERIFY PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(122, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "ARE YOU SURE YOU WANT TO DELETE YOUR ACCOUNT?";
            // 
            // LoginButton
            // 
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Image = global::Nexus_Games.Properties.Resources.ButtonColour;
            this.LoginButton.Location = new System.Drawing.Point(337, 273);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(213, 44);
            this.LoginButton.TabIndex = 75;
            this.LoginButton.Text = "Delete Request";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(679, 411);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PASSWORDTextLabel);
            this.Controls.Add(this.BackLabelButton);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.ExitLabelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackLabelButton;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabelButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PASSWORDTextLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
    }
}