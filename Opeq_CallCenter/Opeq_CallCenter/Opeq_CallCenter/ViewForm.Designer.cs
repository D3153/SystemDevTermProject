namespace Opeq_CallCenter
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.searchbar = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.filter = new System.Windows.Forms.GroupBox();
            this.unresolvedRadioBtn = new System.Windows.Forms.RadioButton();
            this.ongoingRadioBtn = new System.Windows.Forms.RadioButton();
            this.resolveRadioBtn = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.navigation = new System.Windows.Forms.GroupBox();
            this.adminRadioBtn = new System.Windows.Forms.RadioButton();
            this.viewRadioBtn = new System.Windows.Forms.RadioButton();
            this.modifyRadioBtn = new System.Windows.Forms.RadioButton();
            this.addRadioBtn = new System.Windows.Forms.RadioButton();
            this.empNameTextView = new System.Windows.Forms.Label();
            this.MATsearchBar = new System.Windows.Forms.TextBox();
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderNumRichTextBox = new System.Windows.Forms.RichTextBox();
            this.filter.SuspendLayout();
            this.navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbar
            // 
            resources.ApplyResources(this.searchbar, "searchbar");
            this.searchbar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchbar.Name = "searchbar";
            this.searchbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchbar_MouseClick);
            this.searchbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbar_KeyPress);
            // 
            // searchBtn
            // 
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // viewBtn
            // 
            resources.ApplyResources(this.viewBtn, "viewBtn");
            this.viewBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // resultBox
            // 
            resources.ApplyResources(this.resultBox, "resultBox");
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Name = "resultBox";
            // 
            // filter
            // 
            resources.ApplyResources(this.filter, "filter");
            this.filter.Controls.Add(this.unresolvedRadioBtn);
            this.filter.Controls.Add(this.ongoingRadioBtn);
            this.filter.Controls.Add(this.resolveRadioBtn);
            this.filter.Name = "filter";
            this.filter.TabStop = false;
            // 
            // unresolvedRadioBtn
            // 
            resources.ApplyResources(this.unresolvedRadioBtn, "unresolvedRadioBtn");
            this.unresolvedRadioBtn.Name = "unresolvedRadioBtn";
            this.unresolvedRadioBtn.TabStop = true;
            this.unresolvedRadioBtn.UseVisualStyleBackColor = true;
            this.unresolvedRadioBtn.Click += new System.EventHandler(this.unresolvedRadioBtn_Click);
            // 
            // ongoingRadioBtn
            // 
            resources.ApplyResources(this.ongoingRadioBtn, "ongoingRadioBtn");
            this.ongoingRadioBtn.Name = "ongoingRadioBtn";
            this.ongoingRadioBtn.TabStop = true;
            this.ongoingRadioBtn.UseVisualStyleBackColor = true;
            this.ongoingRadioBtn.Click += new System.EventHandler(this.ongoingRadioBtn_Click);
            // 
            // resolveRadioBtn
            // 
            resources.ApplyResources(this.resolveRadioBtn, "resolveRadioBtn");
            this.resolveRadioBtn.Name = "resolveRadioBtn";
            this.resolveRadioBtn.TabStop = true;
            this.resolveRadioBtn.UseVisualStyleBackColor = true;
            this.resolveRadioBtn.Click += new System.EventHandler(this.resolveRadioBtn_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Name = "label11";
            // 
            // navigation
            // 
            resources.ApplyResources(this.navigation, "navigation");
            this.navigation.Controls.Add(this.adminRadioBtn);
            this.navigation.Controls.Add(this.viewRadioBtn);
            this.navigation.Controls.Add(this.modifyRadioBtn);
            this.navigation.Controls.Add(this.addRadioBtn);
            this.navigation.Name = "navigation";
            this.navigation.TabStop = false;
            // 
            // adminRadioBtn
            // 
            resources.ApplyResources(this.adminRadioBtn, "adminRadioBtn");
            this.adminRadioBtn.Name = "adminRadioBtn";
            this.adminRadioBtn.UseVisualStyleBackColor = true;
            this.adminRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adminRadioBtn_MouseClick);
            // 
            // viewRadioBtn
            // 
            resources.ApplyResources(this.viewRadioBtn, "viewRadioBtn");
            this.viewRadioBtn.Checked = true;
            this.viewRadioBtn.Name = "viewRadioBtn";
            this.viewRadioBtn.TabStop = true;
            this.viewRadioBtn.UseVisualStyleBackColor = true;
            // 
            // modifyRadioBtn
            // 
            resources.ApplyResources(this.modifyRadioBtn, "modifyRadioBtn");
            this.modifyRadioBtn.Name = "modifyRadioBtn";
            this.modifyRadioBtn.UseVisualStyleBackColor = true;
            this.modifyRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modifyRadioBtn_MouseClick);
            // 
            // addRadioBtn
            // 
            resources.ApplyResources(this.addRadioBtn, "addRadioBtn");
            this.addRadioBtn.Name = "addRadioBtn";
            this.addRadioBtn.UseVisualStyleBackColor = true;
            this.addRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addButton_MouseClick);
            // 
            // empNameTextView
            // 
            resources.ApplyResources(this.empNameTextView, "empNameTextView");
            this.empNameTextView.Name = "empNameTextView";
            // 
            // MATsearchBar
            // 
            resources.ApplyResources(this.MATsearchBar, "MATsearchBar");
            this.MATsearchBar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MATsearchBar.Name = "MATsearchBar";
            this.MATsearchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MATsearchBar_MouseClick);
            this.MATsearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MATsearchBar_KeyPress);
            // 
            // nameRichTextBox
            // 
            resources.ApplyResources(this.nameRichTextBox, "nameRichTextBox");
            this.nameRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameRichTextBox.Name = "nameRichTextBox";
            // 
            // orderNumRichTextBox
            // 
            resources.ApplyResources(this.orderNumRichTextBox, "orderNumRichTextBox");
            this.orderNumRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderNumRichTextBox.Name = "orderNumRichTextBox";
            // 
            // ViewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.orderNumRichTextBox);
            this.Controls.Add(this.nameRichTextBox);
            this.Controls.Add(this.MATsearchBar);
            this.Controls.Add(this.empNameTextView);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchbar);
            this.Name = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.GroupBox filter;
        private System.Windows.Forms.RadioButton unresolvedRadioBtn;
        private System.Windows.Forms.RadioButton ongoingRadioBtn;
        private System.Windows.Forms.RadioButton resolveRadioBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox navigation;
        private System.Windows.Forms.RadioButton viewRadioBtn;
        private System.Windows.Forms.RadioButton modifyRadioBtn;
        private System.Windows.Forms.RadioButton addRadioBtn;
        private System.Windows.Forms.Label empNameTextView;
        private System.Windows.Forms.RadioButton adminRadioBtn;
        private System.Windows.Forms.TextBox MATsearchBar;
        private System.Windows.Forms.RichTextBox nameRichTextBox;
        private System.Windows.Forms.RichTextBox orderNumRichTextBox;
    }
}