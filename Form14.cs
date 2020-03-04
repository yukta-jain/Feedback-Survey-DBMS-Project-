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

    public partial class Form14 : Form
    {
        public static int d;
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
                d = 1;
            else
                d = 2;
            Form10 form = new Form10();
            form.Show();
            this.Hide();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }
    }
}

