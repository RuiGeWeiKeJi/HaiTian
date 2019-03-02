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
    public partial class FormReportQuery : Form
    {
        public FormReportQuery()
        {
            InitializeComponent();
            
            comboBox8.Items.Add("");
            comboBox8.Items.Add("T");
            comboBox8.Items.Add("F");
            this.button3.Focus();   
        }

        public delegate void PassDataBetweenFormHandler(object sender, PassDataWinFormEventArgs e);
        public event PassDataBetweenFormHandler PassDataBetweenForm;

        //sure
        private void button2_Click(object sender, EventArgs e)
        {
            string strWh = "1=1";
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                strWh = strWh + " AND BAR001='" + comboBox1.Text + "'";
            }
            if (!string.IsNullOrEmpty(comboBox2.Text))
            {
                strWh = strWh + " AND BAR006='" + comboBox2.Text + "'";
            }
            if (!string.IsNullOrEmpty(comboBox3.Text))
            {
                strWh = strWh + " AND BAR007='" + comboBox3.Text + "'";
            }
            if (!string.IsNullOrEmpty(comboBox4.Text))
            {
                strWh = strWh + " AND BAR008='" + comboBox4.Text + "'";
            }
            if (!string.IsNullOrEmpty(comboBox7.Text))
            {
                strWh = strWh + " AND BAR011='" + comboBox7.Text + "'";
            }
            if (!string.IsNullOrEmpty(comboBox8.Text))
            {
                strWh = strWh + " AND BAR012='" + comboBox8.Text + "'";
            }
            PassDataWinFormEventArgs args = new PassDataWinFormEventArgs(strWh);
            if (PassDataBetweenForm != null)
            {
                PassDataBetweenForm(this, args);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        //cancel
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        //Clear
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text =  comboBox7.Text = comboBox8.Text =  "";
        }

        private void comboBox1_GotFocus(object sender, EventArgs e)
        {
           
        }

        SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
        DataTable da;

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (da == null || da.Rows.Count < 1)
            {
                da = new DataTable();
                da = _bll.GetDataTableOfOnly();
                comboBox1.DataSource = da.DefaultView.ToTable(true, "BAR001");
                comboBox1.DisplayMember = "BAR001";
                comboBox2.DataSource = da.DefaultView.ToTable(true, "BAR006");
                comboBox2.DisplayMember = "BAR006";
                comboBox3.DataSource = da.DefaultView.ToTable(true, "BAR007");
                comboBox3.DisplayMember = "BAR007";
                comboBox4.DataSource = da.DefaultView.ToTable(true, "BAR008");
                comboBox4.DisplayMember = "BAR008";
                comboBox7.DataSource = da.DefaultView.ToTable(true, "BAR011");
                comboBox7.DisplayMember = "BAR011";               
            }

            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text =  comboBox7.Text = comboBox8.Text =  "";
        }

    }
}