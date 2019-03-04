using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProjectSweep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2("1");
            form.Show();
        }
        private void btnOther_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2("2");
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormConnection conn = new FormConnection();
            conn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReport report = new FormReport();
            report.Show();
        }


    }
}