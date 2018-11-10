using DevExpress . Utils . Paint;
using DevExpress . XtraCharts;
using DevExpress . XtraPrinting;
using DevExpress . XtraPrintingLinks;
using System;
using System . Collections . Generic;
using System . Data;
using System . Drawing;
using System . IO;
using System . Reflection;
using System . Windows . Forms;

namespace barCode
{
    public partial class BarCodeReport :FormChild
    {
        barCodeEntity.barCodeReportEntity _model=new barCodeEntity.barCodeReportEntity();
        List<int> idxList=new List<int>(); DataTable tableQuery;


        public BarCodeReport ( )
        {
            InitializeComponent ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            BAR002 . SummaryItem . SetSummary ( DevExpress . Data . SummaryItemType . Custom ,"选中:" + 0 . ToString ( ) );
        }

        private void BarCodeReport_Load ( object sender ,EventArgs e )
        {
            
        }
        
        private void button4_Click ( object sender ,EventArgs e )
        {
            ProductChoise chPro = new ProductChoise ( );
            chPro . StartPosition = FormStartPosition . CenterScreen;
            DialogResult result = chPro . ShowDialog ( );
            if ( result == System . Windows . Forms . DialogResult . OK )
            {
                _model = chPro . SelectPerson;
                if ( _model != null )
                {
                    texbar001 . Text = _model . BAR001;
                    texbar002 . Text = _model . BAR002;
                }
            }
        }

        protected override int Query ( )
        {
            string strWhere = "1=1";
            barCodeEntity . barCodeReportEntity _model = new barCodeEntity . barCodeReportEntity ( );
            if ( !string . IsNullOrEmpty ( texbar001 . Text ) )
            {
                _model . BAR001 = texbar001 . Text;
                strWhere += " AND BAR001='" + _model . BAR001 + "'";
            }
            if ( !string . IsNullOrEmpty ( texbar002 . Text ) )
            {
                _model . BAR002 = texbar002 . Text;
                strWhere += " AND BAR002='" + _model . BAR002 + "'";
            }
            if ( !string . IsNullOrEmpty ( combar009 . Text ) )
            {
                _model . BAR009 = combar009 . Text;
                strWhere += " AND BAR009='" + _model . BAR009 + "'";
            }
            if ( !string . IsNullOrEmpty ( combar010 . Text ) )
            {
                _model . BAR010 = combar010 . Text;
                strWhere += " AND BAR010='" + _model . BAR010 + "'";
            }
            if ( !string . IsNullOrEmpty ( combar011 . Text ) )
            {
                _model . BAR011 = combar011 . Text;
                strWhere += " AND BAR011='" + _model . BAR011 + "'";
            }

            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            tableQuery = _bll . GetDataTable ( strWhere );
            tableQuery . Columns . Add ( "check" ,typeof ( System . Boolean ) );
            gridControl1 . DataSource = tableQuery;
            idxList . Clear ( );
            DataTable countDt = _bll . GetDataTableCount ( strWhere );
            assignMent ( countDt );

            BAR002 . SummaryItem . SetSummary ( DevExpress . Data . SummaryItemType . Custom ,"选中:" + 0 . ToString ( ) );
            return 0;
        }

