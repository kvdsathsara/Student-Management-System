using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
            public FormMenu()
            {
                InitializeComponent();
            }

            private void textBoPassword_TextChanged(object sender, EventArgs e)
            {
              
            }

            private void indToolStripMenuItem_Click(object sender, EventArgs e)
            {
                StudentDetail SD = new StudentDetail();
                SD.Show();
            }

            private void adToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {
                menuStrip1.Visible=false;
            }

            private void buttonLogin_Click(object sender, EventArgs e)
            {
                String username = textBoxUsername.Text;
                String passwold = textBoPassword.Text;

                if (username == "Dilshan" && passwold == "1234")
                {
                    menuStrip1.Visible = true;
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Passwold");
                }

            }

            private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
            {
                New_Admission NA = new New_Admission();
                NA.Show();
            }

            private void upToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //UpGradeSemester UGS = new UpGradeSemester();
                //UGS.Show();
            }

            private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Payment P= new Payment();
                P.Show();
            }

            private void studentDeatilsToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AddCourse AC = new AddCourse();
                AC.Show();
            }

            private void addLecturerInformationToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AddLecture AL = new AddLecture();
                AL.Show();
            }

        
       

            private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AboutUs AU = new AboutUs();
                AU.Show();
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void lecturerToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void labelUsername_Click(object sender, EventArgs e)
            {

            }
    }
}
