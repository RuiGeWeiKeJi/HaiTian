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
    public partial class UserControlOrder : UserControl
    {
        public UserControlOrder()
        {
            InitializeComponent();

            SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
            comboBox1.DataSource = _bll.GetDataTableOfOrder();
            comboBox1.DisplayMember = "IBB001";
        }

        private void btnOkOrder_Click(object sender, EventArgs e)
        {
            Values.valueOne = comboBox1.Text;
        }
    }
}
