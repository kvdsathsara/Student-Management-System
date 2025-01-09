namespace CollegeManagement
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.labelAddCourse = new System.Windows.Forms.Label();
            this.labelCourseId = new System.Windows.Forms.Label();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddCourse
            // 
            this.labelAddCourse.AutoSize = true;
            this.labelAddCourse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelAddCourse.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("labelAddCourse.Image")));
            this.labelAddCourse.Location = new System.Drawing.Point(269, 29);
            this.labelAddCourse.Name = "labelAddCourse";
            this.labelAddCourse.Size = new System.Drawing.Size(168, 39);
            this.labelAddCourse.TabIndex = 1;
            this.labelAddCourse.Text = "Add Course";
            // 
            // labelCourseId
            // 
            this.labelCourseId.AutoSize = true;
            this.labelCourseId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCourseId.Image = ((System.Drawing.Image)(resources.GetObject("labelCourseId.Image")));
            this.labelCourseId.Location = new System.Drawing.Point(179, 107);
            this.labelCourseId.Name = "labelCourseId";
            this.labelCourseId.Size = new System.Drawing.Size(84, 23);
            this.labelCourseId.TabIndex = 2;
            this.labelCourseId.Text = "Course Id";
            this.labelCourseId.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(347, 111);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(153, 20);
            this.textBoxCourseId.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(31, 440);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(82, 268);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.Size = new System.Drawing.Size(589, 138);
            this.dataGridViewCourse.TabIndex = 5;
            this.dataGridViewCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDuration.Image = ((System.Drawing.Image)(resources.GetObject("labelDuration.Image")));
            this.labelDuration.Location = new System.Drawing.Point(179, 214);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(79, 23);
            this.labelDuration.TabIndex = 6;
            this.labelDuration.Text = "Duration";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(347, 166);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(153, 20);
            this.textBoxCourseName.TabIndex = 9;
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCourseName.Image = ((System.Drawing.Image)(resources.GetObject("labelCourseName.Image")));
            this.labelCourseName.Location = new System.Drawing.Point(179, 162);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(116, 23);
            this.labelCourseName.TabIndex = 8;
            this.labelCourseName.Text = "Course Name";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "2024-2025",
            "2024-2026",
            "2024-2028",
            "2025-2026"});
            this.comboBoxDuration.Location = new System.Drawing.Point(347, 218);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(153, 21);
            this.comboBoxDuration.TabIndex = 35;
            this.comboBoxDuration.Text = "---Select---";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(183, 440);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(347, 440);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewAll.Image")));
            this.buttonViewAll.Location = new System.Drawing.Point(505, 440);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAll.TabIndex = 38;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.Location = new System.Drawing.Point(642, 440);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 39;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCourseId);
            this.Controls.Add(this.labelCourseId);
            this.Controls.Add(this.labelAddCourse);
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAddCourse;
        private System.Windows.Forms.Label labelCourseId;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.Button buttonSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonReset;
    }
}