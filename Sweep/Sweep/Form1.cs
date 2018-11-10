using System;
using System . Windows . Forms;

namespace Sweep
{
    public partial class Form1 :Form
    {
        public Form1 ( )
        {
            InitializeComponent ( );
        }

        //Close
        private void button4_Click ( object sender ,EventArgs e )
        {
            this . Close ( );
            this . Dispose ( );
        }

        private void btnStorge_Click ( object sender ,EventArgs e )
        {
            Storage stor = new Storage ( );
            stor . MaximizeBox = true;
            stor . ShowDialog ( );
        }

        private void btnconnec_Click ( object sender ,EventArgs e )
        {
            Connection . Form1 form = new Connection . Form1 ( );
            form . MaximizeBox = true;
            form . ShowDialog ( );
        }
    }
}
