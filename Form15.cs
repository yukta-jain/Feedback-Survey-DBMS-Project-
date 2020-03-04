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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=System;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            
            if (radioButton1.Checked == true) //psq
                {
                
                string sql = "Select  q.q_text,avg(a.ans) FROM Answer a inner join Question q on a.q_id=q.q_id where a.c_num=10  GROUP BY q.q_id,q.q_text ";
                connection.Open();
               
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);

                
                DataTable dataTable = new DataTable();

                dataadapter.Fill(dataTable);
                connection.Close();

                dataGridView1.DataSource = dataTable;
               

            }

                else if (radioButton2.Checked == true) //unix
                {
                
                string sql = "Select  q.q_text,avg(a.ans) FROM Question q inner join Answer a on a.q_id=q.q_id where a.c_num=11  GROUP BY q.q_id,q.q_text ";
                connection.Open();
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);

                DataTable dataTable = new DataTable();

                dataadapter.Fill(dataTable);
                connection.Close();

                dataGridView1.DataSource = dataTable;
            }
                else if (radioButton3.Checked == true) //os
                {
                string sql = "Select  q.q_text,avg(a.ans) FROM Question q inner join Answer a on a.q_id=q.q_id where a.c_num=12  GROUP BY q.q_id,q.q_text ";
                connection.Open();
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);

                DataTable dataTable = new DataTable();

                dataadapter.Fill(dataTable);
                connection.Close();

                dataGridView1.DataSource = dataTable;
            }
            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
            this.Hide();
        }
    }
    }

