using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using Smobiler . Core;
using Smobiler . Core . Controls;
using System . Data;
using CodeSan . Utils;

namespace CodeSan . Layer
{
    partial class SmobilerFormSto : SmobilerFormBaseBack
    {
        public CodeSanEntity . StoEntity model;
        private readonly CodeSanBll . Bll . ScanBll _bll;
        DataTable tableOrder;

        public SmobilerFormSto ( ) : base ( )
        {
            //This call is required by the SmobilerForm.
            InitializeComponent ( );

            this . labelTitle . Text = Utils . BaseColumn . storage ;
            model = new CodeSanEntity . StoEntity ( );
            _bll = new CodeSanBll . Bll . ScanBll ( );
        }
        
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press ( object sender , EventArgs e )
        {
            ShowResult = ShowResult . No;
            this . Close ( );
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSure_Press ( object sender , EventArgs e )
        {
            if ( getValue ( ) == false )
                return;
            ShowResult = ShowResult . Yes;
            this . Close ( );
        }

        bool getValue ( )
        {
            if ( string . IsNullOrEmpty ( txtBRA020 . Text ) )
            {
                Toast ( "请录入产品数量" );
                return false;
            }
            int intResult = 0;
            if ( int . TryParse ( txtBRA020 . Text , out intResult ) == false )
            {
                Toast ( "数量须为整数" );
                return false;
            }
            model . BAR020 = intResult;
            if ( string . IsNullOrEmpty ( txtOrder . Text ) )
            {
                Toast ( "请选择订单号" );
                return false;
            }
            model . BAR009 = txtOrder . Text;
            if ( string . IsNullOrEmpty ( txtBAR008 . Text ) )
            {
                Toast ( "Lot ID不可为空" );
                return false;
            }
            model . BAR008 = txtBAR008 . Text;

            return true;
        }

        /// <summary>
        /// 扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_BarcodeScanned ( object sender , BarcodeResultArgs e )
        {
            try
            {
                queryOtherByCode ( e . Value );
            }
            catch (Exception ex) {
                Toast ( ex . Message );
            }
        }

        /// <summary>
        /// 根据条码,获取其它数据
        /// </summary>
        /// <param name="value"></param>
        void queryOtherByCode ( string value )
        {
            txtCode . Text = model . BAR018 = value;
            DataTable tableLotId = _bll . getDataTableLotId ( value );
            if ( tableLotId == null || tableLotId . Rows . Count < 1 )
                return;
            txtBAR008 . Text = model . BAR008 = tableLotId . Rows[0]["BAR008"] . ToString ( );
            txtBAR007 . Text = model . BAR007 = tableLotId . Rows[0]["BAR007"] . ToString ( );
            txtBAR004 . Text = model . BAR004 = tableLotId . Rows[0]["BAR004"] . ToString ( );

            tableOrder = _bll . getDataTableOfOrder ( model . BAR008 );
            string[] itemList = TableToArr . tableToOrder ( tableOrder , "IBB001" );
            //pickerOrder . Items = TableToArr . tableToOrder ( tableOrder , "IBB001" );
            addChoise ( itemList );
        }

        private void popListOne_Selected ( object sender , EventArgs e )
        {
            if ( popListOne . Selection != null )
            {
                txtOrder . Text = popListOne . Selection . Text;
            }
        }

        private void btnOrder_Press ( object sender , EventArgs e )
        {
            string[] itemList = TableToArr . tableToOrder ( tableOrder , "IBB001" );
            addChoise ( itemList );
        }

        void addChoise ( string[] itemList )
        {
            try
            {
                popListOne . Groups . Clear ( );
                PopListGroup typeGroup = new PopListGroup { Title = "订单号" };
                foreach ( string s in itemList )
                {
                    PopListItem item = new PopListItem
                    {
                        Text = s
                    };
                    typeGroup . Items . Add ( item );
                }
                popListOne . Groups . Add ( typeGroup );
                this . popListOne . ShowDialog ( );
            }
            catch ( Exception ex )
            {
                Toast ( ex . Message );
            }
        }

    }
}