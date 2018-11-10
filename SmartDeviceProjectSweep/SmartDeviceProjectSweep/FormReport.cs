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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();

            userControlReport1.button1.Click += new EventHandler(button1_Click);
            userControlReport1.button2.Click += new EventHandler(button2_Click);
        }

        string strWhere = "1=1";
        private void button1_Click(object sender, EventArgs e)
        {
            FormReportQuery query = new FormReportQuery();
            query.PassDataBetweenForm+=new FormReportQuery.PassDataBetweenFormHandler(query_PassDataBetweenForm);
            DialogResult result = query.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(strWhere))
                {
                    SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
                    DataTable tableQuery = _bll.GetDataTableOfAll(strWhere);
                    dataGrid1.DataSource = tableQuery;
                }
            }
        }
        private void query_PassDataBetweenForm(object sender, PassDataWinFormEventArgs e)
        {
            strWhere = e.StrW;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}