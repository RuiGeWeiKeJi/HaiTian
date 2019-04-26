using System;
using Smobiler . Core;
using CodeSan . Layer;

namespace CodeSan
{
    partial class SmobilerFormCon : SmobilerFormBaseBack
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose ( bool disposing )
        {
            base . Dispose ( disposing );
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System . Diagnostics . DebuggerStepThrough ( )]
        private void InitializeComponent ( )
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtIp = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.txtPass = new Smobiler.Core.Controls.TextBox();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.btnOk = new Smobiler.Core.Controls.Button();
            this.btnTest = new Smobiler.Core.Controls.Button();
            this.txtStu = new Smobiler.Core.Controls.TextBox();
            this.popListOne = new Smobiler.Core.Controls.PopList();
            this.btnChoise = new Smobiler.Core.Controls.Button();
            // 
            // label1
            // 
            this.label1.FontSize = 17F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.Text = "连接配置";
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.label2.FontSize = 14F;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.Text = "服务器地址：";
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.Transparent;
            this.txtIp.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtIp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtIp.FontSize = 14F;
            this.txtIp.ForeColor = System.Drawing.Color.Gray;
            this.txtIp.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtIp.Location = new System.Drawing.Point(119, 51);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(162, 27);
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.label3.FontSize = 14F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.label4.FontSize = 14F;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(25, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtName.FontSize = 14F;
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.KeyboardType = Smobiler.Core.Controls.KeyboardType.EmailAddress;
            this.txtName.Location = new System.Drawing.Point(119, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 27);
            this.txtName.Text = "sa";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtPass.FontSize = 14F;
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(119, 141);
            this.txtPass.Name = "txtPass";
            this.txtPass.SecurityMode = true;
            this.txtPass.Size = new System.Drawing.Size(162, 27);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnOk,
            this.btnTest});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            // 
            // btnOk
            // 
            this.btnOk.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnOk.BorderColor = System.Drawing.Color.White;
            this.btnOk.BorderRadius = 0;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOk.FontSize = 16F;
            this.btnOk.Location = new System.Drawing.Point(0, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 40);
            this.btnOk.Text = "确定";
            this.btnOk.Press += new System.EventHandler(this.btnOk_Press);
            // 
            // btnTest
            // 
            this.btnTest.Border = new Smobiler.Core.Controls.Border(1F, 0F, 0F, 0F);
            this.btnTest.BorderColor = System.Drawing.Color.White;
            this.btnTest.BorderRadius = 0;
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTest.FontSize = 16F;
            this.btnTest.Location = new System.Drawing.Point(150, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 40);
            this.btnTest.Text = "测试连接";
            this.btnTest.Press += new System.EventHandler(this.btnTest_Press);
            // 
            // txtStu
            // 
            this.txtStu.BackColor = System.Drawing.Color.Transparent;
            this.txtStu.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtStu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtStu.FontSize = 14F;
            this.txtStu.ForeColor = System.Drawing.Color.Gray;
            this.txtStu.Location = new System.Drawing.Point(119, 189);
            this.txtStu.Name = "txtStu";
            this.txtStu.Size = new System.Drawing.Size(162, 27);
            this.txtStu.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // popListOne
            // 
            this.popListOne.Name = "popListOne";
            this.popListOne.Title = "请选择生产库";
            this.popListOne.Selected += new System.EventHandler(this.popListOne_Selected);
            // 
            // btnChoise
            // 
            this.btnChoise.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnChoise.BorderColor = System.Drawing.Color.White;
            this.btnChoise.BorderRadius = 0;
            this.btnChoise.FontSize = 16F;
            this.btnChoise.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnChoise.Location = new System.Drawing.Point(23, 189);
            this.btnChoise.Name = "btnChoise";
            this.btnChoise.Size = new System.Drawing.Size(92, 27);
            this.btnChoise.Text = "库选择:";
            this.btnChoise.Press += new System.EventHandler(this.btnChoise_Press);
            // 
            // SmobilerFormCon
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListOne});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.txtIp,
            this.label3,
            this.label4,
            this.txtName,
            this.txtPass,
            this.panel2,
            this.txtStu,
            this.btnChoise});
            this.Name = "SmobilerFormCon";

        }
        #endregion

        private Smobiler . Core . Controls . Label label1;
        private Smobiler . Core . Controls . Label label2;
        private Smobiler . Core . Controls . TextBox txtIp;
        private Smobiler . Core . Controls . Label label3;
        private Smobiler . Core . Controls . Label label4;
        private Smobiler . Core . Controls . TextBox txtName;
        private Smobiler . Core . Controls . TextBox txtPass;
        private Smobiler . Core . Controls . Panel panel2;
        private Smobiler . Core . Controls . Button btnOk;
        private Smobiler . Core . Controls . Button btnTest;
        private Smobiler . Core . Controls . TextBox txtStu;
        private Smobiler . Core . Controls . PopList popListOne;
        private Smobiler . Core . Controls . Button btnChoise;
    }
}