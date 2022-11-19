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
            this.problemDescription = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MAT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailRadioBtn = new System.Windows.Forms.RadioButton();
            this.phoneRadioBtn = new System.Windows.Forms.RadioButton();
            this.phone = new System.Windows.Forms.TextBox();
            this.inPersonRadioBtn = new System.Windows.Forms.RadioButton();
            this.address = new System.Windows.Forms.TextBox();
            this.opeq_CallCenterDataSet1 = new Opeq_CallCenter.Opeq_CallCenterDataSet();
            this.computerProblem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.screenProblem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.laptopProblem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneOrTabletProblem = new System.Windows.Forms.ComboBox();
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
            this.label1.Size = new System.Drawing.Size(76, 32);
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
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // problemDescription
            // 
            this.problemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemDescription.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.problemDescription.Location = new System.Drawing.Point(578, 212);
            this.problemDescription.Margin = new System.Windows.Forms.Padding(4);
            this.problemDescription.Multiline = true;
            this.problemDescription.Name = "problemDescription";
            this.problemDescription.Size = new System.Drawing.Size(516, 55);
            this.problemDescription.TabIndex = 2;
            this.problemDescription.Text = "Entrer problème ";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.name.Location = new System.Drawing.Point(577, 81);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(516, 55);
            this.name.TabIndex = 3;
            this.name.Text = "Entrer nom du cliente";
            this.name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.email.Location = new System.Drawing.Point(763, 424);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(332, 33);
            this.email.TabIndex = 9;
            this.email.Text = "Courriel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 32);
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
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // MAT
            // 
            this.MAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MAT.Location = new System.Drawing.Point(575, 1145);
            this.MAT.Margin = new System.Windows.Forms.Padding(4);
            this.MAT.Multiline = true;
            this.MAT.Name = "MAT";
            this.MAT.Size = new System.Drawing.Size(440, 55);
            this.MAT.TabIndex = 12;
            this.MAT.Text = "MAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 626);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type de Probléme";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(712, 298);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(383, 32);
            this.dateTimePicker.TabIndex = 13;
            // 
            // emailRadioBtn
            // 
            this.emailRadioBtn.AutoSize = true;
            this.emailRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRadioBtn.Location = new System.Drawing.Point(579, 424);
            this.emailRadioBtn.Name = "emailRadioBtn";
            this.emailRadioBtn.Size = new System.Drawing.Size(124, 33);
            this.emailRadioBtn.TabIndex = 14;
            this.emailRadioBtn.TabStop = true;
            this.emailRadioBtn.Text = "Courriel";
            this.emailRadioBtn.UseVisualStyleBackColor = true;
            // 
            // phoneRadioBtn
            // 
            this.phoneRadioBtn.AutoSize = true;
            this.phoneRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneRadioBtn.Location = new System.Drawing.Point(579, 492);
            this.phoneRadioBtn.Name = "phoneRadioBtn";
            this.phoneRadioBtn.Size = new System.Drawing.Size(156, 33);
            this.phoneRadioBtn.TabIndex = 16;
            this.phoneRadioBtn.TabStop = true;
            this.phoneRadioBtn.Text = "Téléphone";
            this.phoneRadioBtn.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phone.Location = new System.Drawing.Point(763, 492);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(332, 33);
            this.phone.TabIndex = 15;
            this.phone.Text = "Téléphone";
            // 
            // inPersonRadioBtn
            // 
            this.inPersonRadioBtn.AutoSize = true;
            this.inPersonRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPersonRadioBtn.Location = new System.Drawing.Point(579, 558);
            this.inPersonRadioBtn.Name = "inPersonRadioBtn";
            this.inPersonRadioBtn.Size = new System.Drawing.Size(177, 33);
            this.inPersonRadioBtn.TabIndex = 18;
            this.inPersonRadioBtn.TabStop = true;
            this.inPersonRadioBtn.Text = "En Personne";
            this.inPersonRadioBtn.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.address.Location = new System.Drawing.Point(763, 558);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(332, 33);
            this.address.TabIndex = 17;
            this.address.Text = "Addresse";
            // 
            // opeq_CallCenterDataSet1
            // 
            this.opeq_CallCenterDataSet1.DataSetName = "Opeq_CallCenterDataSet";
            this.opeq_CallCenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computerProblem
            // 
            this.computerProblem.FormattingEnabled = true;
            this.computerProblem.Location = new System.Drawing.Point(579, 724);
            this.computerProblem.Name = "computerProblem";
            this.computerProblem.Size = new System.Drawing.Size(357, 34);
            this.computerProblem.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 682);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ordinateur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 775);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Écran";
            // 
            // screenProblem
            // 
            this.screenProblem.FormattingEnabled = true;
            this.screenProblem.Location = new System.Drawing.Point(579, 817);
            this.screenProblem.Name = "screenProblem";
            this.screenProblem.Size = new System.Drawing.Size(357, 34);
            this.screenProblem.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(581, 881);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Portable";
            // 
            // laptopProblem
            // 
            this.laptopProblem.FormattingEnabled = true;
            this.laptopProblem.Location = new System.Drawing.Point(577, 922);
            this.laptopProblem.Name = "laptopProblem";
            this.laptopProblem.Size = new System.Drawing.Size(357, 34);
            this.laptopProblem.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 980);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cellulaire/Tablette";
            // 
            // phoneOrTabletProblem
            // 
            this.phoneOrTabletProblem.FormattingEnabled = true;
            this.phoneOrTabletProblem.Location = new System.Drawing.Point(577, 1022);
            this.phoneOrTabletProblem.Name = "phoneOrTabletProblem";
            this.phoneOrTabletProblem.Size = new System.Drawing.Size(357, 34);
            this.phoneOrTabletProblem.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 1092);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "MAT";
            // 
            // addRadioBtn
            // 
            this.addRadioBtn.AutoSize = true;
            this.addRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRadioBtn.Location = new System.Drawing.Point(50, 54);
            this.addRadioBtn.Name = "addRadioBtn";
            this.addRadioBtn.Size = new System.Drawing.Size(170, 41);
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
            this.modifyRadioBtn.Size = new System.Drawing.Size(163, 41);
            this.modifyRadioBtn.TabIndex = 29;
            this.modifyRadioBtn.TabStop = true;
            this.modifyRadioBtn.Text = "Modifier";
            this.modifyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // viewRadioBtn
            // 
            this.viewRadioBtn.AutoSize = true;
            this.viewRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRadioBtn.Location = new System.Drawing.Point(50, 243);
            this.viewRadioBtn.Name = "viewRadioBtn";
            this.viewRadioBtn.Size = new System.Drawing.Size(104, 41);
            this.viewRadioBtn.TabIndex = 30;
            this.viewRadioBtn.TabStop = true;
            this.viewRadioBtn.Text = "Voir";
            this.viewRadioBtn.UseVisualStyleBackColor = true;
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
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1973, 1218);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.viewRadioBtn);
            this.Controls.Add(this.modifyRadioBtn);
            this.Controls.Add(this.addRadioBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phoneOrTabletProblem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.laptopProblem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.screenProblem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.computerProblem);
            this.Controls.Add(this.inPersonRadioBtn);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phoneRadioBtn);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.emailRadioBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.MAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.problemDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.opeq_CallCenterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox problemDescription;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton emailRadioBtn;
        private System.Windows.Forms.RadioButton phoneRadioBtn;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.RadioButton inPersonRadioBtn;
        private System.Windows.Forms.TextBox address;
        private Opeq_CallCenterDataSet opeq_CallCenterDataSet1;
        private System.Windows.Forms.ComboBox computerProblem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox screenProblem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox laptopProblem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox phoneOrTabletProblem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton addRadioBtn;
        private System.Windows.Forms.RadioButton modifyRadioBtn;
        private System.Windows.Forms.RadioButton viewRadioBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
    }
}