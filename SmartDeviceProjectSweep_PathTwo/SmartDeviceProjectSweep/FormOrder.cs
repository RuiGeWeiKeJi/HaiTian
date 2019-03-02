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
    public partial class FormOrder : Form
    {
        public FormOrder(string sign)
        {
            InitializeComponent();
            
            this.Controls.Clear();
            if (sign == "1")
            {
                UserControlOrder order = new UserControlOrder();
                this.Controls.Add(order);
                order.Dock = System.Windows.Forms.DockStyle.Top;
                order.btnOkOrder.Click+=new EventHandler(btnOkOrder_Click);
                order.btnCanOr.Click += new EventHandler(btnCanOr_Click);
            }
            else if (sign == "2")
            {
                UserControlBatch batch = new UserControlBatch();
                this.Controls.Add(batch);
                batch.Dock = System.Windows.Forms.DockStyle.Top;
                batch.btnOk.Click += new EventHandler(btnOk_Click);
                batch.btnCancel.Click += new EventHandler(btnCancel_Click);
            }
        }

        public string LotIdStart
        {
            get
            {
                UserControlBatch batch = new UserControlBatch();
                return batch.texStart.Text;
            }
        }
        public string LotIdEnd
        {
            get
            {
                UserControlBatch batch = new UserControlBatch();
                return batch.texEnd.Text;
            }
        }
        public string LotId
        {
            get {
                UserControlBatch batch = new UserControlBatch();
                return batch.comboBox1.Text;
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }




        public string orderGet
        {
            get
            {
                UserControlOrder order = new UserControlOrder();
                return order.comboBox1.Text;
            }
        }

        private void btnOkOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        void btnCanOr_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}