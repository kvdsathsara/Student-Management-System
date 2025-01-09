namespace CollegeManagement
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelCOLLEGE = new System.Windows.Forms.Label();
            this.labelMANAGEMENT = new System.Windows.Forms.Label();
            this.labelSYSTEM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDeatilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLecturerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCOLLEGE
            // 
            this.labelCOLLEGE.AutoSize = true;
            this.labelCOLLEGE.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOLLEGE.Image = ((System.Drawing.Image)(resources.GetObject("labelCOLLEGE.Image")));
            this.labelCOLLEGE.Location = new System.Drawing.Point(51, 375);
            this.labelCOLLEGE.Name = "labelCOLLEGE";
            this.labelCOLLEGE.Size = new System.Drawing.Size(350, 73);
            this.labelCOLLEGE.TabIndex = 0;
            this.labelCOLLEGE.Text = "COLLEGE";
            // 
            // labelMANAGEMENT
            // 
            this.labelMANAGEMENT.AutoSize = true;
            this.labelMANAGEMENT.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMANAGEMENT.Image = ((System.Drawing.Image)(resources.GetObject("labelMANAGEMENT.Image")));
            this.labelMANAGEMENT.Location = new System.Drawing.Point(220, 461);
            this.labelMANAGEMENT.Name = "labelMANAGEMENT";
            this.labelMANAGEMENT.Size = new System.Drawing.Size(517, 73);
            this.labelMANAGEMENT.TabIndex = 1;
            this.labelMANAGEMENT.Text = "MANAGEMENT";
            // 
            // labelSYSTEM
            // 
            this.labelSYSTEM.AutoSize = true;
            this.labelSYSTEM.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSYSTEM.Image = ((System.Drawing.Image)(resources.GetObject("labelSYSTEM.Image")));
            this.labelSYSTEM.Location = new System.Drawing.Point(573, 558);
            this.labelSYSTEM.Name = "labelSYSTEM";
            this.labelSYSTEM.Size = new System.Drawing.Size(297, 73);
            this.labelSYSTEM.TabIndex = 2;
            this.labelSYSTEM.Text = "SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Location = new System.Drawing.Point(617, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 223);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.Location = new System.Drawing.Point(184, 171);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoPassword
            // 
            this.textBoPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoPassword.Location = new System.Drawing.Point(153, 126);
            this.textBoPassword.Name = "textBoPassword";
            this.textBoPassword.PasswordChar = '*';
            this.textBoPassword.Size = new System.Drawing.Size(136, 26);
            this.textBoPassword.TabIndex = 3;
            this.textBoPassword.TextChanged += new System.EventHandler(this.textBoPassword_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxUsername.Location = new System.Drawing.Point(153, 81);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(136, 26);
            this.textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Image = ((System.Drawing.Image)(resources.GetObject("labelPassword.Image")));
            this.labelPassword.Location = new System.Drawing.Point(35, 126);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 21);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Image = ((System.Drawing.Image)(resources.GetObject("labelUsername.Image")));
            this.labelUsername.Location = new System.Drawing.Point(35, 84);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(93, 21);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "User Name";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.studentDeatilsToolStripMenuItem,
            this.lecturerToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 101);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem});
            this.adToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adToolStripMenuItem.Image")));
            this.adToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(114, 97);
            this.adToolStripMenuItem.Text = "Student";
            this.adToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.adToolStripMenuItem.Click += new System.EventHandler(this.adToolStripMenuItem_Click);
            // 
            // newAdmissionToolStripMenuItem
            // 
            this.newAdmissionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newAdmissionToolStripMenuItem.BackgroundImage")));
            this.newAdmissionToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAdmissionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            this.newAdmissionToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.newAdmissionToolStripMenuItem.Text = "New Admission";
            this.newAdmissionToolStripMenuItem.Click += new System.EventHandler(this.newAdmissionToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.paymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentToolStripMenuItem.Image")));
            this.paymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(125, 97);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // studentDeatilsToolStripMenuItem
            // 
            this.studentDeatilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem});
            this.studentDeatilsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDeatilsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentDeatilsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentDeatilsToolStripMenuItem.Image")));
            this.studentDeatilsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentDeatilsToolStripMenuItem.Name = "studentDeatilsToolStripMenuItem";
            this.studentDeatilsToolStripMenuItem.Size = new System.Drawing.Size(105, 97);
            this.studentDeatilsToolStripMenuItem.Text = "Course";
            this.studentDeatilsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.studentDeatilsToolStripMenuItem.Click += new System.EventHandler(this.studentDeatilsToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchStudentToolStripMenuItem.BackgroundImage")));
            this.searchStudentToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.searchStudentToolStripMenuItem.Text = "Add Courses";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // lecturerToolStripMenuItem
            // 
            this.lecturerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLecturerInformationToolStripMenuItem});
            this.lecturerToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecturerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lecturerToolStripMenuItem.Image")));
            this.lecturerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lecturerToolStripMenuItem.Name = "lecturerToolStripMenuItem";
            this.lecturerToolStripMenuItem.Size = new System.Drawing.Size(120, 97);
            this.lecturerToolStripMenuItem.Text = "Lecturer";
            this.lecturerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.lecturerToolStripMenuItem.Click += new System.EventHandler(this.lecturerToolStripMenuItem_Click);
            // 
            // addLecturerInformationToolStripMenuItem
            // 
            this.addLecturerInformationToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addLecturerInformationToolStripMenuItem.BackgroundImage")));
            this.addLecturerInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLecturerInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addLecturerInformationToolStripMenuItem.Name = "addLecturerInformationToolStripMenuItem";
            this.addLecturerInformationToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.addLecturerInformationToolStripMenuItem.Text = "Add Lecturer Information";
            this.addLecturerInformationToolStripMenuItem.Click += new System.EventHandler(this.addLecturerInformationToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUsToolStripMenuItem.Image")));
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(130, 97);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(72, 97);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSYSTEM);
            this.Controls.Add(this.labelMANAGEMENT);
            this.Controls.Add(this.labelCOLLEGE);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCOLLEGE;
        private System.Windows.Forms.Label labelMANAGEMENT;
        private System.Windows.Forms.Label labelSYSTEM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLecturerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem studentDeatilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
    }
}

