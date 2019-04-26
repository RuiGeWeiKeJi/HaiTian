using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using Smobiler . Core;
using Smobiler . Core . Controls;
using System . Data;
using CodeSan . Layer;

namespace CodeSan
{
    partial class SmobilerFormMain : SmobilerFormBase
    {
        public SmobilerFormMain ( ) : base ( )
        {
            //This call is required by the SmobilerForm.
            InitializeComponent ( );
        }

        private void SmobilerFormMain_Load ( object sender , EventArgs e )
        {

        }

        private void iconMenuView1_ItemPress ( object sender , IconMenuViewItemPressEventArgs e )
        {
            if ( e . Item . ID . Equals ( "conn" ) )
            {
                SmobilerFormCon form = new SmobilerFormCon ( );
                Show ( form );
            }
            else if ( e . Item . ID . Equals ( "ChuKu" ) )
            {
                Utils . BaseColumn . storage = "出库";
                SmobilerFormScan form = new SmobilerFormScan ( );
                Show ( form );
            }
            else if ( e . Item . ID . Equals ( "OtherChuKu" ) )
            {
                Utils . BaseColumn . storage = "其它出库";
                SmobilerFormScan form = new SmobilerFormScan ( );
                Show ( form );
            }
            else if ( e . Item . ID . Equals ( "zhanghuxinxi" ) )
            {
                SmobilerFormAbout form = new SmobilerFormAbout ( );
                Show ( form );
            }
            else if ( e . Item . ID . Equals ( "Barcode" ) )
            {
                SmobilerFormCode form = new SmobilerFormCode ( );
                Show ( form );
            }
        }

    }
}