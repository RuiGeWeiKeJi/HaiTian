using System;
using Smobiler . Core;
namespace CodeSan . ControlForSmobiler
{
    partial class SmobilerUserControlSto : Smobiler . Core . Controls . MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose ( bool disposing )
        {
            base . Dispose ( disposing );
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System . Diagnostics . DebuggerStepThrough ( )]
        private void InitializeComponent ( )
        {
            this.labelTitle = new Smobiler.Core.Controls.Label();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnUser = new Smobiler.Core.Controls.Button();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnOk = new Smobiler.Core.Controls.Button();
            this.btnCan = new Smobiler.Core.Controls.Button();
            this.popListType = new Smobiler.Core.Controls.PopList();
            this.popListUser = new Smobiler.Core.Controls.PopList();
            this.txtType = new Smobiler.Core.Controls.TextBox();
            this.txtUser = new Smobiler.Core.Controls.TextBox();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.FontSize = 17F;
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labelTitle.Location = new System.Drawing.Point(94, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 28);
            this.labelTitle.Text = "出库";
            // 
            // btnType
            // 
            this.btnType.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnType.BorderColor = System.Drawing.Color.White;
            this.btnType.BorderRadius = 0;
            this.btnType.FontSize = 14F;
            this.btnType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnType.Location = new System.Drawing.Point(0, 35);
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
            this.btnUser.Location = new System.Drawing.Point(0, 68);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 33);
            this.btnUser.Text = "经办人";
            this.btnUser.Press += new System.EventHandler(this.btnUser_Press);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnOk,
            this.btnCan});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            // 
            // btnOk
            // 
            this.btnOk.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnOk.BorderColor = System.Drawing.Color.White;
            this.btnOk.BorderRadius = 0;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOk.FontSize = 16F;
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 40);
            this.btnOk.Text = "确定";
            this.btnOk.Press += new System.EventHandler(this.btnOk_Press);
            // 
            // btnCan
            // 
            this.btnCan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnCan.BorderColor = System.Drawing.Color.White;
            this.btnCan.BorderRadius = 0;
            this.btnCan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCan.FontSize = 16F;
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(100, 40);
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
            // txtType
            // 
            this.txtType.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtType.BorderColor = System.Drawing.Color.DarkGray;
            this.txtType.FontSize = 14F;
            this.txtType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtType.Location = new System.Drawing.Point(75, 35);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 35);
            // 
            // txtUser
            // 
            this.txtUser.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtUser.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUser.FontSize = 14F;
            this.txtUser.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtUser.Location = new System.Drawing.Point(75, 70);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(125, 31);
            // 
            // SmobilerUserControlSto
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListType,
            this.popListUser});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labelTitle,
            this.btnType,
            this.btnUser,
            this.panel1,
            this.txtType,
            this.txtUser});
            this.Size = new System.Drawing.Size(200, 150);
            this.Name = "SmobilerUserControlSto";

        }
        #endregion

        private Smobiler . Core . Controls . Label labelTitle;
        private Smobiler . Core . Controls . Button btnType;
        private Smobiler . Core . Controls . Button btnUser;
        private Smobiler . Core . Controls . Panel panel1;
        private Smobiler . Core . Controls . Button btnOk;
        private Smobiler . Core . Controls . Button btnCan;
        private Smobiler . Core . Controls . PopList popListType;
        private Smobiler . Core . Controls . PopList popListUser;
        private Smobiler . Core . Controls . TextBox txtType;
        private Smobiler . Core . Controls . TextBox txtUser;
    }
}