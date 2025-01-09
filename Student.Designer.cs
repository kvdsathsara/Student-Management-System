namespace CollegeManagement
{
    partial class New_Admission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Admission));
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelMobileNo = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxMobileNO = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFullName.Image = ((System.Drawing.Image)(resources.GetObject("labelFullName.Image")));
            this.labelFullName.Location = new System.Drawing.Point(51, 151);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(90, 23);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGender.Image = ((System.Drawing.Image)(resources.GetObject("labelGender.Image")));
            this.labelGender.Location = new System.Drawing.Point(53, 201);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(69, 23);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender";
            this.labelGender.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("labelDateOfBirth.Image")));
            this.labelDateOfBirth.Location = new System.Drawing.Point(468, 108);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(115, 23);
            this.labelDateOfBirth.TabIndex = 8;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // labelMobileNo
            // 
            this.labelMobileNo.AutoSize = true;
            this.labelMobileNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobileNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMobileNo.Image = ((System.Drawing.Image)(resources.GetObject("labelMobileNo.Image")));
            this.labelMobileNo.Location = new System.Drawing.Point(468, 155);
            this.labelMobileNo.Name = "labelMobileNo";
            this.labelMobileNo.Size = new System.Drawing.Size(94, 23);
            this.labelMobileNo.TabIndex = 10;
            this.labelMobileNo.Text = "Mobile No";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddress.Image = ((System.Drawing.Image)(resources.GetObject("labelAddress.Image")));
            this.labelAddress.Location = new System.Drawing.Point(475, 205);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 23);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(221, 155);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(152, 20);
            this.textBoxFullName.TabIndex = 24;
            // 
            // textBoxMobileNO
            // 
            this.textBoxMobileNO.Location = new System.Drawing.Point(638, 159);
            this.textBoxMobileNO.Name = "textBoxMobileNO";
            this.textBoxMobileNO.Size = new System.Drawing.Size(152, 20);
            this.textBoxMobileNO.TabIndex = 26;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(638, 109);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 35;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(221, 201);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 36;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(282, 201);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 37;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(638, 209);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(150, 55);
            this.richTextBoxAddress.TabIndex = 38;
            this.richTextBoxAddress.Text = "";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.Image")));
            this.buttonSubmit.Location = new System.Drawing.Point(66, 446);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 39;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.Location = new System.Drawing.Point(688, 446);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 40;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(221, 108);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(152, 20);
            this.textBoxStudentId.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(53, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Student Id";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(221, 446);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 43;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(376, 446);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonViewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewAll.Image")));
            this.buttonViewAll.Location = new System.Drawing.Point(532, 446);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAll.TabIndex = 45;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(43, 270);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewStudent.TabIndex = 46;
            // 
            // New_Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 495);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.textBoxMobileNO);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelMobileNo);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullName);
            this.Name = "New_Admission";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.New_Admission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelMobileNo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxMobileNO;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
    }
}