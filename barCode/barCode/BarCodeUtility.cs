using System . Collections . Generic;
using System . Windows . Forms;
using System . Data;

namespace barCode
{
    public class BarCodeUtility
    {
        public BarCodeUtility ( )
        {

        }


        public static void  GetDataSource ( ComboBox box,string disPlaymember )
        {
            barCodeDao . Bll . ProductChoiseBll _bll = new barCodeDao . Bll . ProductChoiseBll ( );
            DataTable da = _bll . GetListOnly ( );
            if ( da != null && da . Rows . Count > 0 )
            {
                box . DisplayMember = disPlaymember;
                box . DataSource = da . Copy ( ) . DefaultView . ToTable ( true ,disPlaymember );
            }
        }
    }
}
