namespace SmartDeviceProjectSweep
{
    partial class UserControlOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOkOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCanOr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOkOrder
            // 
            this.btnOkOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOkOrder.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnOkOrder.Location = new System.Drawing.Point(56, 31);
            this.btnOkOrder.Name = "btnOkOrder";
            this.btnOkOrder.Size = new System.Drawing.Size(57, 20);
            this.btnOkOrder.TabIndex = 1;
            this.btnOkOrder.Text = "确定";
            this.btnOkOrder.Click += new System.EventHandler(this.btnOkOrder_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.Text = "订单号";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBox1.Location = new System.Drawing.Point(56, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 22);
            this.comboBox1.TabIndex = 3;
            // 
            // btnCanOr
            // 
            this.btnCanOr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCanOr.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnCanOr.Location = new System.Drawing.Point(119, 31);
            this.btnCanOr.Name = "btnCanOr";
            this.btnCanOr.Size = new System.Drawing.Size(57, 20);
            this.btnCanOr.TabIndex = 5;
            this.btnCanOr.Text = "取消";
            // 
            // UserControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCanOr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkOrder);
            this.Name = "UserControlOrder";
            this.Size = new System.Drawing.Size(243, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnOkOrder;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button btnCanOr;
    }
}
