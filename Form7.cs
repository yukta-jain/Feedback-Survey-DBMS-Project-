using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        int[] a = new int[5];
        int count = 0;
        string c_num;
        string usn;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label6.Text = Form4.items[2];
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { a[0] = 1; count++; }
            else if (radioButton2.Checked == true) { a[0] = 2; count++; }
            else if (radioButton3.Checked == true) { a[0] = 3; count++; }
            else if (radioButton4.Checked == true) { a[0] = 4; count++; }
            else if (radioButton5.Checked == true) { a[0] = 5; count++; }

            if (radioButton10.Checked == true) { a[1] = 1; count++; }
            else if (radioButton9.Checked == true) { a[1] = 2; count++; }
            else if (radioButton8.Checked == true) { a[1] = 3; count++; }
            else if (radioButton7.Checked == true) { a[1] = 4; count++; }
            else if (radioButton6.Checked == true) { a[1] = 5; count++; }

            if (radioButton15.Checked == true) { a[2] = 1; count++; }
            else if (radioButton14.Checked == true) { a[2] = 2; count++; }
            else if (radioButton13.Checked == true) { a[2] = 3; count++; }
            else if (radioButton12.Checked == true) { a[2] = 4; count++; }
            else if (radioButton11.Checked == true) { a[2] = 5; count++; }

            if (radioButton20.Checked == true) { a[3] = 1; count++; }
            else if (radioButton19.Checked == true) { a[3] = 2; count++; }
            else if (radioButton18.Checked == true) { a[3] = 3; count++; }
            else if (radioButton17.Checked == true) { a[3] = 4; count++; }
            else if (radioButton16.Checked == true) { a[3] = 5; count++; }

            if (radioButton25.Checked == true) { a[4] = 1; count++; }
            else if (radioButton24.Checked == true) { a[4] = 2; count++; }
            else if (radioButton23.Checked == true) { a[4] = 3; count++; }
            else if (radioButton22.Checked == true) { a[4] = 4; count++; }
            else if (radioButton21.Checked == true) { a[4] = 5; count++; }



            try
            {
                string myConnection = " Provider=OraOLEDB.Oracle; Data Source=orcl;User Id=System; Password=orcl;";
                if (count == 5)
                {

                    string sql = "select usn from Student where username= '" + Form2.uname + "'";
                    OleDbConnection connection = new OleDbConnection(myConnection);
                    connection.Open();
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    DataTable dataTable = new DataTable();
                    dataadapter.Fill(dataTable);
                    usn = dataTable.Rows[0][0].ToString();
                    connection.Close();

                    string sql1 = "select c_num from Course where c_name= '" + Form4.items[2] + "'";
                    OleDbConnection connection1 = new OleDbConnection(myConnection);
                    connection1.Open();
                    OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(sql1, connection1);
                    DataTable dataTable1 = new DataTable();
                    dataadapter1.Fill(dataTable1);
                    c_num = dataTable1.Rows[0][0].ToString();
                    connection1.Close();


                    for (int i = 0; i < 5; i++)
                    {
                        string sql3 = "select * from Answer";
                        OleDbConnection connection2 = new OleDbConnection(myConnection);
                        connection2.Open();
                        OleDbDataAdapter dataadapter2 = new OleDbDataAdapter(sql3, connection2);
                        DataSet ds = new DataSet();
                        dataadapter2.Fill(ds, "Answer");
                        string sql2 = "insert into Answer(usn,q_id, ans,c_num) values('" + usn + "','" + (i + 1) + "', '" + a[i] + "','" + c_num + "')";
                        dataadapter2.InsertCommand = new OleDbCommand(sql2, connection2);
                        dataadapter2.InsertCommand.ExecuteNonQuery();
                        connection2.Close();
                        

                    }
                    MessageBox.Show("Submitted succesfully");



                    Form4 form = new Form4();
                    form.Show();
                    this.Hide();
                }
                else if (count < 5)
                    MessageBox.Show("Give all answers.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
    }

