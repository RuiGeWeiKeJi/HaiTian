namespace barCode
{
    partial class FormBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barTool = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTool = new System.Windows.Forms.ToolStripMenuItem();
            this.连接库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connTool = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1231, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1216, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "杭州瑞格微科技有限公司      Tel：(0571) 8696 1522    E_mail：my_rgw@163.com       ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打印ToolStripMenuItem,
            this.报表ToolStripMenuItem,
            this.连接库ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barTool});
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // barTool
            // 
            this.barTool.Name = "barTool";
            this.barTool.Size = new System.Drawing.Size(134, 22);
            this.barTool.Text = "条码打印";
            this.barTool.Click += new System.EventHandler(this.barTool_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportTool});
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // reportTool
            // 
            this.reportTool.Name = "reportTool";
            this.reportTool.Size = new System.Drawing.Size(179, 22);
            this.reportTool.Text = "条码记录数据表";
            this.reportTool.Click += new System.EventHandler(this.reportTool_Click);
            // 
            // 连接库ToolStripMenuItem
            // 
            this.连接库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connTool});
            this.连接库ToolStripMenuItem.Name = "连接库ToolStripMenuItem";
            this.连接库ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.连接库ToolStripMenuItem.Text = "连接";
            // 
            // connTool
            // 
            this.connTool.Name = "connTool";
            this.connTool.Size = new System.Drawing.Size(179, 22);
            this.connTool.Text = "数据库连接设置";
            this.connTool.Click += new System.EventHandler(this.connTool_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::barCode.Properties.Resources.HaiTian;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1231, 478);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBase";
            this.Text = "杭州华大海天科技有限公司";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System . Windows . Forms . StatusStrip statusStrip1;
        private System . Windows . Forms . MenuStrip menuStrip1;
        private System . Windows . Forms . ToolStripMenuItem 打印ToolStripMenuItem;
        private System . Windows . Forms . ToolStripMenuItem barTool;
        private System . Windows . Forms . ToolStripMenuItem 报表ToolStripMenuItem;
        private System . Windows . Forms . ToolStripMenuItem reportTool;
        private System . Windows . Forms . ToolStripStatusLabel toolStripStatusLabel1;
        private System . Windows . Forms . ToolStripMenuItem 连接库ToolStripMenuItem;
        private System . Windows . Forms . ToolStripMenuItem connTool;
    }
}

