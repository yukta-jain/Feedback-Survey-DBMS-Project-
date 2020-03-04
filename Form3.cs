using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Data.Common;
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string myConnection = " Provider=OraOLEDB.Oracle; Data Source=orcl;User Id=System; Password=orcl;";
                if (textBox4.Text == textBox6.Text)
                {
                    int dn = 0;
                    if (radioButton1.Checked == true)
                        dn = 1;
                    else if(radioButton2.Checked == true)
                        dn = 2;

                    string sql = "select * from Student";
                    OleDbConnection connection = new OleDbConnection(myConnection);
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    dataadapter.Fill(ds, "Student");
                    string sql1 = "insert into Student(name, usn,d_num,sem,username,password,phone) values('" + textBox7.Text + "', '" + textBox1.Text + "','" + dn + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox4.Text + "', '" + textBox3.Text + "')";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Sign up complete. Please login to continue.");
                    dataadapter.Fill(ds, "Student");
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                    connection.Close();
                }
                else
                    MessageBox.Show("Passwords do not match.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
