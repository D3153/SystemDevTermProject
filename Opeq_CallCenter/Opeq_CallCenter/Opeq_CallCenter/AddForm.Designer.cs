namespace Opeq_CallCenter
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.problemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MATTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailRadioBtn = new System.Windows.Forms.RadioButton();
            this.phoneRadioBtn = new System.Windows.Forms.RadioButton();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.inPersonRadioBtn = new System.Windows.Forms.RadioButton();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.opeq_CallCenterDataSet1 = new Opeq_CallCenter.Opeq_CallCenterDataSet();
            this.computerProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.screenProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.laptopProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneOrTabletProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addRadioBtn = new System.Windows.Forms.RadioButton();
            this.modifyRadioBtn = new System.Windows.Forms.RadioButton();
            this.viewRadioBtn = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opeq_CallCenterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // problemDescriptionTextBox
            // 
            this.problemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemDescriptionTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.problemDescriptionTextBox.Location = new System.Drawing.Point(578, 212);
            this.problemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.problemDescriptionTextBox.Multiline = true;
            this.problemDescriptionTextBox.Name = "problemDescriptionTextBox";
            this.problemDescriptionTextBox.Size = new System.Drawing.Size(516, 55);
            this.problemDescriptionTextBox.TabIndex = 2;
            this.problemDescriptionTextBox.Text = "Entrer problème";
            this.problemDescriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.problemDescriptionTextBox_MouseClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nameTextBox.Location = new System.Drawing.Point(577, 81);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(516, 55);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Entrer nom du cliente";
            this.nameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameTextBox_MouseClick);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.emailTextbox.Location = new System.Drawing.Point(763, 424);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextbox.Multiline = true;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(332, 33);
            this.emailTextbox.TabIndex = 9;
            this.emailTextbox.Text = "Courriel";
            this.emailTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.emailTextbox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comment Contacter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // MATTextBox
            // 
            this.MATTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MATTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MATTextBox.Location = new System.Drawing.Point(575, 1145);
            this.MATTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MATTextBox.Multiline = true;
            this.MATTextBox.Name = "MATTextBox";
            this.MATTextBox.Size = new System.Drawing.Size(440, 55);
            this.MATTextBox.TabIndex = 12;
            this.MATTextBox.Text = "MAT";
            this.MATTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MATTextBox_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 626);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type de Probléme";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(712, 298);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(383, 24);
            this.dateTimePicker.TabIndex = 13;
            // 
            // emailRadioBtn
            // 
            this.emailRadioBtn.AutoSize = true;
            this.emailRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRadioBtn.Location = new System.Drawing.Point(579, 424);
            this.emailRadioBtn.Name = "emailRadioBtn";
            this.emailRadioBtn.Size = new System.Drawing.Size(81, 24);
            this.emailRadioBtn.TabIndex = 14;
            this.emailRadioBtn.Text = "Courriel";
            this.emailRadioBtn.UseVisualStyleBackColor = true;
            // 
            // phoneRadioBtn
            // 
            this.phoneRadioBtn.AutoSize = true;
            this.phoneRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneRadioBtn.Location = new System.Drawing.Point(579, 492);
            this.phoneRadioBtn.Name = "phoneRadioBtn";
            this.phoneRadioBtn.Size = new System.Drawing.Size(102, 24);
            this.phoneRadioBtn.TabIndex = 16;
            this.phoneRadioBtn.Text = "Téléphone";
            this.phoneRadioBtn.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneTextBox.Location = new System.Drawing.Point(763, 492);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(332, 33);
            this.phoneTextBox.TabIndex = 15;
            this.phoneTextBox.Text = "Téléphone";
            this.phoneTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.phoneTextBox_MouseClick);
            // 
            // inPersonRadioBtn
            // 
            this.inPersonRadioBtn.AutoSize = true;
            this.inPersonRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPersonRadioBtn.Location = new System.Drawing.Point(579, 558);
            this.inPersonRadioBtn.Name = "inPersonRadioBtn";
            this.inPersonRadioBtn.Size = new System.Drawing.Size(119, 24);
            this.inPersonRadioBtn.TabIndex = 18;
            this.inPersonRadioBtn.Text = "En Personne";
            this.inPersonRadioBtn.UseVisualStyleBackColor = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.addressTextBox.Location = new System.Drawing.Point(763, 558);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(332, 33);
            this.addressTextBox.TabIndex = 17;
            this.addressTextBox.Text = "Addresse";
            this.addressTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addressTextBox_MouseClick);
            // 
            // opeq_CallCenterDataSet1
            // 
            this.opeq_CallCenterDataSet1.DataSetName = "Opeq_CallCenterDataSet";
            this.opeq_CallCenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computerProblemComboBox
            // 
            this.computerProblemComboBox.FormattingEnabled = true;
            this.computerProblemComboBox.Location = new System.Drawing.Point(579, 724);
            this.computerProblemComboBox.Name = "computerProblemComboBox";
            this.computerProblemComboBox.Size = new System.Drawing.Size(357, 26);
            this.computerProblemComboBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 682);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ordinateur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 775);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Écran";
            // 
            // screenProblemComboBox
            // 
            this.screenProblemComboBox.FormattingEnabled = true;
            this.screenProblemComboBox.Location = new System.Drawing.Point(579, 817);
            this.screenProblemComboBox.Name = "screenProblemComboBox";
            this.screenProblemComboBox.Size = new System.Drawing.Size(357, 26);
            this.screenProblemComboBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(581, 881);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Portable";
            // 
            // laptopProblemComboBox
            // 
            this.laptopProblemComboBox.FormattingEnabled = true;
            this.laptopProblemComboBox.Location = new System.Drawing.Point(577, 922);
            this.laptopProblemComboBox.Name = "laptopProblemComboBox";
            this.laptopProblemComboBox.Size = new System.Drawing.Size(357, 26);
            this.laptopProblemComboBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 980);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cellulaire/Tablette";
            // 
            // phoneOrTabletProblemComboBox
            // 
            this.phoneOrTabletProblemComboBox.FormattingEnabled = true;
            this.phoneOrTabletProblemComboBox.Location = new System.Drawing.Point(577, 1022);
            this.phoneOrTabletProblemComboBox.Name = "phoneOrTabletProblemComboBox";
            this.phoneOrTabletProblemComboBox.Size = new System.Drawing.Size(357, 26);
            this.phoneOrTabletProblemComboBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 1092);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "MAT";
            // 
            // addRadioBtn
            // 
            this.addRadioBtn.AutoSize = true;
            this.addRadioBtn.Checked = true;
            this.addRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRadioBtn.Location = new System.Drawing.Point(50, 54);
            this.addRadioBtn.Name = "addRadioBtn";
            this.addRadioBtn.Size = new System.Drawing.Size(119, 30);
            this.addRadioBtn.TabIndex = 28;
            this.addRadioBtn.TabStop = true;
            this.addRadioBtn.Text = "Adjouter";
            this.addRadioBtn.UseVisualStyleBackColor = true;
            // 
            // modifyRadioBtn
            // 
            this.modifyRadioBtn.AutoSize = true;
            this.modifyRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyRadioBtn.Location = new System.Drawing.Point(50, 149);
            this.modifyRadioBtn.Name = "modifyRadioBtn";
            this.modifyRadioBtn.Size = new System.Drawing.Size(115, 30);
            this.modifyRadioBtn.TabIndex = 29;
            this.modifyRadioBtn.Text = "Modifier";
            this.modifyRadioBtn.UseVisualStyleBackColor = true;
            this.modifyRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modifyRadioBtn_MouseClick);
            // 
            // viewRadioBtn
            // 
            this.viewRadioBtn.AutoSize = true;
            this.viewRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRadioBtn.Location = new System.Drawing.Point(50, 243);
            this.viewRadioBtn.Name = "viewRadioBtn";
            this.viewRadioBtn.Size = new System.Drawing.Size(73, 30);
            this.viewRadioBtn.TabIndex = 30;
            this.viewRadioBtn.Text = "Voir";
            this.viewRadioBtn.UseVisualStyleBackColor = true;
            this.viewRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewRadioBtn_MouseClick);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(286, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 1297);
            this.label11.TabIndex = 31;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.Location = new System.Drawing.Point(802, 1232);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(153, 61);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(612, 1232);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 61);
            this.addBtn.TabIndex = 34;
            this.addBtn.Text = "Adjouter";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1701, 1031);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.viewRadioBtn);
            this.Controls.Add(this.modifyRadioBtn);
            this.Controls.Add(this.addRadioBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phoneOrTabletProblemComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.laptopProblemComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.screenProblemComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.computerProblemComboBox);
            this.Controls.Add(this.inPersonRadioBtn);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneRadioBtn);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailRadioBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.MATTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.problemDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opeq_CallCenterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox problemDescriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MATTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton emailRadioBtn;
        private System.Windows.Forms.RadioButton phoneRadioBtn;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.RadioButton inPersonRadioBtn;
        private System.Windows.Forms.TextBox addressTextBox;
        private Opeq_CallCenterDataSet opeq_CallCenterDataSet1;
        private System.Windows.Forms.ComboBox computerProblemComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox screenProblemComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox laptopProblemComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox phoneOrTabletProblemComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton addRadioBtn;
        private System.Windows.Forms.RadioButton modifyRadioBtn;
        private System.Windows.Forms.RadioButton viewRadioBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
    }
}