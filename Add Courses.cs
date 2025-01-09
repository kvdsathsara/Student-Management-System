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
    public partial class AddCourse : System.Windows.Forms.Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    if (textBoxCourseId.Text != null && textBoxCourseName.Text != null && comboBoxDuration.Text != null)
                    {

                        string sql = "insert into Course(Course_ID,Course_Name,Duration)" +
                               "values('" + textBoxCourseId.Text + "','" + textBoxCourseName.Text + "','" + comboBoxDuration.Text + "')";
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

                    if (textBoxCourseId.Text != null && textBoxCourseName.Text != null && comboBoxDuration.Text != null)

                    {

                        string sql = "Update Course set Course_Name='" + textBoxCourseName.Text + "',Duration='" + comboBoxDuration.Text + "' " +
                                 "where Course_Id = '" + textBoxCourseId.Text + "' ";


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
                    if (textBoxCourseId.Text != null)
                    {

                        string sql = "Delete from Course where Course_Id = '" + textBoxCourseId.Text + "' ";


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
                    string sql = "select*from Course";
                    SqlCommand conobj = new SqlCommand(sql, obj.GetDatabaseConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter(conobj);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewCourse.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private void buttonReset_Click(object sender, EventArgs e)
            {
                textBoxCourseId.Clear();
                textBoxCourseName.Clear();
                comboBoxDuration.Items.Clear();

            }
    }
}
