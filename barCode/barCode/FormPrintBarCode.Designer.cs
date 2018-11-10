namespace barCode
{
    partial class FormPrintBarCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.texProduct = new System.Windows.Forms.TextBox();
            this.texType = new System.Windows.Forms.TextBox();
            this.texSpec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.btnOnly = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spec.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "打印数量:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.Location = new System.Drawing.Point(107, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 23);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(201, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "打印";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lot ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "型号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "序号:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox2.Location = new System.Drawing.Point(160, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 23);
            this.textBox2.TabIndex = 14;
            // 
            // texProduct
            // 
            this.texProduct.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.texProduct.Location = new System.Drawing.Point(107, 12);
            this.texProduct.Name = "texProduct";
            this.texProduct.ReadOnly = true;
            this.texProduct.Size = new System.Drawing.Size(187, 23);
            this.texProduct.TabIndex = 15;
            // 
            // texType
            // 
            this.texType.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.texType.Location = new System.Drawing.Point(107, 46);
            this.texType.Name = "texType";
            this.texType.ReadOnly = true;
            this.texType.Size = new System.Drawing.Size(229, 23);
            this.texType.TabIndex = 16;
            // 
            // texSpec
            // 
            this.texSpec.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.texSpec.Location = new System.Drawing.Point(107, 80);
            this.texSpec.Name = "texSpec";
            this.texSpec.ReadOnly = true;
            this.texSpec.Size = new System.Drawing.Size(229, 23);
            this.texSpec.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "轴号:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 22);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Location = new System.Drawing.Point(300, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 24);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnOnly
            // 
            this.btnOnly.AutoSize = true;
            this.btnOnly.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOnly.ForeColor = System.Drawing.Color.Black;
            this.btnOnly.Location = new System.Drawing.Point(274, 207);
            this.btnOnly.Name = "btnOnly";
            this.btnOnly.Size = new System.Drawing.Size(62, 25);
            this.btnOnly.TabIndex = 23;
            this.btnOnly.Text = "只条码";
            this.btnOnly.UseVisualStyleBackColor = false;
            this.btnOnly.Click += new System.EventHandler(this.btnOnly_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox3.Location = new System.Drawing.Point(160, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 23);
            this.textBox3.TabIndex = 24;
            // 
            // FormPrintBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 237);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnOnly);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.texSpec);
            this.Controls.Add(this.texType);
            this.Controls.Add(this.texProduct);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormPrintBarCode";
            this.Text = "条码打印";
            this.Load += new System.EventHandler(this.FormPrintBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System . Windows . Forms . Label label1;
        private System . Windows . Forms . Label label2;
        private System . Windows . Forms . Label label3;
        private System . Windows . Forms . Label label5;
        private System . Windows . Forms . TextBox textBox1;
        private System . Windows . Forms . Button button1;
        private System . Windows . Forms . Label label4;
        private System . Windows . Forms . Label label6;
        private System . Windows . Forms . Label label7;
        private System . Windows . Forms . TextBox textBox2;
        private System . Windows . Forms . TextBox texProduct;
        private System . Windows . Forms . TextBox texType;
        private System . Windows . Forms . TextBox texSpec;
        private System . Windows . Forms . Label label9;
        private System . Windows . Forms . ComboBox comboBox1;
        private System . Windows . Forms . Button button2;
        private System . Windows . Forms . ErrorProvider errorProvider1;
        private System . Windows . Forms . Button btnOnly;
        private System . Windows . Forms . TextBox textBox3;
    }
}