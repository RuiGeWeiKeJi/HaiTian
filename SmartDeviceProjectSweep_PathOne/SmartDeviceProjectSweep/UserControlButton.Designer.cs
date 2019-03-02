namespace SmartDeviceProjectSweep
{
    partial class UserControlButton
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
            this.btnCAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnRerurn = new System.Windows.Forms.Button();
            this.labSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCAll
            // 
            this.btnCAll.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCAll.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnCAll.Location = new System.Drawing.Point(5, 28);
            this.btnCAll.Name = "btnCAll";
            this.btnCAll.Size = new System.Drawing.Size(50, 20);
            this.btnCAll.TabIndex = 3;
            this.btnCAll.Text = "清空";
            this.btnCAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(66, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 20);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "删除";
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStorage.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnStorage.Location = new System.Drawing.Point(127, 28);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(50, 20);
            this.btnStorage.TabIndex = 5;
            this.btnStorage.Text = "出库";
            this.btnStorage.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRerurn
            // 
            this.btnRerurn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRerurn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnRerurn.Location = new System.Drawing.Point(188, 28);
            this.btnRerurn.Name = "btnRerurn";
            this.btnRerurn.Size = new System.Drawing.Size(50, 20);
            this.btnRerurn.TabIndex = 6;
            this.btnRerurn.Text = "返回";
            this.btnRerurn.Click += new System.EventHandler(this.button4_Click);
            // 
            // labSum
            // 
            this.labSum.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labSum.Location = new System.Drawing.Point(5, 4);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(232, 20);
            this.labSum.Text = "无扫描记录";
            // 
            // UserControlButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.btnRerurn);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCAll);
            this.Name = "UserControlButton";
            this.Size = new System.Drawing.Size(240, 51);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnRerurn;
        public System.Windows.Forms.Button btnCAll;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnStorage;
        public System.Windows.Forms.Label labSum;

    }
}
