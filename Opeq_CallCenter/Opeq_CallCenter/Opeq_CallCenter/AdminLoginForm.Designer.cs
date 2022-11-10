namespace Opeq_CallCenter
{
    partial class AdminLoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.adminNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLoginLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.adminPassTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(381, 413);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(134, 42);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Se Connecter";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // adminNameTextBox
            // 
            this.adminNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.adminNameTextBox.Location = new System.Drawing.Point(280, 269);
            this.adminNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adminNameTextBox.Multiline = true;
            this.adminNameTextBox.Name = "adminNameTextBox";
            this.adminNameTextBox.Size = new System.Drawing.Size(333, 31);
            this.adminNameTextBox.TabIndex = 6;
            this.adminNameTextBox.Text = "Nom";
            // 
            // employeeLoginLabel
            // 
            this.employeeLoginLabel.AutoSize = true;
            this.employeeLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLoginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeLoginLabel.Location = new System.Drawing.Point(28, 556);
            this.employeeLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLoginLabel.Name = "employeeLoginLabel";
            this.employeeLoginLabel.Size = new System.Drawing.Size(110, 17);
            this.employeeLoginLabel.TabIndex = 5;
            this.employeeLoginLabel.Text = "Pas une admin?";
            this.employeeLoginLabel.Click += new System.EventHandler(this.employeeLoginLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(358, 152);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(177, 76);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // adminPassTextBox
            // 
            this.adminPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.adminPassTextBox.Location = new System.Drawing.Point(280, 334);
            this.adminPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adminPassTextBox.Multiline = true;
            this.adminPassTextBox.Name = "adminPassTextBox";
            this.adminPassTextBox.Size = new System.Drawing.Size(333, 31);
            this.adminPassTextBox.TabIndex = 8;
            this.adminPassTextBox.Text = "Mot de Passe";
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 609);
            this.Controls.Add(this.adminPassTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminNameTextBox);
            this.Controls.Add(this.employeeLoginLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox adminNameTextBox;
        private System.Windows.Forms.Label employeeLoginLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox adminPassTextBox;
    }
}