        void assignMent ( DataTable da )
        {
            if ( da != null && da . Rows . Count > 0 )
            {
                if ( gridView1 . DataRowCount > 0 )
                {
                    string axisNum = "", speci = "";
                    string [ ] spe;
                    for ( int i = 0 ; i < gridView1 . DataRowCount ; i++ )
                    {
                        _model . BAR019 = string . IsNullOrEmpty ( gridView1 . GetDataRow ( i ) [ "BAR019" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( i ) [ "BAR019" ] . ToString ( ) );
                        _model . BAR020 = string . IsNullOrEmpty ( gridView1 . GetDataRow ( i ) [ "BAR020" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( i ) [ "BAR020" ] . ToString ( ) );
                        axisNum = gridView1 . GetDataRow ( i ) [ "BAR018" ] . ToString ( );
                        if ( da . Select ( "BAR018='" + axisNum + "'" ) . Length > 0 )
                            speci = da . Select ( "BAR018='" + axisNum + "'" ) [ 0 ] [ "DEA057" ] . ToString ( );
                        else
                            speci = "";
                        if ( speci != "" )
                        {
                            spe = speci . Split ( '*' );
                            if ( spe . Length >= 2 )
                            {
                                _model . BAR021 = Math . Round ( Convert . ToDecimal ( spe [ 0 ] ) * Convert . ToDecimal ( spe [ 1 ] ) * Convert . ToDecimal ( spe [ 2 ] ) ,4 );
                                gridView1 . SetRowCellValue ( i ,gridView1 . Columns [ "BAR0" ] ,( _model . BAR021 * _model . BAR019 ) . ToString ( ) );
                                gridView1 . SetRowCellValue ( i ,gridView1 . Columns [ "BAR3" ] ,( _model . BAR021 * _model . BAR020 ) . ToString ( ) );
                            }
                        }
                    }
                }
            }
        }

        protected override int Delete ( )
        {
            if ( idxList . Count < 1 )
            {
                MessageBox . Show ( "请选择需要删除的记录" );
                return 0;
            }

            if ( MessageBox . Show ( "删除记录!" ,"确定删除选中的记录?" ,MessageBoxButtons . OKCancel ) == DialogResult . OK )
            {
                barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
                string idxAll = "";
                foreach ( int id in idxList )
                {
                    if ( idxAll == "" )
                        idxAll = id . ToString ( );
                    else
                        idxAll = idxAll + "," + id . ToString ( );
                }
                if ( _bll . Delete ( idxAll ) )
                {
                    MessageBox . Show ( "成功删除" );
                    Query ( );
                }
                else
                    MessageBox . Show ( "删除失败,请重试" );
            }

            return 0;
        }

        protected override int Refresh ( )
        {
            Query ( );
            return 0;
        }

        protected override int Edit ( )
        {
            if ( _model . idx < 1 )
            {
                MessageBox . Show ( "请选择需要编辑的记录" ,"提示" );
                return 0;
            }
            if ( idxList . Count < 1 )
            {
                MessageBox . Show ( "请选择需要编辑的记录" ,"提示" );
                return 0;
            }
            if ( idxList . Count > 1 )
            {
                MessageBox . Show ( "您选了多条记录,请批量编辑" ,"提示" );
                return 0;
            }

            FormEdit form = new FormEdit ( _model . BAR009 ,_model . BAR017 ,_model . BAR016 ,_model . BAR020 . ToString ( ) ,_model . BAR019 . ToString ( ) ,_model . BAR024 ,_model . BAR025 );
            form . id = _model . idx;
            form . StartPosition = FormStartPosition . CenterScreen;
            DialogResult result = form . ShowDialog ( );
            if ( result == System . Windows . Forms . DialogResult . OK )
                Query ( );

            return 0;
        }

        protected override int BatchEdit ( )
        {
            if ( idxList . Count < 1 )
            {
                MessageBox . Show ( "请选择需要编辑的记录","提示" );
                return 0;
            }
            FormBatchEdit form = new FormBatchEdit ( );
            form . idxList = idxList;
            form . StartPosition = FormStartPosition . CenterScreen;
            DialogResult result = form . ShowDialog ( );
            if ( result == System . Windows . Forms . DialogResult . OK )
                Query ( );

            return 0;
        }

        protected override int Storage ( )
        {
            if ( idxList . Count < 1 )
            {
                MessageBox . Show ( "请选择需要入库的内容" );
                return 0;
            }
            //for ( int i = 0 ; i < gridView1 . RowCount ; i++ )
            //{
            //    if ( gridView1 . GetDataRow ( i ) [ "check" ] . ToString ( ) == "True" )
            //    {
            //gridView1 . GetDataRow ( i ) [ "check" ] = false;
            //_model . idx = string . IsNullOrEmpty ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) );
            //idxList . Remove ( _model . idx );
            //    }
            //}

            //if ( idxList . Count < 1 )
            //{
            //    MessageBox . Show ( "您选择的内容已经入库或出库,不允许重复操作" );
            //    return 0;
            //}


            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );
            bool result = true;
            foreach ( int i in idxList )
            {
                if ( tableQuery . Select ( "idx='" + i + "'" ) . Length > 0 )
                {
                    if ( string . IsNullOrEmpty ( tableQuery . Select ( "idx='" + i + "'" ) [ 0 ] [ "BAR023" ] . ToString ( ) ) )
                    {
                        MessageBox . Show ( "请填写本次入库数量" );
                        result = false;
                        break;
                    }
                    else if ( Convert . ToInt32 ( tableQuery . Select ( "idx='" + i + "'" ) [ 0 ] [ "BAR023" ] . ToString ( ) ) <= 0 )
                    {
                        MessageBox . Show ( "本次入库数量有误" );
                        result = false;
                        break;
                    }
                }
            }

            if ( result == false )
                return 0;

            FormLibrary library = new FormLibrary ( idxList ,tableQuery );
            library . StartPosition = FormStartPosition . CenterScreen;
            DialogResult relt = library . ShowDialog ( );
            if ( relt == System . Windows . Forms . DialogResult . OK )
            {
                MessageBox . Show ( "成功入库" );
                Query ( );
            }

            return 0;
        }

        private void gridView1_RowClick ( object sender ,DevExpress . XtraGrid . Views . Grid . RowClickEventArgs e )
        {
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row == null )
                return;

            if ( row [ "BAR016" ] . ToString ( ) == "T" )
                return;

            _model . idx = string . IsNullOrEmpty ( row [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "idx" ] . ToString ( ) );
            _model . BAR009 = row [ "BAR009" ] . ToString ( );
            _model . BAR016 = row [ "BAR016" ] . ToString ( );
            _model . BAR017 = row [ "BAR017" ] . ToString ( );
            _model . BAR019 = string . IsNullOrEmpty ( row [ "BAR019" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "BAR019" ] . ToString ( ) );
            _model . BAR020 = string . IsNullOrEmpty ( row [ "BAR020" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "BAR020" ] . ToString ( ) );
            if ( string . IsNullOrEmpty ( row [ "BAR024" ] . ToString ( ) ) )
                _model . BAR024 = null;
            else
                _model . BAR024 = Convert . ToDateTime ( row [ "BAR024" ] . ToString ( ) );
            _model . BAR025 = row [ "BAR025" ] . ToString ( );

            if ( row [ "check" ] . ToString ( ) == "True" )
            {
                row [ "check" ] = false;
                if ( idxList . Contains ( _model . idx ) )
                    idxList . Remove ( _model . idx );
            }
            else
            {
                row [ "check" ] = true;
                if ( !idxList . Contains ( _model . idx ) )
                    idxList . Add ( _model . idx );
            }

            BAR002 . SummaryItem . SetSummary ( DevExpress . Data . SummaryItemType . Custom ,"选中:" + idxList . Count . ToString ( ) );
        }

