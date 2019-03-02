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
    public partial class Form2 : Form
    {
        string storageChois = "";
        public Form2(string storage)
        {
            InitializeComponent();

            userControlButton1.btnRerurn.Click+=new EventHandler(btnRerurn_Click);
            userControlButton1.btnClear.Click += new EventHandler(btnClear_Click);
            userControlButton1.btnCAll.Click+=new EventHandler(btnCAll_Click);
            userControlButton1.btnStorage.Click += new EventHandler(btnStorage_Click);
            this.storageChois = storage;
            //if (storageChois == "2")
            //{
            //    userControlLotID1.button1.Enabled = false;
            //}
            //else if (storageChois == "1")
            //{
            //    userControlLotID1.button1.Enabled = true;
            //}
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        DataTable tableQuery = new DataTable();

        private void btnRerurn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStorage_Click(object sender, EventArgs e)
        {
            if (tableQuery != null && tableQuery.Rows.Count > 0)
            {
                FormStorageType form = new FormStorageType(storageChois);
                DialogResult result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string storageType = Values.valueOne;
                    string storagePerson = Values.valueTwo;
                    SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
                    if (tableQuery.Rows.Count > 0)
                    {
                        if (storageChois == "2")
                        {
                            storageType = "13";
                            storageType = "14";
                        }
                        //if (SmartDeviceProjectBll.SeverState.CheckServeStatus() == false)
                        //    return;
                        bool resul = _bll.signOfStorage(tableQuery, storageType, storagePerson);
                        if (resul == true)
                        {
                            MessageBox.Show("成功出库");
                            this.dataGrid1.DataSource = null;
                            tableQuery = null;
                            signOfBatch = "";
                            userControlButton1.labSum.Text = "合计：0条记录";
                        }
                        else
                            MessageBox.Show("出库失败,请重试");
                    }
                }
            }
        }

        /// <summary>
        /// 删除所有内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCAll_Click(object sender, EventArgs e)
        {
            if (tableQuery != null && tableQuery.Rows.Count > 0)
            {
                SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
                _bll.signOfLi(tableQuery);
            }
            this.dataGrid1.DataSource = null;
            tableQuery = null;
        }
        
        /// <summary>
        /// 删除选中单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (tableQuery!=null && tableQuery.Rows.Count > 0)
            {
                int id = this.BindingContext[this.dataGrid1.DataSource].Position;
                if (id >= 0)
                {
                    SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
                    string lotId = tableQuery.Rows[id]["BAR008"].ToString();
                    _bll.signOfLiF(lotId);
                    tableQuery.Rows.RemoveAt(id);
                    this.dataGrid1.DataSource = tableQuery;
                }
            }
        }

        
        /// <summary>
        /// 选择订单号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //FormOrder query = new FormOrder("1");
            //query.Text = "订单选择";
            //DialogResult result = query.ShowDialog();
            //if (result == System.Windows.Forms.DialogResult.OK)
            //{
            //    //userControlLotID1.textBox1.Tag = query.orderGet;
            //    orderNum = Values.valueOne;
            //}
        }

        /// <summary>
        /// 批量出库操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormOrder query = new FormOrder("2");
            query.Text = "批量出库操作";
            DialogResult result = query.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //LotId = query.LotId;
                LotId = Values.valueOne;
                //StartLotId = query.LotIdStart;
                StartLotId = Values.valueTwo;
                //EndLotId = query.LotIdEnd;
                EndLotId = Values.valueTre;
                signOfBatch = "batch";
            }
        }

        string LotId = "", StartLotId = "", EndLotId = "", signOfBatch = "";
        string privousLotId = "";
        /// <summary>
        /// 添加LotId到列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Closing(object sender, CancelEventArgs e)
        {
             
            if (tableQuery!=null && tableQuery.Rows.Count > 0)
            {
                SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();
                _bll.signOfLi(tableQuery);
            }
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {

        }

        //添加
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Form3 from = new Form3(storageChois);
            if (from.ShowDialog() == DialogResult.OK)
            {
                SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();

                string lotId = from.getLotId;
                string orderNum = from.getOrderNum;
                string ckNum = from.getNum;
                if (tableQuery == null || tableQuery.Rows.Count < 1)
                {
                    tableQuery = _bll.GetDataTableOfLot(lotId);
                    if (tableQuery.Rows.Count > 0)
                    {
                        tableQuery.Columns.Add("IBB001", typeof(System.String));
                        tableQuery.Rows[0][5] = orderNum;
                        tableQuery.Rows[0][4] = ckNum;
                    }
                }
                else
                {
                    DataTable da = new DataTable();
                    da = _bll.GetDataTableOfLot(lotId);
                    if (da != null && da.Rows.Count > 0)
                    {
                        tableQuery.Rows.Add(da.Rows[0]["BAR001"].ToString(), da.Rows[0]["BAR004"].ToString(), da.Rows[0]["BAR008"].ToString(), da.Rows[0]["BAR007"].ToString(), ckNum, orderNum);
                    }
                }

                dataGrid1.DataSource = tableQuery;
                this.userControlButton1.labSum.Text = "合计：" + tableQuery.Rows.Count + " 条记录";
                _bll.signOfLi(lotId);
            }         
        }


    }
}