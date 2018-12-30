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
    public partial class Form3 : Form
    {
        SmartDeviceProjectBll.Bll.ConnecBll _bll = null;
        string choiseCk = string.Empty;
        public Form3( string choiseCk )
        {
            InitializeComponent();

            _bll = new SmartDeviceProjectBll.Bll.ConnecBll();

            this.textBox3.Focus();
            
            //comboBox1.DataSource = _bll.GetDataTableLotId();
            //comboBox1.DisplayMember = "BAR007";
            //comboBox1.SelectedIndex = -1;

            comboBox2.DataSource = _bll.GetDataTableOfOrder();
            comboBox2.DisplayMember = "IBB001";
            comboBox2.SelectedIndex = -1;

            this.choiseCk = choiseCk;
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox3.Text.Length >= 13)
            //{

            //    comboBox1.Text = _bll.zh(textBox3.Text);
           

            //    this.textBox2.Select(0, 0);

            //    DataTable dt = _bll.GetDataTableLotId(textBox3.Text);
            //    if (dt != null && dt.Rows.Count > 0)
            //    {
            //        textBox1.Text = dt.Rows[0]["BAR008"].ToString();
            //    }
            //}
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboBox1.Text = _bll.zh(textBox3.Text);
                this.textBox2.Select(0, 0);
                DataTable dt = _bll.GetDataTableLotId(textBox3.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    textBox1.Text = dt.Rows[0]["BAR008"].ToString();
                }
            }
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //规格
            comboBox3.DataSource = _bll.lotidDt(comboBox1.Text);
            comboBox3.DisplayMember = "BAR004";
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            //lotid
            textBox1.Text = _bll.lotidDt(comboBox1.Text, comboBox3.Text);
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
        }

        string lotId = string.Empty;
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bool isOk = true;
            if (choiseCk == "1" && string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("请选择订单号");
                isOk = false;
                return;
            }
            else if (choiseCk == "2")
                comboBox2.SelectedIndex = -1;

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("请填写出库数量");
                isOk = false;
                return;
            }


            foreach (char c in textBox2.Text)
            {
                if (c < 48 || c > 57)
                {
                    MessageBox.Show("请输入整数");
                    isOk = false;
                    break;
                }
            }
            if (isOk == false)
                return;

            lotId = textBox1.Text;
            if (string.IsNullOrEmpty(lotId))
            {
                MessageBox.Show("请扫描或录入条码");
                isOk = false;
                return;
            }

            isOk = true;
            if (_bll.Exists(lotId) == true)
            {
                if (Convert.ToInt32(textBox2.Text) > _bll.lotNum(lotId))
                {
                    MessageBox.Show("剩余库存数量少于出库数量,请核实");
                    isOk = false;
                    return;
                }
                else
                {
                    if (choiseCk == "1" && _bll.Exists(comboBox2.Text, lotId) == false)
                    {
                        MessageBox.Show("流水" + lotId + "所属Lot Id不属于订单:" + comboBox2.Text + ",请核实");
                        isOk = false;
                        return;
                    }
                    else
                    {
                        isOk = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("流水:" + textBox3.Text + "\n\r所属Lot Id在条码记录表中不存在,或已经在扫描列表中尚未出库,或已经出库,请核实");
                isOk = false;
                return;
            }

            if (isOk)
                this.DialogResult = DialogResult.OK;
        }

        public string getLotId
        {
            get
            {
                return lotId;
            }
        }

        public string getNum
        {
            get
            {
                return textBox2.Text;
            }
        }

        public string getOrderNum
        {
            get
            {
                return comboBox2.Text;
            }
        }

    


    }
}