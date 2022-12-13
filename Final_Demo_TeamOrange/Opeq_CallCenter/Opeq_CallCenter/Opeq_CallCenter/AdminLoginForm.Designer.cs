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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.adminNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLoginLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.adminPassTextBox = new System.Windows.Forms.TextBox();
            this.languagechanger = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // adminNameTextBox
            // 
            resources.ApplyResources(this.adminNameTextBox, "adminNameTextBox");
            this.adminNameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.adminNameTextBox.Name = "adminNameTextBox";
            this.adminNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adminNameTextBox_MouseClick);
            this.adminNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminNameTextBox_KeyPress);
            // 
            // employeeLoginLabel
            // 
            resources.ApplyResources(this.employeeLoginLabel, "employeeLoginLabel");
            this.employeeLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employeeLoginLabel.Name = "employeeLoginLabel";
            this.employeeLoginLabel.Click += new System.EventHandler(this.employeeLoginLabel_Click);
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Name = "loginLabel";
            // 
            // adminPassTextBox
            // 
            resources.ApplyResources(this.adminPassTextBox, "adminPassTextBox");
            this.adminPassTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.adminPassTextBox.Name = "adminPassTextBox";
            this.adminPassTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adminPassTextBox_MouseClick);
            this.adminPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminPassTextBox_KeyPress);
            // 
            // languagechanger
            // 
            resources.ApplyResources(this.languagechanger, "languagechanger");
            this.languagechanger.FormattingEnabled = true;
            this.languagechanger.Items.AddRange(new object[] {
            resources.GetString("languagechanger.Items"),
            resources.GetString("languagechanger.Items1")});
            this.languagechanger.Name = "languagechanger";
            this.languagechanger.SelectedIndexChanged += new System.EventHandler(this.languagechanger_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // AdminLoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.languagechanger);
            this.Controls.Add(this.adminPassTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminNameTextBox);
            this.Controls.Add(this.employeeLoginLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "AdminLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox adminNameTextBox;
        private System.Windows.Forms.Label employeeLoginLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox adminPassTextBox;
        private System.Windows.Forms.ComboBox languagechanger;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}