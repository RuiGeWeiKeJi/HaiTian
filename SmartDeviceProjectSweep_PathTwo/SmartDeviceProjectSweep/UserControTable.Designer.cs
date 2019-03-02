namespace SmartDeviceProjectSweep
{
    partial class UserControTable
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.tableQuery = new System.Windows.Forms.DataGridTableStyle();
            this.IBB001 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR001 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR004 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR008 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.BAR007 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGrid1.Size = new System.Drawing.Size(240, 227);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.TableStyles.Add(this.tableQuery);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // tableQuery
            // 
            this.tableQuery.GridColumnStyles.Add(this.IBB001);
            this.tableQuery.GridColumnStyles.Add(this.BAR001);
            this.tableQuery.GridColumnStyles.Add(this.BAR004);
            this.tableQuery.GridColumnStyles.Add(this.BAR008);
            this.tableQuery.GridColumnStyles.Add(this.BAR007);
            this.tableQuery.MappingName = "tableQuery";
            // 
            // IBB001
            // 
            this.IBB001.Format = "";
            this.IBB001.FormatInfo = null;
            this.IBB001.HeaderText = "订单号";
            this.IBB001.MappingName = "IBB001";
            // 
            // BAR001
            // 
            this.BAR001.Format = "";
            this.BAR001.FormatInfo = null;
            this.BAR001.HeaderText = "品号";
            this.BAR001.MappingName = "BAR001";
            // 
            // BAR004
            // 
            this.BAR004.Format = "";
            this.BAR004.FormatInfo = null;
            this.BAR004.HeaderText = "规格";
            this.BAR004.MappingName = "BAR004";
            // 
            // BAR008
            // 
            this.BAR008.Format = "";
            this.BAR008.FormatInfo = null;
            this.BAR008.HeaderText = "Lot ID";
            this.BAR008.MappingName = "BAR008";
            // 
            // BAR007
            // 
            this.BAR007.Format = "";
            this.BAR007.FormatInfo = null;
            this.BAR007.HeaderText = "轴号";
            this.BAR007.MappingName = "BAR007";
            // 
            // UserControTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dataGrid1);
            this.Name = "UserControTable";
            this.Size = new System.Drawing.Size(240, 227);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridTableStyle tableQuery;
        private System.Windows.Forms.DataGridTextBoxColumn IBB001;
        private System.Windows.Forms.DataGridTextBoxColumn BAR001;
        private System.Windows.Forms.DataGridTextBoxColumn BAR004;
        private System.Windows.Forms.DataGridTextBoxColumn BAR008;
        private System.Windows.Forms.DataGridTextBoxColumn BAR007;

    }
}
