using System;
using System . Windows . Forms;

namespace Sweep
{
    public partial class Library :Form
    {
        public Library ( )
        {
            InitializeComponent ( );
        }

        //Close
        private void button3_Click ( object sender ,EventArgs e )
        {
            this . Close ( );
        }
        //Select
        private void button1_Click ( object sender ,EventArgs e )
        {
            Product pd = new Product ( );
            pd . ShowDialog ( );
        }
    }
}
