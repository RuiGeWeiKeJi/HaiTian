using System;
using Smobiler . Core . Controls;
using System . Data;
using CodeSan . ControlForSmobiler;

namespace CodeSan . Layer
{
    partial class SmobilerFormScan : SmobilerFormBaseBack
    {
        private readonly CodeSanBll . Bll . ScanBll _bll;
        public CodeSanEntity . StoEntity model;
        public CodeSanEntity . ControlStoEntity _model;
        DataTable tableView;

        TableViewRow row;

        public SmobilerFormScan ( ) : base ( )
        {
            //This call is required by the SmobilerForm.
            InitializeComponent ( );

            this . labelTitle . Text = Utils . BaseColumn . storage + "扫描";
            _bll = new CodeSanBll . Bll . ScanBll ( );
            model = new CodeSanEntity . StoEntity ( );
            _model = new CodeSanEntity . ControlStoEntity ( );
        }
   
        /// <summary>
        /// 扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_Press ( object sender , EventArgs e )
        {
            try
            {
                SmobilerFormSto form = new SmobilerFormSto { model = model };
                Form . Show ( form , ( MobileForm sender1 , object args ) =>
                      {
                          if ( form . ShowResult == ShowResult . Yes )
                          {
                              model = form . model;
                              Bind ( );
                          }
                      } );
            }
            catch ( Exception ex ) {
                Toast ( ex . Message );
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind ( )
        {
            if ( tableView == null || tableView . Rows . Count < 1 )
            {
                tableView = _bll . getDataTableForLotId ( model . BAR008 );
                if ( tableView . Rows . Count > 0 )
                {
                    tableView . Columns . Add ( "IBB001" , typeof ( System . String ) );
                    tableView . Rows[0][5] = model . BAR009;
                    tableView . Rows[0][4] = model . BAR020;
                }
            }
            else
            {
                DataTable da = _bll . getDataTableForLotId ( model . BAR008 );
                if ( da != null && da . Rows . Count > 0 )
                {
                    tableView . Rows . Add ( da . Rows[0]["BAR001"] , da . Rows[0]["BAR004"] , da . Rows[0]["BAR007"] , da . Rows[0]["BAR008"] , model . BAR020 , model . BAR009 );
                }
            }
            tableView1 . DataSource = tableView;
            tableView1 . DataBind ( );
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Press ( object sender , EventArgs e )
        {
            tableView = new DataTable ( );
            tableView1 . DataSource = null;
            tableView1 . DataBind ( );
        }

        /// <summary>
        /// 删除选中数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Press ( object sender , EventArgs e )
        {
            tableView1 . Rows . Remove ( row );
            DataRow[] rowData = tableView . Select ( "BAR001='" + row . Cells[0] . BindDisplayValue . ToString ( ) + "' AND BAR004='" + row . Cells[1] . BindDisplayValue . ToString ( ) + "' AND BAR008='" + row . Cells[2] . BindDisplayValue . ToString ( ) + "' AND IBB001='" + row . Cells[3] . BindDisplayValue . ToString ( ) + "' AND BAR007='" + row . Cells[4] . BindDisplayValue . ToString ( ) + "' AND BAR020='" + row . Cells[5] . BindDisplayValue . ToString ( ) + "'" );
            if ( rowData != null && rowData . Length > 0 )
            {
                tableView . Rows . Remove ( rowData[0] );
            }
        }
   
        /// <summary>
        /// 获取表行数据
        /// </summary>
        int index = 0;
        private void tableView1_ButtonCellPress ( object sender , TableViewButtonCellEventArgs e )
        {
            if ( index > tableView1 . Rows . Count )
                index = 0;
            TableViewRow r = tableView1 . Rows[index];
            r . BackColor = System . Drawing . Color . Transparent;
            row = tableView1 . Rows[e . Cell . RowIndex];
            row . BackColor = System . Drawing . Color . PaleTurquoise;
            index = e . Cell . RowIndex;
        }
       
        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSto_Press ( object sender , EventArgs e )
        {
            if ( tableView == null || tableView . Rows . Count < 1 )
            {
                Toast ( "请扫描需要出库的内容" );
                return;
            }
            SmobilerUserControlSto control = new SmobilerUserControlSto { _model = _model };
            Form . ShowDialog ( control , ( object sender1 , EventArgs e1 ) =>
            {
                if ( _model . Type != string . Empty )
                    stoPro ( );
            } );
            //SmobilerFormStoPro form = new SmobilerFormStoPro ( );
            //Form . Show ( form );
        }

        /// <summary>
        /// 出库
        /// </summary>
        void stoPro ( )
        {
            if ( tableView . Rows . Count > 0 )
            {
                if ( !Utils . BaseColumn . storage . Equals ( "出库" ) )
                {
                    _model . Type = "13";
                    _model . Type = "14";
                }
                bool result = _bll . signOfStorage ( tableView , _model );
                if ( result )
                {
                    Toast ( "成功出库" );
                    tableView = null;
                    tableView1 . DataSource = tableView;
                    tableView1 . DataBind ( );
                }
                else
                    Toast ( "出库失败,请重试" );
            }
        }

    }
}