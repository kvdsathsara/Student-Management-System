namespace CollegeManagement
{
    partial class AddLecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLecture));
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMobileNO = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMobileNo = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelLectureInformation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLectureId = new System.Windows.Forms.Label();
            this.textBoxLectureId = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.labelCourseId = new System.Windows.Forms.Label();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.dataGridViewLecture = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(665, 223);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(150, 40);
            this.richTextBoxAddress.TabIndex = 61;
            this.richTextBoxAddress.Text = "";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonFemale.Location = new System.Drawing.Point(284, 229);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 60;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonMale.Location = new System.Drawing.Point(210, 229);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 59;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(210, 277);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 58;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(665, 173);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(152, 20);
            this.textBoxEmail.TabIndex = 53;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxMobileNO
            // 
            this.textBoxMobileNO.Location = new System.Drawing.Point(665, 124);
            this.textBoxMobileNO.Name = "textBoxMobileNO";
            this.textBoxMobileNO.Size = new System.Drawing.Size(152, 20);
            this.textBoxMobileNO.TabIndex = 52;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(210, 173);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(152, 20);
            this.textBoxFullName.TabIndex = 50;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddress.Image = ((System.Drawing.Image)(resources.GetObject("labelAddress.Image")));
            this.labelAddress.Location = new System.Drawing.Point(499, 219);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 23);
            this.labelAddress.TabIndex = 49;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Image = ((System.Drawing.Image)(resources.GetObject("labelEmail.Image")));
            this.labelEmail.Location = new System.Drawing.Point(502, 173);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 23);
            this.labelEmail.TabIndex = 44;
            this.labelEmail.Text = "Email";
            // 
            // labelMobileNo
            // 
            this.labelMobileNo.AutoSize = true;
            this.labelMobileNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobileNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMobileNo.Image = ((System.Drawing.Image)(resources.GetObject("labelMobileNo.Image")));
            this.labelMobileNo.Location = new System.Drawing.Point(499, 120);
            this.labelMobileNo.Name = "labelMobileNo";
            this.labelMobileNo.Size = new System.Drawing.Size(94, 23);
            this.labelMobileNo.TabIndex = 43;
            this.labelMobileNo.Text = "Mobile No";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("labelDateOfBirth.Image")));
            this.labelDateOfBirth.Location = new System.Drawing.Point(40, 274);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(115, 23);
            this.labelDateOfBirth.TabIndex = 42;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGender.Image = ((System.Drawing.Image)(resources.GetObject("labelGender.Image")));
            this.labelGender.Location = new System.Drawing.Point(40, 223);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(69, 23);
            this.labelGender.TabIndex = 41;
            this.labelGender.Text = "Gender";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFullName.Image = ((System.Drawing.Image)(resources.GetObject("labelFullName.Image")));
            this.labelFullName.Location = new System.Drawing.Point(40, 173);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(90, 23);
            this.labelFullName.TabIndex = 39;
            this.labelFullName.Text = "Full Name";
            // 
            // labelLectureInformation
            // 
            this.labelLectureInformation.AutoSize = true;
            this.labelLectureInformation.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLectureInformation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLectureInformation.Image = ((System.Drawing.Image)(resources.GetObject("labelLectureInformation.Image")));
            this.labelLectureInformation.Location = new System.Drawing.Point(327, 21);
            this.labelLectureInformation.Name = "labelLectureInformation";
            this.labelLectureInformation.Size = new System.Drawing.Size(239, 33);
            this.labelLectureInformation.TabIndex = 62;
            this.labelLectureInformation.Text = "Lecture Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // labelLectureId
            // 
            this.labelLectureId.AutoSize = true;
            this.labelLectureId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLectureId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLectureId.Image = ((System.Drawing.Image)(resources.GetObject("labelLectureId.Image")));
            this.labelLectureId.Location = new System.Drawing.Point(44, 119);
            this.labelLectureId.Name = "labelLectureId";
            this.labelLectureId.Size = new System.Drawing.Size(89, 23);
            this.labelLectureId.TabIndex = 64;
            this.labelLectureId.Text = "Lecture Id";
            // 
            // textBoxLectureId
            // 
            this.textBoxLectureId.Location = new System.Drawing.Point(210, 119);
            this.textBoxLectureId.Name = "textBoxLectureId";
            this.textBoxLectureId.Size = new System.Drawing.Size(152, 20);
            this.textBoxLectureId.TabIndex = 65;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(48, 538);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
            this.buttonSave.TabIndex = 66;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(232, 538);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 30);
            this.buttonUpdate.TabIndex = 67;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(400, 538);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 68;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(665, 286);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(152, 20);
            this.textBoxCourseId.TabIndex = 70;
            // 
            // labelCourseId
            // 
            this.labelCourseId.AutoSize = true;
            this.labelCourseId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCourseId.Image = ((System.Drawing.Image)(resources.GetObject("labelCourseId.Image")));
            this.labelCourseId.Location = new System.Drawing.Point(502, 274);
            this.labelCourseId.Name = "labelCourseId";
            this.labelCourseId.Size = new System.Drawing.Size(84, 23);
            this.labelCourseId.TabIndex = 69;
            this.labelCourseId.Text = "Course Id";
            this.labelCourseId.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewAll.Image")));
            this.buttonViewAll.Location = new System.Drawing.Point(588, 538);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 30);
            this.buttonViewAll.TabIndex = 71;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // dataGridViewLecture
            // 
            this.dataGridViewLecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecture.Location = new System.Drawing.Point(48, 334);
            this.dataGridViewLecture.Name = "dataGridViewLecture";
            this.dataGridViewLecture.Size = new System.Drawing.Size(776, 163);
            this.dataGridViewLecture.TabIndex = 72;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.Location = new System.Drawing.Point(749, 538);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 30);
            this.buttonReset.TabIndex = 73;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 589);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dataGridViewLecture);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.textBoxCourseId);
            this.Controls.Add(this.labelCourseId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxLectureId);
            this.Controls.Add(this.labelLectureId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLectureInformation);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMobileNO);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelMobileNo);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullName);
            this.Name = "AddLecture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLecture";
            this.Load += new System.EventHandler(this.AddLecture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMobileNO;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMobileNo;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelLectureInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLectureId;
        private System.Windows.Forms.TextBox textBoxLectureId;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.Label labelCourseId;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.DataGridView dataGridViewLecture;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}