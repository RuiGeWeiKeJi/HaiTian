namespace Sweep
{
    partial class Form1
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
            this.btnStorge = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnconnec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStorge
            // 
            this.btnStorge.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStorge.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStorge.Location = new System.Drawing.Point(31, 60);
            this.btnStorge.Name = "btnStorge";
            this.btnStorge.Size = new System.Drawing.Size(170, 37);
            this.btnStorge.TabIndex = 0;
            this.btnStorge.Text = "出库";
            this.btnStorge.UseVisualStyleBackColor = false;
            this.btnStorge.Click += new System.EventHandler(this.btnStorge_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(31, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "条码数据查询表";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(126, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "退出系统";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnconnec
            // 
            this.btnconnec.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnconnec.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnconnec.Location = new System.Drawing.Point(31, 209);
            this.btnconnec.Name = "btnconnec";
            this.btnconnec.Size = new System.Drawing.Size(75, 37);
            this.btnconnec.TabIndex = 3;
            this.btnconnec.Text = "连接配置";
            this.btnconnec.UseVisualStyleBackColor = false;
            this.btnconnec.Click += new System.EventHandler(this.btnconnec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnconnec);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStorge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System . Windows . Forms . Button btnStorge;
        private System . Windows . Forms . Button button3;
        private System . Windows . Forms . Button button4;
        private System . Windows . Forms . Button btnconnec;
    }
}

