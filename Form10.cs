using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Form14.d == 1)
            {
                if (radioButton3.Checked == true)
                {
                    Form8 form = new Form8();
                    form.Show();
                    this.Hide();
                }

                else if (radioButton2.Checked == true)
                {
                    Form12 form = new Form12();
                    form.Show();
                    this.Hide();
                }
                else if (radioButton1.Checked == true)
                {
                    Form13 form = new Form13();
                    form.Show();
                    this.Hide();
                }
            }
            else if (Form14.d == 2)
            {
                if (radioButton3.Checked == true)
                {
                    Form15 form = new Form15();
                    form.Show();
                    this.Hide();
                }

                else if (radioButton2.Checked == true)
                {
                    Form16 form = new Form16();
                    form.Show();
                    this.Hide();
                }
                else if (radioButton1.Checked == true)
                {
                    Form17 form = new Form17();
                    form.Show();
                    this.Hide();
                }
            }


        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
            this.Hide();
        }
    }
}
