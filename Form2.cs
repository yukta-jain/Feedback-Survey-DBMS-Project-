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
using System.Data.Common;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static string uname;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string myConnection = " Provider=OraOLEDB.Oracle; Data Source=orcl;User Id=System; Password=orcl;";
                string sql = "SELECT * FROM Student where username='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "'";
                OleDbConnection connection = new OleDbConnection(myConnection);
                OleDbCommand SelectCommand = new OleDbCommand(sql, connection);
                OleDbDataReader myReader;
                connection.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("username and password are correct.");
                    uname = textBox1.Text;
                    Form4 form = new Form4();
                    form.Show();
                    this.Hide();
                    connection.Close();

                }
                else if (count > 1)
                {
                    MessageBox.Show("duplicate username and password exist. Access denied.");
                }
                else
                {
                    MessageBox.Show("username or password are incorrect. Please try again.");
                }
                
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

