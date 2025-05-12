namespace Nexus_Games
{
    partial class Admin_HomePage
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
            this.Logout_Button = new System.Windows.Forms.Button();
            this.Delete_Request = new System.Windows.Forms.Button();
            this.UserListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinimizeLabel.Location = new System.Drawing.Point(617, -3);
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
            this.ExitLabelButton.Location = new System.Drawing.Point(643, -3);
            this.ExitLabelButton.Name = "ExitLabelButton";
            this.ExitLabelButton.Size = new System.Drawing.Size(22, 25);
            this.ExitLabelButton.TabIndex = 72;
            this.ExitLabelButton.Text = "x";
            this.ExitLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabelButton.Click += new System.EventHandler(this.ExitLabelButton_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_Button.FlatAppearance.BorderSize = 0;
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Button.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logout_Button.Image = global::Nexus_Games.Properties.Resources.ButtonColour;
            this.Logout_Button.Location = new System.Drawing.Point(169, 295);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(281, 74);
            this.Logout_Button.TabIndex = 77;
            this.Logout_Button.Text = "LOGOUT";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            this.Logout_Button.MouseLeave += new System.EventHandler(this.Logout_Button_MouseLeave);
            this.Logout_Button.MouseHover += new System.EventHandler(this.Logout_Button_MouseHover);
            // 
            // Delete_Request
            // 
            this.Delete_Request.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_Request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Request.FlatAppearance.BorderSize = 0;
            this.Delete_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Request.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Request.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Delete_Request.Image = global::Nexus_Games.Properties.Resources.ButtonColour;
            this.Delete_Request.Location = new System.Drawing.Point(169, 190);
            this.Delete_Request.Name = "Delete_Request";
            this.Delete_Request.Size = new System.Drawing.Size(281, 74);
            this.Delete_Request.TabIndex = 76;
            this.Delete_Request.Text = "USER REQUEST";
            this.Delete_Request.UseVisualStyleBackColor = true;
            this.Delete_Request.Click += new System.EventHandler(this.Delete_Request_Click);
            this.Delete_Request.MouseLeave += new System.EventHandler(this.Delete_Request_MouseLeave);
            this.Delete_Request.MouseHover += new System.EventHandler(this.Delete_Request_MouseHover);
            // 
            // UserListButton
            // 
            this.UserListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserListButton.FlatAppearance.BorderSize = 0;
            this.UserListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserListButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UserListButton.Image = global::Nexus_Games.Properties.Resources.ButtonColour;
            this.UserListButton.Location = new System.Drawing.Point(169, 84);
            this.UserListButton.Name = "UserListButton";
            this.UserListButton.Size = new System.Drawing.Size(281, 74);
            this.UserListButton.TabIndex = 75;
            this.UserListButton.Text = "USER ACCOUNTS";
            this.UserListButton.UseVisualStyleBackColor = true;
            this.UserListButton.Click += new System.EventHandler(this.UserListButton_Click);
            this.UserListButton.MouseLeave += new System.EventHandler(this.UserListButton_MouseLeave);
            this.UserListButton.MouseHover += new System.EventHandler(this.UserListButton_MouseHover);
            // 
            // Admin_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(663, 451);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.Delete_Request);
            this.Controls.Add(this.UserListButton);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.ExitLabelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabelButton;
        private System.Windows.Forms.Button Delete_Request;
        private System.Windows.Forms.Button UserListButton;
        private System.Windows.Forms.Button Logout_Button;
    }
}