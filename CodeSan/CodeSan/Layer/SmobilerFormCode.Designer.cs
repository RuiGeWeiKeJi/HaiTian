using System;
using Smobiler . Core;
namespace CodeSan . Layer
{
    partial class SmobilerFormCode : SmobilerFormBaseBack
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnQuery = new Smobiler.Core.Controls.Button();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.txtQquery = new Smobiler.Core.Controls.TextBox();
            this.btnScan = new Smobiler.Core.Controls.BarcodeScannerButton();
            // 
            // label2
            // 
            this.label2.FontSize = 17F;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(83, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.Text = "条码记录表";
            // 
            // btnQuery
            // 
            this.btnQuery.BorderColor = System.Drawing.Color.Transparent;
            this.btnQuery.BorderRadius = 0;
            this.btnQuery.FontSize = 14F;
            this.btnQuery.Location = new System.Drawing.Point(246, 33);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(54, 30);
            this.btnQuery.Text = "查询";
            this.btnQuery.Press += new System.EventHandler(this.btnQuery_Press);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 70);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.Size = new System.Drawing.Size(300, 430);
            this.listView1.TemplateControlName = "SmobilerUserControlList";
            // 
            // txtQquery
            // 
            this.txtQquery.BackColor = System.Drawing.Color.LightGray;
            this.txtQquery.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtQquery.BorderColor = System.Drawing.Color.LightGray;
            this.txtQquery.FontSize = 14F;
            this.txtQquery.Location = new System.Drawing.Point(32, 33);
            this.txtQquery.Name = "txtQquery";
            this.txtQquery.Size = new System.Drawing.Size(214, 30);
            this.txtQquery.WaterMarkText = "请输入品号或轴号";
            // 
            // btnScan
            // 
            this.btnScan.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScan.FontSize = 14F;
            this.btnScan.Location = new System.Drawing.Point(0, 33);
            this.btnScan.Name = "btnScan";
            this.btnScan.ResourceID = "scan";
            this.btnScan.Size = new System.Drawing.Size(32, 30);
            this.btnScan.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.btnScan_BarcodeScanned);
            // 
            // SmobilerFormCode
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.btnQuery,
            this.listView1,
            this.txtQquery,
            this.btnScan});
            this.Name = "SmobilerFormCode";

        }
        #endregion
        private Smobiler . Core . Controls . Label label2;
        private Smobiler . Core . Controls . Button btnQuery;
        private Smobiler . Core . Controls . ListView listView1;
        private Smobiler . Core . Controls . TextBox txtQquery;
        private Smobiler . Core . Controls . BarcodeScannerButton btnScan;
    }
}