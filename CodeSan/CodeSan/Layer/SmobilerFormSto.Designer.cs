using System;
using Smobiler . Core;
namespace CodeSan . Layer
{
    partial class SmobilerFormSto : SmobilerFormBaseBack
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
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            this.labelTitle = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtCode = new Smobiler.Core.Controls.TextBox();
            this.btnScan = new Smobiler.Core.Controls.BarcodeScannerButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txtBAR008 = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.txtBAR007 = new Smobiler.Core.Controls.TextBox();
            this.txtBRA020 = new Smobiler.Core.Controls.TextBox();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnSure = new Smobiler.Core.Controls.Button();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.txtBAR004 = new Smobiler.Core.Controls.TextBox();
            this.popListOne = new Smobiler.Core.Controls.PopList();
            this.txtOrder = new Smobiler.Core.Controls.TextBox();
            this.btnOrder = new Smobiler.Core.Controls.Button();
            // 
            // labelTitle
            // 
            this.labelTitle.FontSize = 17F;
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labelTitle.Location = new System.Drawing.Point(94, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 28);
            this.labelTitle.Text = "出库";
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.DarkGray;
            this.label2.FontSize = 14F;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 35);
            this.label2.Text = "条码 ";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtCode.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCode.FontSize = 14F;
            this.txtCode.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtCode.Location = new System.Drawing.Point(49, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(199, 35);
            // 
            // btnScan
            // 
            this.btnScan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnScan.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScan.FontSize = 14F;
            this.btnScan.Location = new System.Drawing.Point(248, 33);
            this.btnScan.Name = "btnScan";
            this.btnScan.ResourceID = "scan";
            this.btnScan.Size = new System.Drawing.Size(52, 30);
            this.btnScan.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.btnScan_BarcodeScanned);
            // 
            // label3
            // 
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.DarkGray;
            this.label3.FontSize = 14F;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(0, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 35);
            this.label3.Text = "Lot ID ";
            // 
            // txtBAR008
            // 
            this.txtBAR008.BackColor = System.Drawing.Color.Transparent;
            this.txtBAR008.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtBAR008.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBAR008.FontSize = 14F;
            this.txtBAR008.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBAR008.Location = new System.Drawing.Point(49, 63);
            this.txtBAR008.Name = "txtBAR008";
            this.txtBAR008.Size = new System.Drawing.Size(251, 35);
            // 
            // label4
            // 
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.BorderColor = System.Drawing.Color.DarkGray;
            this.label4.FontSize = 14F;
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(0, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 35);
            this.label4.Text = "规格 ";
            // 
            // label5
            // 
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label5.BorderColor = System.Drawing.Color.DarkGray;
            this.label5.FontSize = 14F;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label5.Location = new System.Drawing.Point(0, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 35);
            this.label5.Text = "轴号 ";
            // 
            // label6
            // 
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.DarkGray;
            this.label6.FontSize = 14F;
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label6.Location = new System.Drawing.Point(0, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 35);
            this.label6.Text = "数量 ";
            // 
            // txtBAR007
            // 
            this.txtBAR007.BackColor = System.Drawing.Color.Transparent;
            this.txtBAR007.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtBAR007.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBAR007.FontSize = 14F;
            this.txtBAR007.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBAR007.Location = new System.Drawing.Point(49, 133);
            this.txtBAR007.Name = "txtBAR007";
            this.txtBAR007.Size = new System.Drawing.Size(251, 35);
            // 
            // txtBRA020
            // 
            this.txtBRA020.BackColor = System.Drawing.Color.Transparent;
            this.txtBRA020.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtBRA020.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBRA020.FontSize = 14F;
            this.txtBRA020.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBRA020.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtBRA020.Location = new System.Drawing.Point(49, 168);
            this.txtBRA020.Name = "txtBRA020";
            this.txtBRA020.Size = new System.Drawing.Size(251, 35);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSure,
            this.btnCancel});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(27, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            // 
            // btnSure
            // 
            this.btnSure.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnSure.BorderColor = System.Drawing.Color.White;
            this.btnSure.BorderRadius = 0;
            this.btnSure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSure.FontSize = 16F;
            this.btnSure.Location = new System.Drawing.Point(29, 7);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(150, 40);
            this.btnSure.Text = "确定";
            this.btnSure.Press += new System.EventHandler(this.btnSure_Press);
            // 
            // btnCancel
            // 
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(1F, 0F, 0F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FontSize = 16F;
            this.btnCancel.Location = new System.Drawing.Point(147, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // txtBAR004
            // 
            this.txtBAR004.BackColor = System.Drawing.Color.Transparent;
            this.txtBAR004.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtBAR004.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBAR004.FontSize = 14F;
            this.txtBAR004.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBAR004.Location = new System.Drawing.Point(49, 98);
            this.txtBAR004.Name = "txtBAR004";
            this.txtBAR004.Size = new System.Drawing.Size(251, 35);
            // 
            // popListOne
            // 
            popListItem1.FontSize = 14F;
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "张三";
            popListItem1.Value = "10";
            popListItem2.FontSize = 14F;
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "李四";
            popListItem2.Value = "20";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2});
            popListGroup1.Value = null;
            this.popListOne.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popListOne.ItemFontSize = 14;
            this.popListOne.Name = "popListOne";
            this.popListOne.Title = "订单号";
            this.popListOne.Selected += new System.EventHandler(this.popListOne_Selected);
            // 
            // txtOrder
            // 
            this.txtOrder.BackColor = System.Drawing.Color.Transparent;
            this.txtOrder.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtOrder.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOrder.FontSize = 14F;
            this.txtOrder.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtOrder.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtOrder.Location = new System.Drawing.Point(49, 203);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(251, 35);
            // 
            // btnOrder
            // 
            this.btnOrder.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnOrder.BorderColor = System.Drawing.Color.White;
            this.btnOrder.BorderRadius = 0;
            this.btnOrder.FontSize = 16F;
            this.btnOrder.Location = new System.Drawing.Point(0, 203);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(49, 35);
            this.btnOrder.Text = "订单号";
            this.btnOrder.Press += new System.EventHandler(this.btnOrder_Press);
            // 
            // SmobilerFormSto
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListOne});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labelTitle,
            this.label2,
            this.txtCode,
            this.btnScan,
            this.label3,
            this.txtBAR008,
            this.label4,
            this.label5,
            this.label6,
            this.txtBAR007,
            this.txtBRA020,
            this.panel1,
            this.txtBAR004,
            this.txtOrder,
            this.btnOrder});
            this.Name = "SmobilerFormSto";

        }
        #endregion

        private Smobiler . Core . Controls . Label labelTitle;
        private Smobiler . Core . Controls . Label label2;
        private Smobiler . Core . Controls . TextBox txtCode;
        private Smobiler . Core . Controls . BarcodeScannerButton btnScan;
        private Smobiler . Core . Controls . Label label3;
        private Smobiler . Core . Controls . TextBox txtBAR008;
        private Smobiler . Core . Controls . Label label4;
        private Smobiler . Core . Controls . Label label5;
        private Smobiler . Core . Controls . Label label6;
        private Smobiler . Core . Controls . TextBox txtBAR007;
        private Smobiler . Core . Controls . TextBox txtBRA020;
        private Smobiler . Core . Controls . Panel panel1;
        private Smobiler . Core . Controls . Button btnSure;
        private Smobiler . Core . Controls . Button btnCancel;
        private Smobiler . Core . Controls . TextBox txtBAR004;
        private Smobiler . Core . Controls . PopList popListOne;
        private Smobiler . Core . Controls . TextBox txtOrder;
        private Smobiler . Core . Controls . Button btnOrder;
    }
}