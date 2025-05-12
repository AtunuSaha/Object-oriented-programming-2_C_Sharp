namespace Nexus_Games
{
    partial class PaymentType
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
            this.PurchaseFormPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OPTION_BKASH = new System.Windows.Forms.RadioButton();
            this.OPTION_NAGAD = new System.Windows.Forms.RadioButton();
            this.OPTION_CREDITCARD = new System.Windows.Forms.RadioButton();
            this.OPTION_DEBITCARD = new System.Windows.Forms.RadioButton();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitLabelButton = new System.Windows.Forms.Label();
            this.BackLabelButton = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PurchaseFormPanel
            // 
            this.PurchaseFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchaseFormPanel.Location = new System.Drawing.Point(164, 157);
            this.PurchaseFormPanel.Name = "PurchaseFormPanel";
            this.PurchaseFormPanel.Size = new System.Drawing.Size(454, 229);
            this.PurchaseFormPanel.TabIndex = 71;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OPTION_BKASH);
            this.groupBox2.Controls.Add(this.OPTION_NAGAD);
            this.groupBox2.Controls.Add(this.OPTION_CREDITCARD);
            this.groupBox2.Controls.Add(this.OPTION_DEBITCARD);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Location = new System.Drawing.Point(164, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 58);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHOOSE PAYMENT TYPE";
            // 
            // OPTION_BKASH
            // 
            this.OPTION_BKASH.AutoSize = true;
            this.OPTION_BKASH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTION_BKASH.ForeColor = System.Drawing.Color.SkyBlue;
            this.OPTION_BKASH.Location = new System.Drawing.Point(23, 20);
            this.OPTION_BKASH.Name = "OPTION_BKASH";
            this.OPTION_BKASH.Size = new System.Drawing.Size(65, 19);
            this.OPTION_BKASH.TabIndex = 8;
            this.OPTION_BKASH.Text = "BKASH";
            this.OPTION_BKASH.UseVisualStyleBackColor = true;
            this.OPTION_BKASH.CheckedChanged += new System.EventHandler(this.OPTION_BKASH_CheckedChanged);
            // 
            // OPTION_NAGAD
            // 
            this.OPTION_NAGAD.AutoSize = true;
            this.OPTION_NAGAD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTION_NAGAD.ForeColor = System.Drawing.Color.SkyBlue;
            this.OPTION_NAGAD.Location = new System.Drawing.Point(117, 19);
            this.OPTION_NAGAD.Name = "OPTION_NAGAD";
            this.OPTION_NAGAD.Size = new System.Drawing.Size(66, 19);
            this.OPTION_NAGAD.TabIndex = 9;
            this.OPTION_NAGAD.Text = "NAGAD";
            this.OPTION_NAGAD.UseVisualStyleBackColor = true;
            this.OPTION_NAGAD.CheckedChanged += new System.EventHandler(this.OPTION_NAGAD_CheckedChanged);
            // 
            // OPTION_CREDITCARD
            // 
            this.OPTION_CREDITCARD.AutoSize = true;
            this.OPTION_CREDITCARD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTION_CREDITCARD.ForeColor = System.Drawing.Color.SkyBlue;
            this.OPTION_CREDITCARD.Location = new System.Drawing.Point(213, 20);
            this.OPTION_CREDITCARD.Name = "OPTION_CREDITCARD";
            this.OPTION_CREDITCARD.Size = new System.Drawing.Size(107, 19);
            this.OPTION_CREDITCARD.TabIndex = 10;
            this.OPTION_CREDITCARD.Text = "CREDIT CARD";
            this.OPTION_CREDITCARD.UseVisualStyleBackColor = true;
            this.OPTION_CREDITCARD.CheckedChanged += new System.EventHandler(this.OPTION_CREDITCARD_CheckedChanged);
            // 
            // OPTION_DEBITCARD
            // 
            this.OPTION_DEBITCARD.AutoSize = true;
            this.OPTION_DEBITCARD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTION_DEBITCARD.ForeColor = System.Drawing.Color.SkyBlue;
            this.OPTION_DEBITCARD.Location = new System.Drawing.Point(335, 20);
            this.OPTION_DEBITCARD.Name = "OPTION_DEBITCARD";
            this.OPTION_DEBITCARD.Size = new System.Drawing.Size(97, 19);
            this.OPTION_DEBITCARD.TabIndex = 11;
            this.OPTION_DEBITCARD.Text = "DEBIT CARD";
            this.OPTION_DEBITCARD.UseVisualStyleBackColor = true;
            this.OPTION_DEBITCARD.CheckedChanged += new System.EventHandler(this.OPTION_DEBITCARD_CheckedChanged);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinimizeLabel.Location = new System.Drawing.Point(747, 2);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(20, 25);
            this.MinimizeLabel.TabIndex = 75;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitLabelButton
            // 
            this.ExitLabelButton.AutoSize = true;
            this.ExitLabelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabelButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabelButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitLabelButton.Location = new System.Drawing.Point(775, 2);
            this.ExitLabelButton.Name = "ExitLabelButton";
            this.ExitLabelButton.Size = new System.Drawing.Size(22, 25);
            this.ExitLabelButton.TabIndex = 74;
            this.ExitLabelButton.Text = "x";
            this.ExitLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabelButton.Click += new System.EventHandler(this.ExitLabelButton_Click);
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
            this.BackLabelButton.TabIndex = 73;
            this.BackLabelButton.Text = "<- BACK";
            this.BackLabelButton.Click += new System.EventHandler(this.BackLabelButton_Click);
            // 
            // PaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.ExitLabelButton);
            this.Controls.Add(this.BackLabelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PurchaseFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PurchaseFormPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton OPTION_BKASH;
        private System.Windows.Forms.RadioButton OPTION_NAGAD;
        private System.Windows.Forms.RadioButton OPTION_CREDITCARD;
        private System.Windows.Forms.RadioButton OPTION_DEBITCARD;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabelButton;
        private System.Windows.Forms.Label BackLabelButton;
    }
}