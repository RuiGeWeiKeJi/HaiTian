using DevExpress . Utils . Paint;
using System;
using System . Data;
using System . Reflection;
using System . Windows . Forms;

namespace barCode
{
    public partial class CheckProduct :Form
    {
        public CheckProduct ( )
        {
            InitializeComponent ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            gridControl1 . DataSource = _bll . GetDataTableOf ( );
        }

        private void CheckProduct_Load ( object sender ,EventArgs e )
        {
             
        }

        public barCodeEntity . barCodeReportEntity SelectBarcode
        {
            get
            {
                if ( gridView1 . GetDataRow ( gridView1 . FocusedRowHandle ) == null )
                    return null;
                DataRow row = gridView1 . GetDataRow ( gridView1 . FocusedRowHandle );
                if ( row == null )
                    return null;
                barCodeEntity . barCodeReportEntity _model = new barCodeEntity . barCodeReportEntity ( );
                _model . BAR001 = row [ "DEA001" ] . ToString ( );
                _model . BAR002 = row [ "DEA002" ] . ToString ( );
                _model . BAR003 = row [ "DEA960" ] . ToString ( );
                _model . BAR004 = row [ "DEA961" ] . ToString ( );
                //_model . BAR005 = row [ "DEA961" ] . ToString ( );
                return _model;
            }
        }

        private void gridView1_DoubleClick ( object sender ,EventArgs e )
        {
            if ( gridView1 . FocusedRowHandle < 0 || gridView1 . FocusedRowHandle > gridView1 . RowCount - 1 )
                return;
            this . DialogResult = System . Windows . Forms . DialogResult . OK;
        }
    }
}
