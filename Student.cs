using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class New_Admission : System.Windows.Forms.Form
    {
        private readonly object txtMobileNo;
        private object textBoxMotherName;
        private object textBoxDOB;
        private object dataGridView;

        String Gender;
        public New_Admission()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void New_Admission_Load(object sender, EventArgs e)
        {

        }

        private void labelDuration_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
                try
                {
                    string connstring = @"Data Source=DESKTOP-BM9KUSR; Initial catalog=College; Integrated Security=True ";

                    SqlConnection conobj = new SqlConnection(connstring);
                    conobj.Open();
                    //MessageBox.Show("connection is successful");

                    if (textBoxMobileNO.Text.Length == 10)
                    {
                    }

                    else
                    {
                        MessageBox.Show("Please Enter Only 10 digit");
                    }
                    if (textBoxStudentId.Text != null && textBoxFullName.Text != null && radioButtonMale.Text != null && dateTimePickerDateOfBirth.Text != null && textBoxMobileNO.Text != null && richTextBoxAddress.Text != null)
                    {

                        string sql = "insert into Student(Student_ID,Full_Name,Gender,DOB,Mobile,Addres)" +
                               "values('" + textBoxStudentId.Text + "','" + textBoxFullName.Text + "','" + Gender + "','" + dateTimePickerDateOfBirth.Text + "','" + textBoxMobileNO.Text + "','" + richTextBoxAddress.Text + "')";
                        SqlCommand comnobj = new SqlCommand(sql, conobj);
                        comnobj.ExecuteNonQuery();
                        MessageBox.Show("Record inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Please enter values");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("connection is failed" + ex.Message);
                }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

                try
                {
                    string connstring = @"Data Source=DESKTOP-BM9KUSR   ; Initial catalog=College; Integrated Security=True ";

                    SqlConnection conobj = new SqlConnection(connstring);
                    conobj.Open();
                    MessageBox.Show("connection is successful");
                    //ClassConnect classConnect = new ClassConnect();
                   // SqlConnection obj = classConnect.GetDatabaseConnection();

                    if (textBoxStudentId.Text != null && textBoxFullName.Text != null && radioButtonMale .Text != null && dateTimePickerDateOfBirth.Text != null && textBoxMobileNO.Text != null && richTextBoxAddress.Text != null)
                
                    {

                        string sql = "Update Student set Full_Name='" + textBoxFullName.Text + "',Gender='" + radioButtonMale.Text + "',DOB='" + dateTimePickerDateOfBirth.Text + "',Mobile='" + textBoxMobileNO.Text + "',Addres='" + richTextBoxAddress.Text + "' " +
                                 "where Student_ID = '" + textBoxStudentId.Text + "' ";


                        SqlCommand comnobj = new SqlCommand(sql,conobj);
                        comnobj.ExecuteNonQuery();
                        MessageBox.Show("Update successfully");
                    }

                    else
                    {
                        MessageBox.Show("Error");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("connection is failed" + ex.Message);
                }
        }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
                try
                {
                    string connstring = @"Data Source=DESKTOP-BM9KUSR; Initial catalog=College; Integrated Security=True ";

                    SqlConnection conobj = new SqlConnection(connstring);
                    conobj.Open();
                    //MessageBox.Show("connection is successful");
                    if (textBoxStudentId.Text != null)
                    {

                        string sql = "Delete from Student where Student_Id = '" + textBoxStudentId.Text + "' ";


                        SqlCommand comnobj = new SqlCommand(sql, conobj);
                        comnobj.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                    }

                    else
                    {
                        MessageBox.Show("Error");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("connection is failed" + ex.Message);
                }
            }

            private void buttonViewAll_Click(object sender, EventArgs e)
            {
                try
                {
                    //string connstring = @"Data Source=DESKTOP-BM9KUSR; Initial catalog=College; Integrated Security=True ";

                    //SqlConnection conobj = new SqlConnection(connstring);
                    //conobj.Open();

                    ClassConnect obj = new ClassConnect();
                    string sql = "select*from Student";
                    SqlCommand conobj = new SqlCommand(sql, obj.GetDatabaseConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter(conobj);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewStudent.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private void buttonReset_Click(object sender, EventArgs e)
            {
                textBoxStudentId.Clear();
                textBoxFullName.Clear();
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                dateTimePickerDateOfBirth.Enabled = false;
                textBoxMobileNO.Clear();
                richTextBoxAddress.Clear();
            }

            private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
            {
                Gender = "Male";
            }

            private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
            {
                Gender = "Female";
            }
    }
}
