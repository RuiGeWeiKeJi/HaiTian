using DevExpress . Utils . Paint;
using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Reflection;
using System . Text;
using System . Windows . Forms;

namespace barCode
{
    public partial class ProductChoise :Form
    {
        public ProductChoise ( )
        {
            InitializeComponent ( );
            
            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barCodeDao . Bll . ProductChoiseBll _bll = new barCodeDao . Bll . ProductChoiseBll ( );
            DataTable dt = _bll . GetDataTable ( );
            gridControl1 . DataSource = dt;
        }

        private void gridView1_DoubleClick ( object sender ,EventArgs e )
        {
            if ( gridView1 . FocusedRowHandle < 0 || gridView1 . FocusedRowHandle > gridView1 . RowCount - 1 )
                return;
            this . DialogResult = System . Windows . Forms . DialogResult . OK;
        }

        public barCodeEntity . barCodeReportEntity SelectPerson
        {
            get
            {
                if ( gridView1 . GetDataRow ( gridView1 . FocusedRowHandle ) == null )
                    return null;
                DataRow row = gridView1 . GetDataRow ( gridView1 . FocusedRowHandle );
                if ( row == null )
                    return null;
                barCodeEntity . barCodeReportEntity _model = new barCodeEntity . barCodeReportEntity ( );
                _model . BAR001 = row [ "BAR001" ] . ToString ( );
                _model . BAR002 = row [ "BAR002" ] . ToString ( );
                return _model;
            }
        }

        private void ProductChoise_Load ( object sender ,EventArgs e )
        {

        }
    }
}