        private void button1_Click ( object sender ,EventArgs e )
        {
            idxList . Clear ( );
            if ( gridView1 . RowCount < 1 )
                return;
            for ( int i = 0 ; i < gridView1 . RowCount ; i++ )
            {
                if ( gridView1 . GetDataRow ( i ) [ "BAR016" ] . ToString ( ) == "T" )
                    gridView1 . GetDataRow ( i ) [ "check" ] = false;
                else
                {
                    gridView1 . GetDataRow ( i ) [ "check" ] = true;
                    _model . idx = string . IsNullOrEmpty ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) );
                    if ( !idxList . Contains ( _model . idx ) )
                        idxList . Add ( _model . idx );
                }
            }

            BAR002 . SummaryItem . SetSummary ( DevExpress . Data . SummaryItemType . Custom ,"选中:" + idxList . Count . ToString ( ) );
        }

        private void button2_Click ( object sender ,EventArgs e )
        {
            idxList . Clear ( );
            if ( gridView1 . RowCount < 1 )
                return;
            for ( int i = 0 ; i < gridView1 . RowCount ; i++ )
                gridView1 . GetDataRow ( i ) [ "check" ] = false;

            BAR002 . SummaryItem . SetSummary ( DevExpress . Data . SummaryItemType . Custom ,"选中:" + idxList . Count . ToString ( ) );
        }

        private void button3_Click ( object sender ,EventArgs e )
        {
            texbar001 . Text = texbar002 . Text = combar009 . Text = combar010 . Text = combar011 . Text = "";
        }

        private void combar009_Click ( object sender ,EventArgs e )
        {
            BarCodeUtility . GetDataSource ( combar009 ,"BAR009" );
        }

        private void combar010_Click ( object sender ,EventArgs e )
        {
            BarCodeUtility . GetDataSource ( combar010 ,"BAR010" );
        }

        private void combar011_Click ( object sender ,EventArgs e )
        {
            BarCodeUtility . GetDataSource ( combar011 ,"BAR011" );
        }

        private void gridView1_CellValueChanged ( object sender ,DevExpress . XtraGrid . Views . Base . CellValueChangedEventArgs e )
        {
            //string str = gridView1 . GetFocusedRowCellValue ( "BARDJ" ) . ToString ( );
            //DevExpress . XtraEditors . BaseEdit edit = gridView1 . ActiveEditor;
            //switch ( gridView1 . FocusedColumn . FieldName )
            //{        
            //    case "BARLB":
            //    if ( !str . Equals ( edit . EditValue . ToString ( ) ) )
            //    {
            //        gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BARDJ" ] ,edit . EditValue . ToString ( ) );
            //    }
            //    break;
            //}
        }

        protected override int Export ( )
        {
            ViewExport . ExportToExcel ( this . Text ,gridControl1 );

            return base . Export ( );
        }

    }

    public class DrawXPaint :XPaint
    {

        public override void DrawFocusRectangle ( Graphics g ,Rectangle r ,Color foreColor ,Color backColor )
        {
            base . DrawFocusRectangle ( g ,r ,foreColor ,backColor );
            if ( !CanDraw ( r ) )
                return;
            Brush hb = Brushes . Black;
            g . FillRectangle ( hb ,new Rectangle ( r . X ,r . Y ,2 ,r . Height - 2 ) );//Left
            g . FillRectangle ( hb ,new Rectangle ( r . X ,r . Y ,r . Width - 2 ,2 ) );//Top
            g . FillRectangle ( hb ,new Rectangle ( r . Right - 2 ,r . Y ,2 ,r . Height - 2 ) );//Right
            g . FillRectangle ( hb ,new Rectangle ( r . X ,r . Bottom - 2 ,r . Width - 2 ,2 ) );//Bottom    
        }

    }

    public static class ViewExport
    {
        /// <summary>
        /// DevExpress通用导出Excel,支持多个控件同时导出在同一个Sheet表
        /// eg:ExportToXlsx("",gridControl1,gridControl2);
        /// 将gridControl1和gridControl2的数据一同导出到同一张工作表
        /// </summary>
        /// <param name="title">文件名</param>
        /// <param name="panels">控件集</param>
        public static void ExportToExcel ( string title ,params IPrintable [ ] panels )
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog ( );
            saveFileDialog . FileName = title;
            saveFileDialog . Title = "导出Excel";
            saveFileDialog . Filter = "Excel文件(*.xlsx)|*.xlsx|Excel文件(*.xls)|*.xls";
            DialogResult dialogResult = saveFileDialog . ShowDialog ( );
            if ( dialogResult == DialogResult . Cancel )
                return;
            string FileName = saveFileDialog . FileName;
            PrintingSystem ps = new PrintingSystem ( );
            CompositeLink link = new CompositeLink ( ps );
            ps . Links . Add ( link );
            foreach ( IPrintable panel in panels )
            {
                link . Links . Add ( CreatePrintableLink ( panel ) );
            }
            link . Landscape = true;//横向           
            //判断是否有标题，有则设置         
            //link.CreateDocument(); //建立文档
            try
            {
                int count = 1;
                //在重复名称后加（序号）
                while ( File . Exists ( FileName ) )
                {
                    if ( FileName . Contains ( ")." ) )
                    {
                        int start = FileName . LastIndexOf ( "(" );
                        int end = FileName . LastIndexOf ( ")." ) - FileName . LastIndexOf ( "(" ) + 2;
                        FileName = FileName . Replace ( FileName . Substring ( start ,end ) ,string . Format ( "({0})." ,count ) );
                    }
                    else
                    {
                        FileName = FileName . Replace ( "." ,string . Format ( "({0})." ,count ) );
                    }
                    count++;
                }

                if ( FileName . LastIndexOf ( ".xlsx" ) >= FileName . Length - 5 )
                {
                    XlsxExportOptions options = new XlsxExportOptions ( );
                    link . ExportToXlsx ( FileName ,options );
                }
                else
                {
                    XlsExportOptions options = new XlsExportOptions ( );
                    link . ExportToXls ( FileName ,options );
                }
                if ( DevExpress . XtraEditors . XtraMessageBox . Show ( "保存成功，是否打开文件？" ,"提示" ,MessageBoxButtons . YesNo ,MessageBoxIcon . Information ) == DialogResult . Yes )
                    System . Diagnostics . Process . Start ( FileName );//打开指定路径下的文件
            }
            catch ( Exception ex )
            {
                DevExpress . XtraEditors . XtraMessageBox . Show ( ex . Message );
            }
        }
        /// <summary>
        /// 创建打印Componet
        /// </summary>
        /// <param name="printable"></param>
        /// <returns></returns>
        static PrintableComponentLink CreatePrintableLink ( IPrintable printable )
        {
            ChartControl chart = printable as ChartControl;
            if ( chart != null )
                chart . OptionsPrint . SizeMode = DevExpress . XtraCharts . Printing . PrintSizeMode . Stretch;
            PrintableComponentLink printableLink = new PrintableComponentLink ( ) { Component = printable };
            return printableLink;
        }

        //没有格式要求，想快速导出DataTable数据到Excel可以采用以下方式实现，开发人员在调试过程中有时候也可以用来记录比较。100w的数据导出也就1~2秒的时间
        /*
        void Main ( )
        {
            DataTable dataTable = new DataTable ( );

            for ( int i = 0 ; i < 10 ; i++ )
            {
                dataTable . Columns . Add ( "col" + i );
            }
            for ( int i = 0 ; i < 1000000 ; i++ )
            {
                var dr = dataTable . NewRow ( );
                foreach ( DataColumn col in dataTable . Columns )
                {
                    dr [ col ] = col . ColumnName + i;
                }
                dataTable . Rows . Add ( dr );
            }
            string fileName = "excel.csv";
            Stopwatch watch = new Stopwatch ( );
            watch . Start ( );
            ExportToExcel ( dataTable ,fileName );
            watch . Stop ( );
            ( "导出完毕,用时:" + watch . Elapsed ) . Dump ( );
        }
        public static void ExportToExcel ( DataTable dataTable ,string fileName ,bool isOpen = false )
        {
            var lines = new List<string> ( );
            string [ ] columnNames = dataTable . Columns
                                            . Cast<DataColumn> ( )
                                            . Select ( column => column . ColumnName )
                                            . ToArray ( );
            var header = string . Join ( "," ,columnNames );
            lines . Add ( header );
            var valueLines = dataTable . AsEnumerable ( )
                            . Select ( row => string . Join ( "," ,row . ItemArray ) );
            lines . AddRange ( valueLines );
            File . WriteAllLines ( fileName ,lines );
            if ( isOpen )
                Process . Start ( fileName );
        }
        */

    }

}
