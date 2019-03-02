using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProjectSweep
{
    public partial class UserControlBatch : UserControl
    {
        public UserControlBatch()
        {
            InitializeComponent();

            SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
            comboBox1.DataSource = _bll.GetDataTableLotId();
            comboBox1.DisplayMember = "BAR007";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Values.valueOne = comboBox1.Text;
            Values.valueTwo = texStart.Text;
            Values.valueTre = texEnd.Text;
        }
    }
}
