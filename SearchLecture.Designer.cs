namespace CollegeManagement
{
    partial class SearchLecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchLecture));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSearchLecture = new System.Windows.Forms.Label();
            this.labelRegistrationID = new System.Windows.Forms.Label();
            this.textBoxRegistrationID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSearchLecture
            // 
            this.labelSearchLecture.AutoSize = true;
            this.labelSearchLecture.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchLecture.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSearchLecture.Location = new System.Drawing.Point(334, 22);
            this.labelSearchLecture.Name = "labelSearchLecture";
            this.labelSearchLecture.Size = new System.Drawing.Size(140, 26);
            this.labelSearchLecture.TabIndex = 1;
            this.labelSearchLecture.Text = "Search Lecture";
            // 
            // labelRegistrationID
            // 
            this.labelRegistrationID.AutoSize = true;
            this.labelRegistrationID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationID.Location = new System.Drawing.Point(187, 96);
            this.labelRegistrationID.Name = "labelRegistrationID";
            this.labelRegistrationID.Size = new System.Drawing.Size(128, 23);
            this.labelRegistrationID.TabIndex = 2;
            this.labelRegistrationID.Text = "Registration ID";
            // 
            // textBoxRegistrationID
            // 
            this.textBoxRegistrationID.Location = new System.Drawing.Point(374, 96);
            this.textBoxRegistrationID.Name = "textBoxRegistrationID";
            this.textBoxRegistrationID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationID.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(586, 98);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 226);
            this.dataGridView1.TabIndex = 5;
            // 
            // SearchLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxRegistrationID);
            this.Controls.Add(this.labelRegistrationID);
            this.Controls.Add(this.labelSearchLecture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchLecture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchLecture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSearchLecture;
        private System.Windows.Forms.Label labelRegistrationID;
        private System.Windows.Forms.TextBox textBoxRegistrationID;
        private System.Windows.Forms.Button buttonSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}