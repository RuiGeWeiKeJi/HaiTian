using System;
using Smobiler . Core;
namespace CodeSan
{
    partial class SmobilerFormMain : SmobilerFormBase
    {
        #region "SmobilerForm generated code "

        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System . Diagnostics . DebuggerStepThrough ( )]
        private void InitializeComponent ( )
        {
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup1 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem1 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem2 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem3 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup2 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem4 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem5 = new Smobiler.Core.Controls.IconMenuViewItem();
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // iconMenuView1
            // 
            this.iconMenuView1.ColumnNum = 3;
            this.iconMenuView1.Dock = System.Windows.Forms.DockStyle.Fill;
            iconMenuViewGroup1.IconBorderRadius = 0;
            iconMenuViewItem1.Icon = "chuku";
            iconMenuViewItem1.ID = "ChuKu";
            iconMenuViewItem1.Text = "出库";
            iconMenuViewItem2.Icon = "ChuKuOther";
            iconMenuViewItem2.ID = "OtherChuKu";
            iconMenuViewItem2.Text = "其它出库";
            iconMenuViewItem3.Icon = "Barcode";
            iconMenuViewItem3.ID = "Barcode";
            iconMenuViewItem3.Text = "条码记录";
            iconMenuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem1,
            iconMenuViewItem2,
            iconMenuViewItem3});
            iconMenuViewGroup2.IconBorderRadius = 0;
            iconMenuViewItem4.Icon = "conn";
            iconMenuViewItem4.ID = "conn";
            iconMenuViewItem4.Text = "连接配置";
            iconMenuViewItem5.Icon = "zhanghuxinxi";
            iconMenuViewItem5.ID = "zhanghuxinxi";
            iconMenuViewItem5.Text = "关于";
            iconMenuViewGroup2.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem4,
            iconMenuViewItem5});
            this.iconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup1,
            iconMenuViewGroup2});
            this.iconMenuView1.Location = new System.Drawing.Point(0, 33);
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.ShowGroupTitle = true;
            this.iconMenuView1.Size = new System.Drawing.Size(300, 300);
            this.iconMenuView1.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // label1
            // 
            this.label1.FontSize = 17F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.Text = "杭州华大海天科技有限公司";
            // 
            // SmobilerFormMain
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuView1,
            this.label1});
            this.Load += new System.EventHandler(this.SmobilerFormMain_Load);
            this.Name = "SmobilerFormMain";

        }
        #endregion

        private Smobiler . Core . Controls . IconMenuView iconMenuView1;
        private Smobiler . Core . Controls . Label label1;
    }
}