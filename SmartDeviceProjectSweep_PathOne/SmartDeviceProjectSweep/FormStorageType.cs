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
    public partial class FormStorageType : Form
    {
        string storageChoise = "";
        public FormStorageType(string Choise)
        {
            InitializeComponent();

            this.storageChoise = Choise;
            SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
            comboBox1.DataSource = _bll.GetDataTableLaa(storageChoise);
            comboBox1.DisplayMember = "LAA002";
            comboBox1.ValueMember = "LAA001";
            comboBox2.DataSource = _bll.GetDataTabledba();
            comboBox2.DisplayMember = "DBA002";
            comboBox2.ValueMember = "DBA001";  
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Values.valueOne = comboBox1.SelectedValue.ToString();
            Values.valueTwo = comboBox2.SelectedValue.ToString();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}