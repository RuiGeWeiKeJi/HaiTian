using System;
using System . Windows . Forms;

namespace Sweep
{
    public partial class Storage :Form
    {
        public Storage ( )
        {
            InitializeComponent ( );
            this . textBox1 . Focus ( );
        }

        private void button5_Click ( object sender ,EventArgs e )
        {
            this . Close ( );
        }

        private void button1_Click ( object sender ,EventArgs e )
        {

        }
    }
}
