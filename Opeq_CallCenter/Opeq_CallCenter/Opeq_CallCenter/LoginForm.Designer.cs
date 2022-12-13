namespace Opeq_CallCenter
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.adminLoginLabel = new System.Windows.Forms.Label();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languagechanger = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.Name = "loginLabel";
            // 
            // adminLoginLabel
            // 
            resources.ApplyResources(this.adminLoginLabel, "adminLoginLabel");
            this.adminLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.adminLoginLabel.Name = "adminLoginLabel";
            this.adminLoginLabel.Click += new System.EventHandler(this.adminLoginLabel_Click);
            // 
            // empNameTextBox
            // 
            resources.ApplyResources(this.empNameTextBox, "empNameTextBox");
            this.empNameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.empNameTextBox_MouseClick);
            this.empNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empNameTextBox_KeyPress);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // languagechanger
            // 
            this.languagechanger.FormattingEnabled = true;
            this.languagechanger.Items.AddRange(new object[] {
            resources.GetString("languagechanger.Items"),
            resources.GetString("languagechanger.Items1")});
            resources.ApplyResources(this.languagechanger, "languagechanger");
            this.languagechanger.Name = "languagechanger";
            this.languagechanger.SelectedIndexChanged += new System.EventHandler(this.languagechanger_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languagechanger);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(this.adminLoginLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label adminLoginLabel;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox languagechanger;
    }
}

