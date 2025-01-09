namespace CollegeManagement
{
    partial class RemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStudent));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxRegistrationID = new System.Windows.Forms.TextBox();
            this.labelRegistrationID = new System.Windows.Forms.Label();
            this.labelRemoveStudent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 226);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(446, 140);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxRegistrationID
            // 
            this.textBoxRegistrationID.Location = new System.Drawing.Point(253, 143);
            this.textBoxRegistrationID.Name = "textBoxRegistrationID";
            this.textBoxRegistrationID.Size = new System.Drawing.Size(110, 20);
            this.textBoxRegistrationID.TabIndex = 9;
            // 
            // labelRegistrationID
            // 
            this.labelRegistrationID.AutoSize = true;
            this.labelRegistrationID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationID.Location = new System.Drawing.Point(249, 101);
            this.labelRegistrationID.Name = "labelRegistrationID";
            this.labelRegistrationID.Size = new System.Drawing.Size(128, 23);
            this.labelRegistrationID.TabIndex = 8;
            this.labelRegistrationID.Text = "Registration ID";
            // 
            // labelRemoveStudent
            // 
            this.labelRemoveStudent.AutoSize = true;
            this.labelRemoveStudent.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRemoveStudent.Location = new System.Drawing.Point(167, 9);
            this.labelRemoveStudent.Name = "labelRemoveStudent";
            this.labelRemoveStudent.Size = new System.Drawing.Size(318, 36);
            this.labelRemoveStudent.TabIndex = 7;
            this.labelRemoveStudent.Text = "Remove Student Record ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(654, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxRegistrationID);
            this.Controls.Add(this.labelRegistrationID);
            this.Controls.Add(this.labelRemoveStudent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveStudent";
            this.Load += new System.EventHandler(this.RemoveStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxRegistrationID;
        private System.Windows.Forms.Label labelRegistrationID;
        private System.Windows.Forms.Label labelRemoveStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}