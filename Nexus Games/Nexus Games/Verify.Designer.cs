namespace Nexus_Games
{
    partial class Verify
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
            this.USERNAMEtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackLabelButton = new System.Windows.Forms.Label();
            this.ExitLabelButton = new System.Windows.Forms.Label();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.CAPTCHA = new System.Windows.Forms.Panel();
            this.UserResult = new System.Windows.Forms.TextBox();
            this.EQUAL_LABEL = new System.Windows.Forms.Label();
            this.VALUE2LABEL = new System.Windows.Forms.Label();
            this.OPERATORLABEL = new System.Windows.Forms.Label();
            this.VALUE1LABEL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserErrorLabel = new System.Windows.Forms.Label();
            this.CAPTCHA.SuspendLayout();
            this.SuspendLayout();
            // 
            // USERNAMEtextBox
            // 
            this.USERNAMEtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.USERNAMEtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USERNAMEtextBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAMEtextBox.ForeColor = System.Drawing.Color.White;
            this.USERNAMEtextBox.Location = new System.Drawing.Point(144, 111);
            this.USERNAMEtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.USERNAMEtextBox.Name = "USERNAMEtextBox";
            this.USERNAMEtextBox.Size = new System.Drawing.Size(316, 37);
            this.USERNAMEtextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(141, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "USERNAME";
            // 
            // BackLabelButton
            // 
            this.BackLabelButton.AutoSize = true;
            this.BackLabelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLabelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLabelButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.BackLabelButton.Location = new System.Drawing.Point(-1, 7);
            this.BackLabelButton.Name = "BackLabelButton";
            this.BackLabelButton.Size = new System.Drawing.Size(59, 16);
            this.BackLabelButton.TabIndex = 70;
            this.BackLabelButton.Text = "<- BACK";
            this.BackLabelButton.Click += new System.EventHandler(this.BackLabelButton_Click);
            // 
            // ExitLabelButton
            // 
            this.ExitLabelButton.AutoSize = true;
            this.ExitLabelButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabelButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabelButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitLabelButton.Location = new System.Drawing.Point(625, 0);
            this.ExitLabelButton.Name = "ExitLabelButton";
            this.ExitLabelButton.Size = new System.Drawing.Size(22, 25);
            this.ExitLabelButton.TabIndex = 69;
            this.ExitLabelButton.Text = "x";
            this.ExitLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabelButton.Click += new System.EventHandler(this.ExitLabelButton_Click);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinimizeLabel.Location = new System.Drawing.Point(596, 0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(20, 25);
            this.MinimizeLabel.TabIndex = 68;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerifyButton.FlatAppearance.BorderSize = 0;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VerifyButton.Image = global::Nexus_Games.Properties.Resources.ButtonColour;
            this.VerifyButton.Location = new System.Drawing.Point(163, 275);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(275, 44);
            this.VerifyButton.TabIndex = 22;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // CAPTCHA
            // 
            this.CAPTCHA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CAPTCHA.Controls.Add(this.UserResult);
            this.CAPTCHA.Controls.Add(this.EQUAL_LABEL);
            this.CAPTCHA.Controls.Add(this.VALUE2LABEL);
            this.CAPTCHA.Controls.Add(this.OPERATORLABEL);
            this.CAPTCHA.Controls.Add(this.VALUE1LABEL);
            this.CAPTCHA.Location = new System.Drawing.Point(202, 180);
            this.CAPTCHA.Name = "CAPTCHA";
            this.CAPTCHA.Size = new System.Drawing.Size(200, 55);
            this.CAPTCHA.TabIndex = 71;
            // 
            // UserResult
            // 
            this.UserResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserResult.Location = new System.Drawing.Point(123, 12);
            this.UserResult.Name = "UserResult";
            this.UserResult.Size = new System.Drawing.Size(61, 29);
            this.UserResult.TabIndex = 4;
            // 
            // EQUAL_LABEL
            // 
            this.EQUAL_LABEL.AutoSize = true;
            this.EQUAL_LABEL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQUAL_LABEL.Location = new System.Drawing.Point(96, 14);
            this.EQUAL_LABEL.Name = "EQUAL_LABEL";
            this.EQUAL_LABEL.Size = new System.Drawing.Size(21, 22);
            this.EQUAL_LABEL.TabIndex = 3;
            this.EQUAL_LABEL.Text = "=";
            // 
            // VALUE2LABEL
            // 
            this.VALUE2LABEL.AutoSize = true;
            this.VALUE2LABEL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VALUE2LABEL.Location = new System.Drawing.Point(69, 14);
            this.VALUE2LABEL.Name = "VALUE2LABEL";
            this.VALUE2LABEL.Size = new System.Drawing.Size(21, 22);
            this.VALUE2LABEL.TabIndex = 2;
            this.VALUE2LABEL.Text = "0";
            // 
            // OPERATORLABEL
            // 
            this.OPERATORLABEL.AutoSize = true;
            this.OPERATORLABEL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPERATORLABEL.Location = new System.Drawing.Point(42, 14);
            this.OPERATORLABEL.Name = "OPERATORLABEL";
            this.OPERATORLABEL.Size = new System.Drawing.Size(21, 22);
            this.OPERATORLABEL.TabIndex = 1;
            this.OPERATORLABEL.Text = "+";
            // 
            // VALUE1LABEL
            // 
            this.VALUE1LABEL.AutoSize = true;
            this.VALUE1LABEL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VALUE1LABEL.Location = new System.Drawing.Point(15, 14);
            this.VALUE1LABEL.Name = "VALUE1LABEL";
            this.VALUE1LABEL.Size = new System.Drawing.Size(21, 22);
            this.VALUE1LABEL.TabIndex = 0;
            this.VALUE1LABEL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(159, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 22);
            this.label2.TabIndex = 72;
            this.label2.Text = "VERIFY YOUR ACCOUNT FIRST";
            // 
            // UserErrorLabel
            // 
            this.UserErrorLabel.AutoSize = true;
            this.UserErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserErrorLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.UserErrorLabel.Location = new System.Drawing.Point(235, 85);
            this.UserErrorLabel.Name = "UserErrorLabel";
            this.UserErrorLabel.Size = new System.Drawing.Size(12, 16);
            this.UserErrorLabel.TabIndex = 73;
            this.UserErrorLabel.Text = "*";
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(647, 412);
            this.Controls.Add(this.UserErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CAPTCHA);
            this.Controls.Add(this.BackLabelButton);
            this.Controls.Add(this.ExitLabelButton);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.USERNAMEtextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify";
            this.Load += new System.EventHandler(this.Verify_Load);
            this.CAPTCHA.ResumeLayout(false);
            this.CAPTCHA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.TextBox USERNAMEtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BackLabelButton;
        private System.Windows.Forms.Label ExitLabelButton;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Panel CAPTCHA;
        private System.Windows.Forms.TextBox UserResult;
        private System.Windows.Forms.Label EQUAL_LABEL;
        private System.Windows.Forms.Label VALUE2LABEL;
        private System.Windows.Forms.Label OPERATORLABEL;
        private System.Windows.Forms.Label VALUE1LABEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserErrorLabel;
    }
}