namespace Nexus_Games
{
    partial class Help
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
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitLabelButton = new System.Windows.Forms.Label();
            this.BackLabelButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswersTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinimizeLabel.Location = new System.Drawing.Point(747, 0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(20, 25);
            this.MinimizeLabel.TabIndex = 22;
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
            this.ExitLabelButton.Location = new System.Drawing.Point(775, 0);
            this.ExitLabelButton.Name = "ExitLabelButton";
            this.ExitLabelButton.Size = new System.Drawing.Size(22, 25);
            this.ExitLabelButton.TabIndex = 21;
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
            this.BackLabelButton.Location = new System.Drawing.Point(2, 7);
            this.BackLabelButton.Name = "BackLabelButton";
            this.BackLabelButton.Size = new System.Drawing.Size(59, 16);
            this.BackLabelButton.TabIndex = 67;
            this.BackLabelButton.Text = "<- BACK";
            this.BackLabelButton.Click += new System.EventHandler(this.BackLabelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(313, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 74;
            this.label1.Text = "Select Question";
            // 
            // AnswersTextBox
            // 
            this.AnswersTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.AnswersTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswersTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.AnswersTextBox.Location = new System.Drawing.Point(84, 194);
            this.AnswersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnswersTextBox.Multiline = true;
            this.AnswersTextBox.Name = "AnswersTextBox";
            this.AnswersTextBox.ReadOnly = true;
            this.AnswersTextBox.Size = new System.Drawing.Size(615, 206);
            this.AnswersTextBox.TabIndex = 73;
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.comboBoxQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuestions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuestions.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Items.AddRange(new object[] {
            "Select Question?",
            "I can\'t log into my account.",
            "I forgot my password.",
            "I can\'t complete a purchase.",
            "How long will it takes to delete my Account?"});
            this.comboBoxQuestions.Location = new System.Drawing.Point(84, 139);
            this.comboBoxQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(615, 26);
            this.comboBoxQuestions.TabIndex = 72;
            this.comboBoxQuestions.Text = "Select Question?";
            this.comboBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestions_SelectedIndexChanged);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswersTextBox);
            this.Controls.Add(this.comboBoxQuestions);
            this.Controls.Add(this.BackLabelButton);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.ExitLabelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabelButton;
        private System.Windows.Forms.Label BackLabelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnswersTextBox;
        private System.Windows.Forms.ComboBox comboBoxQuestions;
    }
}