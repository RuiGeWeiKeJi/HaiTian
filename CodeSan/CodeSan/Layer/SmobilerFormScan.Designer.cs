using System;
using Smobiler . Core;
namespace CodeSan . Layer
{
    partial class SmobilerFormScan : SmobilerFormBaseBack
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
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn1 = new Smobiler.Core.Controls.TableViewButtonColumn();
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn2 = new Smobiler.Core.Controls.TableViewButtonColumn();
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn3 = new Smobiler.Core.Controls.TableViewButtonColumn();
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn4 = new Smobiler.Core.Controls.TableViewButtonColumn();
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn5 = new Smobiler.Core.Controls.TableViewButtonColumn();
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn6 = new Smobiler.Core.Controls.TableViewButtonColumn();
            this.labelTitle = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnScan = new Smobiler.Core.Controls.Button();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnClear = new Smobiler.Core.Controls.Button();
            this.btnDel = new Smobiler.Core.Controls.Button();
            this.btnSto = new Smobiler.Core.Controls.Button();
            this.tableView1 = new Smobiler.Core.Controls.TableView();
            // 
            // labelTitle
            // 
            this.labelTitle.FontSize = 17F;
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labelTitle.Location = new System.Drawing.Point(94, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(142, 28);
            this.labelTitle.Text = "出库扫描";
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.DarkGray;
            this.label2.FontSize = 14F;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 33);
            this.label2.Text = "条码扫描";
            // 
            // btnScan
            // 
            this.btnScan.BorderColor = System.Drawing.Color.Transparent;
            this.btnScan.BorderRadius = 0;
            this.btnScan.FontSize = 14F;
            this.btnScan.Location = new System.Drawing.Point(246, 31);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(54, 30);
            this.btnScan.Text = "扫描";
            this.btnScan.Press += new System.EventHandler(this.btnScan_Press);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnClear,
            this.btnDel,
            this.btnSto});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            // 
            // btnClear
            // 
            this.btnClear.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 0F);
            this.btnClear.BorderColor = System.Drawing.Color.White;
            this.btnClear.BorderRadius = 0;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.FontSize = 16F;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.Text = "清空";
            this.btnClear.Press += new System.EventHandler(this.btnClear_Press);
            // 
            // btnDel
            // 
            this.btnDel.Border = new Smobiler.Core.Controls.Border(1F, 0F, 1F, 0F);
            this.btnDel.BorderColor = System.Drawing.Color.White;
            this.btnDel.BorderRadius = 0;
            this.btnDel.FontSize = 16F;
            this.btnDel.Location = new System.Drawing.Point(100, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Press += new System.EventHandler(this.btnDel_Press);
            // 
            // btnSto
            // 
            this.btnSto.Border = new Smobiler.Core.Controls.Border(1F, 0F, 1F, 0F);
            this.btnSto.BorderColor = System.Drawing.Color.White;
            this.btnSto.BorderRadius = 0;
            this.btnSto.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSto.FontSize = 16F;
            this.btnSto.Location = new System.Drawing.Point(149, 0);
            this.btnSto.Name = "btnSto";
            this.btnSto.Size = new System.Drawing.Size(100, 40);
            this.btnSto.Text = "出库";
            this.btnSto.Press += new System.EventHandler(this.btnSto_Press);
            // 
            // tableView1
            // 
            tableViewButtonColumn1.DataMember = "BAR001";
            tableViewButtonColumn1.DisplayMember = "BAR001";
            tableViewButtonColumn1.HeaderText = "品号";
            tableViewButtonColumn1.Text = "品号";
            tableViewButtonColumn1.Width = 30;
            tableViewButtonColumn2.DataMember = "BAR004";
            tableViewButtonColumn2.DisplayMember = "BAR004";
            tableViewButtonColumn2.HeaderText = "规格";
            tableViewButtonColumn2.Text = "规格";
            tableViewButtonColumn2.Width = 40;
            tableViewButtonColumn3.DataMember = "BAR008";
            tableViewButtonColumn3.DisplayMember = "BAR008";
            tableViewButtonColumn3.HeaderText = "LotID";
            tableViewButtonColumn3.Text = "LotID";
            tableViewButtonColumn3.Width = 90;
            tableViewButtonColumn4.DataMember = "IBB001";
            tableViewButtonColumn4.DisplayMember = "IBB001";
            tableViewButtonColumn4.HeaderText = "订单号";
            tableViewButtonColumn4.Text = "订单号";
            tableViewButtonColumn4.Width = 60;
            tableViewButtonColumn5.DataMember = "BAR007";
            tableViewButtonColumn5.DisplayMember = "BAR007";
            tableViewButtonColumn5.HeaderText = "轴号";
            tableViewButtonColumn5.Text = "轴号";
            tableViewButtonColumn5.Width = 40;
            tableViewButtonColumn6.DataMember = "BAR020";
            tableViewButtonColumn6.DisplayMember = "BAR020";
            tableViewButtonColumn6.HeaderText = "出库量";
            tableViewButtonColumn6.Text = "出库量";
            tableViewButtonColumn6.Width = 40;
            this.tableView1.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewButtonColumn1,
            tableViewButtonColumn2,
            tableViewButtonColumn3,
            tableViewButtonColumn4,
            tableViewButtonColumn5,
            tableViewButtonColumn6});
            this.tableView1.Location = new System.Drawing.Point(0, 61);
            this.tableView1.Name = "tableView1";
            this.tableView1.RowHeight = 45;
            this.tableView1.Size = new System.Drawing.Size(300, 399);
            this.tableView1.ButtonCellPress += new Smobiler.Core.Controls.TableViewButtonCellEventHandler(this.tableView1_ButtonCellPress);
            // 
            // SmobilerFormScan
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labelTitle,
            this.label2,
            this.btnScan,
            this.panel1,
            this.tableView1});
            this.Name = "SmobilerFormScan";

        }
        #endregion

        private Smobiler . Core . Controls . Label labelTitle;
        private Smobiler . Core . Controls . Label label2;
        private Smobiler . Core . Controls . Button btnScan;
        private Smobiler . Core . Controls . Panel panel1;
        private Smobiler . Core . Controls . Button btnClear;
        private Smobiler . Core . Controls . Button btnDel;
        private Smobiler . Core . Controls . Button btnSto;
        private Smobiler . Core . Controls . TableView tableView1;
    }
}