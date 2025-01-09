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
using System.Text.RegularExpressions;

namespace CollegeManagement
{
    public partial class AddLecture : System.Windows.Forms.Form


    {
        String Gender;

        String Email = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        
        public AddLecture()
        {
            InitializeComponent();
        }

        private void AddLecture_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
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

                    else if(textBoxMobileNO.Text.Length <= 9)
                    {
                        MessageBox.Show("Please Enter a valid Mobile Number");
                    }

                    else
                    {
                        MessageBox.Show("Please Enter a valid Mobile Number");
                    }

                    if (textBoxLectureId.Text != null && textBoxFullName.Text != null && radioButtonMale.Text != null && dateTimePickerDateOfBirth.Text != null && textBoxMobileNO.Text != null && textBoxEmail.Text != null && richTextBoxAddress.Text != null && textBoxCourseId.Text != null )
                    {
                           string sql = "insert into Lecture(Lecture_Id,Full_Name,Gender,DOB,Mobile,Email,Addres,Course_Id)" +
                                       "values('" + textBoxLectureId.Text + "','" + textBoxFullName.Text + "','" + Gender + "','" + dateTimePickerDateOfBirth.Text + "','" + textBoxMobileNO.Text + "','" + textBoxEmail.Text + "','" + richTextBoxAddress.Text + "','" + textBoxCourseId.Text + "')";
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

                    if (textBoxLectureId.Text != null && textBoxFullName.Text != null && radioButtonMale.Text != null && dateTimePickerDateOfBirth.Text != null && textBoxMobileNO.Text != null && textBoxEmail.Text != null && richTextBoxAddress.Text != null && textBoxCourseId.Text != null)

                    {

                        string sql = "Update Lecture set Full_Name='" + textBoxFullName.Text + "',Gender='" + radioButtonMale.Text + "',DOB='" + dateTimePickerDateOfBirth.Text + "',Mobile='" + textBoxMobileNO.Text + "',Email='" + textBoxEmail.Text + "',Addres='" + richTextBoxAddress.Text + "' ,Course_Id='" + textBoxCourseId.Text + "'" +
                                 "where Lecture_Id = '" + textBoxLectureId.Text + "' ";


                        SqlCommand comnobj = new SqlCommand(sql, conobj);
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
                    if (textBoxLectureId.Text != null)
                    {

                        string sql = "Delete from Lecture where Lecture_Id = '" + textBoxLectureId.Text + "' ";


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

                        ClassConnect obj = new ClassConnect();
                        string sql = "select*from Lecture";
                        SqlCommand conobj = new SqlCommand(sql, obj.GetDatabaseConnection());
                        SqlDataAdapter adapter = new SqlDataAdapter(conobj);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewLecture.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
            }

            private void buttonReset_Click(object sender, EventArgs e)
            {
                textBoxLectureId.Clear();
                textBoxFullName.Clear();
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                dateTimePickerDateOfBirth.Enabled = false;
                textBoxMobileNO.Clear();
                textBoxEmail.Clear();
                richTextBoxAddress.Clear();
                textBoxCourseId.Clear();

            }

        
            private void textBoxEmail_Leave(object sender, EventArgs e)
            {
                if(Regex.IsMatch(textBoxEmail.Text,Email)==false)
                {
                    errorProvider1.SetError(this.textBoxEmail, "Invalid Email");
                }
                else
                {
                    errorProvider1.Clear();
                }

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
