using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using Smobiler . Core;
using Smobiler . Core . Controls;

namespace CodeSan . Layer
{
    partial class SmobilerFormBaseBack : SmobilerFormBase
    {
        public SmobilerFormBaseBack ( ) : base ( )
        {
            //This call is required by the SmobilerForm.
            InitializeComponent ( );
        }

        private void panel1_Press ( object sender , EventArgs e )
        {
            this . Close ( );
        }
    }
}