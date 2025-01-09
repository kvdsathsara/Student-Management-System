namespace CollegeManagement
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.pictureBoxPayment = new System.Windows.Forms.PictureBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPaymentId = new System.Windows.Forms.TextBox();
            this.lablepaymentId = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPayment
            // 
            this.pictureBoxPayment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPayment.Image")));
            this.pictureBoxPayment.Location = new System.Drawing.Point(242, 12);
            this.pictureBoxPayment.Name = "pictureBoxPayment";
            this.pictureBoxPayment.Size = new System.Drawing.Size(255, 138);
            this.pictureBoxPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPayment.TabIndex = 0;
            this.pictureBoxPayment.TabStop = false;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStudentId.Image = ((System.Drawing.Image)(resources.GetObject("labelStudentId.Image")));
            this.labelStudentId.Location = new System.Drawing.Point(41, 378);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(92, 23);
            this.labelStudentId.TabIndex = 1;
            this.labelStudentId.Text = "Student Id\r\n";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAmount.Image = ((System.Drawing.Image)(resources.GetObject("labelAmount.Image")));
            this.labelAmount.Location = new System.Drawing.Point(41, 310);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(74, 23);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(213, 378);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(181, 23);
            this.textBoxStudentId.TabIndex = 6;
            this.textBoxStudentId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(213, 310);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(181, 23);
            this.textBoxAmount.TabIndex = 8;
            // 
            // textBoxPaymentId
            // 
            this.textBoxPaymentId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaymentId.Location = new System.Drawing.Point(213, 186);
            this.textBoxPaymentId.Name = "textBoxPaymentId";
            this.textBoxPaymentId.Size = new System.Drawing.Size(181, 23);
            this.textBoxPaymentId.TabIndex = 9;
            // 
            // lablepaymentId
            // 
            this.lablepaymentId.AutoSize = true;
            this.lablepaymentId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablepaymentId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lablepaymentId.Image = ((System.Drawing.Image)(resources.GetObject("lablepaymentId.Image")));
            this.lablepaymentId.Location = new System.Drawing.Point(41, 183);
            this.lablepaymentId.Name = "lablepaymentId";
            this.lablepaymentId.Size = new System.Drawing.Size(99, 23);
            this.lablepaymentId.TabIndex = 10;
            this.lablepaymentId.Text = "Payment Id";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "3rd Semester",
            "4th Semester",
            "5th Semester"});
            this.comboBoxSemester.Location = new System.Drawing.Point(213, 251);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSemester.TabIndex = 34;
            this.comboBoxSemester.Text = "---Select---";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSemester.Image = ((System.Drawing.Image)(resources.GetObject("labelSemester.Image")));
            this.labelSemester.Location = new System.Drawing.Point(41, 249);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(86, 23);
            this.labelSemester.TabIndex = 33;
            this.labelSemester.Text = "Semester";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(40, 442);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 28);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(213, 442);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 28);
            this.buttonUpdate.TabIndex = 35;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(383, 442);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 28);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewAll.Image")));
            this.buttonViewAll.Location = new System.Drawing.Point(560, 442);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 28);
            this.buttonViewAll.TabIndex = 37;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(430, 183);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.Size = new System.Drawing.Size(381, 172);
            this.dataGridViewPayment.TabIndex = 38;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.Location = new System.Drawing.Point(710, 442);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 28);
            this.buttonReset.TabIndex = 39;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(823, 495);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dataGridViewPayment);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.lablepaymentId);
            this.Controls.Add(this.textBoxPaymentId);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.pictureBoxPayment);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPayment;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPaymentId;
        private System.Windows.Forms.Label lablepaymentId;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.Button buttonReset;
    }
}