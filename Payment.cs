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
    public partial class Payment : System.Windows.Forms.Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    if (textBoxPaymentId.Text != null && comboBoxSemester.Text != null && textBoxAmount.Text != null && textBoxStudentId.Text !=null )
                    {

                        string sql = "insert into Payment(Payment_ID,Semester,Amount,Student_Id)" +
                               "values('" + textBoxPaymentId.Text + "','" + comboBoxSemester.Text + "','" + textBoxAmount.Text + "','" + textBoxStudentId.Text + "')";
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

                    if (textBoxPaymentId.Text != null && comboBoxSemester.Text != null && textBoxAmount.Text != null && textBoxStudentId.Text != null)
             

                    {

                        string sql = "Update Payment set Semester='" + comboBoxSemester.SelectedIndex + "',Amount='" + textBoxAmount.Text + "',Student_Id='" + textBoxStudentId.Text + "' " +
                                 "where Payment_ID = '" + textBoxPaymentId.Text + "' ";


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
                    if (textBoxPaymentId.Text != null)
                    {

                        string sql = "Delete from Payment where Payment_Id = '" + textBoxPaymentId.Text + "' ";

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
                    string sql = "select*from Payment";
                    SqlCommand conobj = new SqlCommand(sql, obj.GetDatabaseConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter(conobj);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewPayment.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private void buttonReset_Click(object sender, EventArgs e)
            {
                textBoxPaymentId.Clear();
                textBoxAmount.Clear();
                comboBoxSemester.Items.Clear();
                textBoxStudentId.Clear();
            }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
