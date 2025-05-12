namespace Nexus_Games
{
    partial class Admin_DeleteRequestTable
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackLabelButton
            // 
            this.BackLabelButton.AutoSize = true;
            this.BackLabelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLabelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLabelButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.BackLabelButton.Location = new System.Drawing.Point(3, 7);
            this.BackLabelButton.Name = "BackLabelButton";
            this.BackLabelButton.Size = new System.Drawing.Size(59, 16);
            this.BackLabelButton.TabIndex = 74;
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
            this.MinimizeLabel.Location = new System.Drawing.Point(1283, 0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(20, 25);
            this.MinimizeLabel.TabIndex = 73;
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
            this.ExitLabelButton.Location = new System.Drawing.Point(1309, 0);
            this.ExitLabelButton.Name = "ExitLabelButton";
            this.ExitLabelButton.Size = new System.Drawing.Size(22, 25);
            this.ExitLabelButton.TabIndex = 72;
            this.ExitLabelButton.Text = "x";
            this.ExitLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabelButton.Click += new System.EventHandler(this.ExitLabelButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Location = new System.Drawing.Point(116, 112);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1091, 482);
            this.dataGridView.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(501, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 75;
            this.label1.Text = "Delete Request Table";
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ClearButton.Image = global::Nexus_Games.Properties.Resources.ButtonColour;
            this.ClearButton.Location = new System.Drawing.Point(539, 614);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(184, 44);
            this.ClearButton.TabIndex = 77;
            this.ClearButton.Text = "Go User List";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Admin_DeleteRequestTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1333, 679);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackLabelButton);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.ExitLabelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_DeleteRequestTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_DeleteRequestTable";
            this.Load += new System.EventHandler(this.Admin_DeleteRequestTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackLabelButton;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabelButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
    }
}