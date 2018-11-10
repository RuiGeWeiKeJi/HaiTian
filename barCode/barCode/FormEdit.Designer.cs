namespace barCode
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbSao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtTime = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.richBatch = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(59, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(160, 67);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(361, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(459, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(29, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "订单单号：";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(117, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 23);
            this.textBox1.TabIndex = 15;
            // 
            // cmbSao
            // 
            this.cmbSao.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbSao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSao.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSao.FormattingEnabled = true;
            this.cmbSao.Location = new System.Drawing.Point(372, 6);
            this.cmbSao.Name = "cmbSao";
            this.cmbSao.Size = new System.Drawing.Size(161, 22);
            this.cmbSao.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(284, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "扫描标记：";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(372, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 23);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(117, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 23);
            this.textBox5.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(284, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "入库数量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(29, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "出库数量：";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "生产日期:";
            // 
            // dtTime
            // 
            this.dtTime.EditValue = null;
            this.dtTime.Location = new System.Drawing.Point(118, 92);
            this.dtTime.Name = "dtTime";
            this.dtTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTime.Size = new System.Drawing.Size(160, 20);
            this.dtTime.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(284, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "批号说明:";
            // 
            // richBatch
            // 
            this.richBatch.Location = new System.Drawing.Point(372, 132);
            this.richBatch.Name = "richBatch";
            this.richBatch.Size = new System.Drawing.Size(160, 67);
            this.richBatch.TabIndex = 27;
            this.richBatch.Text = "";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 260);
            this.Controls.Add(this.richBatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEdit";
            this.Text = "编辑";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System . Windows . Forms . Label label5;
        private System . Windows . Forms . Button button1;
        private System . Windows . Forms . Button button2;
        private System . Windows . Forms . Label label6;
        private System . Windows . Forms . RichTextBox richTextBox1;
        private System . Windows . Forms . TextBox textBox1;
        private System . Windows . Forms . ComboBox cmbSao;
        private System . Windows . Forms . Label label7;
        private System . Windows . Forms . TextBox textBox4;
        private System . Windows . Forms . TextBox textBox5;
        private System . Windows . Forms . Label label8;
        private System . Windows . Forms . Label label9;
        private System . Windows . Forms . ErrorProvider errorProvider1;
        private System . Windows . Forms . Label label1;
        private DevExpress . XtraEditors . DateEdit dtTime;
        private System . Windows . Forms . Label label2;
        private System . Windows . Forms . RichTextBox richBatch;
    }
}