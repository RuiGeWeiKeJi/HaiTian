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
    public partial class UserControlButton : UserControl
    {
        public UserControlButton()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form2 form = new Form2();
            //form.Close();
        }

        //Clear one
        private void button2_Click ( object sender, EventArgs e )
        {
            //UserControTable usTable=new UserControTable ( );
            //UserControlLotID lotId = new UserControlLotID();
            //if ( usTable.dataGrid1.CurrentRowIndex > 0 )
            //{
            //    BindingManagerBase bm = usTable.dataGrid1.BindingContext[usTable.dataGrid1.DataSource];
            //    DataRow row = ((DataRowView)bm.Current).Row;
            //    lotId.tableQuery.Rows.Remove(row);
            //}
        }

        //Clear All
        private void button1_Click ( object sender, EventArgs e )
        {
            //UserControTable usTable=new UserControTable ( );
            //UserControlLotID lotId=new UserControlLotID ( );
            //if ( MessageBox.Show ( "全部清除?", "清除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 0 ) == DialogResult.OK )
            //{
            //    usTable.dataGrid1.DataSource = null;
            //    lotId.tableQuery = null;
            //}
        }

        //Storage
        private void button3_Click(object sender, EventArgs e)
        {
            //UserControlLotID lotId=new UserControlLotID ( );
            //SmartDeviceProjectBll.Bll.ConnecBll _bll=new SmartDeviceProjectBll.Bll.ConnecBll();
            //if (lotId.tableQuery.Rows.Count > 0)
            //{
            //    bool result = _bll.signOfStorage(lotId.tableQuery);
            //    if (result == true)
            //        MessageBox.Show("成功出库");
            //    else 
            //        MessageBox.Show("出库失败,请重试");
            //}
        }


    }
}
