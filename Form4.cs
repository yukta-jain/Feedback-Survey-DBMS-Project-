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
    public partial class Form4 : Form
    {
        
        public static string[] items;
        public Form4()
        {
            InitializeComponent();
            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=System;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            string sql = "Select c.c_name FROM Course c inner join Student s on c.sem =s.sem and c.d_num=s.d_num where username = '"+Form2.uname+"'";
            connection.Open();
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            
            DataTable dataTable = new DataTable();
           
            dataadapter.Fill(dataTable);
            connection.Close();
             
            dataGridView1.DataSource = dataTable;
            
            items = new string[4];
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                 items[i] = row[0].ToString();
                i++;
            }

            



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form18 form = new Form18();
            form.Show();
            this.Hide();


        }
    }
}
