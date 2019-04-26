using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using Smobiler . Core;
using Smobiler . Core . Controls;
using System . Data;

namespace CodeSan . Layer
{
    partial class SmobilerFormCode : SmobilerFormBaseBack
    {
        private readonly CodeSanBll . Bll . ScanBll _bll;
        string strWhere = string . Empty;
        DataTable tableView;

        public SmobilerFormCode ( ) : base ( )
        {
            //This call is required by the SmobilerForm.
            InitializeComponent ( );

            _bll = new CodeSanBll . Bll . ScanBll ( );
        }
        //扫码查询
        private void btnScan_BarcodeScanned ( object sender , BarcodeResultArgs e )
        {
            strWhere = "1=1";
            strWhere = strWhere + " AND BAR018='" + e . Value + "'";
            queryResult ( );
        }
        //查询
        private void btnQuery_Press ( object sender , EventArgs e )
        {
            if ( string . IsNullOrEmpty ( txtQquery . Text ) )
            {
                Toast ( "请输入查询条件" );
                return;
            }
            strWhere = "1=1";
            if ( txtQquery . Text . Contains ( "3C" ) )
                strWhere = strWhere + " AND BAR001 LIKE '" + txtQquery . Text + "%'";
            else
                strWhere = strWhere + " AND BAR007 LIKE '" + txtQquery . Text + "%'";
            queryResult ( );
        }
        //查询数据
        void queryResult ( )
        {
            tableView = _bll . getTableForQuery ( strWhere );
            listView1 . Rows . Clear ( );
            if ( tableView != null && tableView . Rows . Count > 0 )
            {
                listView1 . DataSource = tableView;
                listView1 . DataBind ( );
            }
        }

    }
}