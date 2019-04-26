using System;
using Smobiler . Core;
namespace CodeSan . Layer
{
    partial class SmobilerFormStoPro : SmobilerFormBaseBack
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
            this.labType = new Smobiler.Core.Controls.Label();
            this.labUser = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnOk = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.btnCan = new Smobiler.Core.Controls.Button();
            this.popListType = new Smobiler.Core.Controls.PopList();
            this.popListUser = new Smobiler.Core.Controls.PopList();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnUser = new Smobiler.Core.Controls.Button();
            // 
            // label1
            // 
            this.label1.FontSize = 17F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.Text = "出库";
            // 
            // labType
            // 
            this.labType.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labType.BorderColor = System.Drawing.Color.DarkGray;
            this.labType.FontSize = 14F;
            this.labType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.labType.Location = new System.Drawing.Point(75, 28);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(225, 33);
            // 
            // labUser
            // 
            this.labUser.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labUser.BorderColor = System.Drawing.Color.DarkGray;
            this.labUser.FontSize = 14F;
            this.labUser.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.labUser.Location = new System.Drawing.Point(75, 61);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(225, 33);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnOk,
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            // 
            // btnOk
            // 
            this.btnOk.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnOk.BorderColor = System.Drawing.Color.White;
            this.btnOk.BorderRadius = 0;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOk.FontSize = 16F;
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 40);
            this.btnOk.Text = "确定";
            this.btnOk.Press += new System.EventHandler(this.btnOk_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCan});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            // 
            // btnCan
            // 
            this.btnCan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnCan.BorderColor = System.Drawing.Color.White;
            this.btnCan.BorderRadius = 0;
            this.btnCan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCan.FontSize = 16F;
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(150, 40);
            this.btnCan.Text = "取消";
            this.btnCan.Press += new System.EventHandler(this.btnCan_Press);
            // 
            // popListType
            // 
            this.popListType.ItemFontSize = 14;
            this.popListType.Name = "popListType";
            this.popListType.Title = "出库类型";
            this.popListType.Selected += new System.EventHandler(this.popListType_Selected);
            // 
            // popListUser
            // 
            this.popListUser.ItemFontSize = 14;
            this.popListUser.Name = "popListUser";
            this.popListUser.Title = "经办人";
            this.popListUser.Selected += new System.EventHandler(this.popListUser_Selected);
            // 
            // btnType
            // 
            this.btnType.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnType.BorderColor = System.Drawing.Color.White;
            this.btnType.BorderRadius = 0;
            this.btnType.FontSize = 14F;
            this.btnType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnType.Location = new System.Drawing.Point(0, 28);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 33);
            this.btnType.Text = "出库类型";
            this.btnType.Press += new System.EventHandler(this.btnType_Press);
            // 
            // btnUser
            // 
            this.btnUser.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnUser.BorderColor = System.Drawing.Color.White;
            this.btnUser.BorderRadius = 0;
            this.btnUser.FontSize = 14F;
            this.btnUser.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnUser.Location = new System.Drawing.Point(0, 61);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 33);
            this.btnUser.Text = "经办人";
            this.btnUser.Press += new System.EventHandler(this.btnUser_Press);
            // 
            // SmobilerFormStoPro
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListType,
            this.popListUser});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.labType,
            this.labUser,
            this.panel1,
            this.btnType,
            this.btnUser});
            this.Size = new System.Drawing.Size(300, 200);
            this.Name = "SmobilerFormStoPro";

        }
        #endregion

        private Smobiler . Core . Controls . Label label1;
        private Smobiler . Core . Controls . Label labType;
        private Smobiler . Core . Controls . Label labUser;
        private Smobiler . Core . Controls . Panel panel1;
        private Smobiler . Core . Controls . Button btnOk;
        private Smobiler . Core . Controls . Panel panel2;
        private Smobiler . Core . Controls . Button btnCan;
        private Smobiler . Core . Controls . PopList popListType;
        private Smobiler . Core . Controls . PopList popListUser;
        private Smobiler . Core . Controls . Button btnType;
        private Smobiler . Core . Controls . Button btnUser;
    }
}