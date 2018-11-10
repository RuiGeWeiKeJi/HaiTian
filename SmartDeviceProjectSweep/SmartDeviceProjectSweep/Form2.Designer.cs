namespace SmartDeviceProjectSweep
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.tableAll = new System.Windows.Forms.DataGridTableStyle();
            this.BAR001 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR004 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR008 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.IBB001 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR007 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR020 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.userControlButton1 = new SmartDeviceProjectSweep.UserControlButton();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 56);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 154);
            this.dataGrid1.TabIndex = 2;
            this.dataGrid1.TableStyles.Add(this.tableAll);
            // 
            // tableAll
            // 
            this.tableAll.GridColumnStyles.Add(this.BAR001);
            this.tableAll.GridColumnStyles.Add(this.BAR004);
            this.tableAll.GridColumnStyles.Add(this.BAR008);
            this.tableAll.GridColumnStyles.Add(this.IBB001);
            this.tableAll.GridColumnStyles.Add(this.BAR007);
            this.tableAll.GridColumnStyles.Add(this.BAR020);
            // 
            // BAR001
            // 
            this.BAR001.Format = "";
            this.BAR001.HeaderText = "品号";
            this.BAR001.MappingName = "BAR001";
            this.BAR001.Width = 80;
            // 
            // BAR004
            // 
            this.BAR004.Format = "";
            this.BAR004.HeaderText = "品名";
            this.BAR004.MappingName = "BAR004";
            this.BAR004.Width = 80;
            // 
            // BAR008
            // 
            this.BAR008.Format = "";
            this.BAR008.HeaderText = "Lot ID";
            this.BAR008.MappingName = "BAR008";
            this.BAR008.Width = 180;
            // 
            // IBB001
            // 
            this.IBB001.Format = "";
            this.IBB001.HeaderText = "订单号";
            this.IBB001.MappingName = "IBB001";
            this.IBB001.Width = 150;
            // 
            // BAR007
            // 
            this.BAR007.Format = "";
            this.BAR007.HeaderText = "轴号";
            this.BAR007.MappingName = "BAR007";
            // 
            // BAR020
            // 
            this.BAR020.Format = "";
            this.BAR020.HeaderText = "出库数量";
            this.BAR020.MappingName = "BAR020";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(196, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 20);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "扫描";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // userControlButton1
            // 
            this.userControlButton1.BackColor = System.Drawing.Color.White;
            this.userControlButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControlButton1.Location = new System.Drawing.Point(0, 210);
            this.userControlButton1.Name = "userControlButton1";
            this.userControlButton1.Size = new System.Drawing.Size(240, 58);
            this.userControlButton1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.userControlButton1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form2";
            this.Text = "出库";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form2_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlButton userControlButton1;
        public System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridTableStyle tableAll;
        private System.Windows.Forms.DataGridTextBoxColumn BAR001;
        private System.Windows.Forms.DataGridTextBoxColumn BAR004;
        private System.Windows.Forms.DataGridTextBoxColumn BAR008;
        private System.Windows.Forms.DataGridTextBoxColumn IBB001;
        private System.Windows.Forms.DataGridTextBoxColumn BAR007;
        private System.Windows.Forms.DataGridTextBoxColumn BAR020;
        public System.Windows.Forms.Button btnAdd;



    }
}