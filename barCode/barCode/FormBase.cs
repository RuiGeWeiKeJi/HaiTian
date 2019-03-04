using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace barCode
{
    public partial class FormBase :Form
    {
        public FormBase ( )
        {
            InitializeComponent ( );
            this . WindowState = FormWindowState . Maximized;           
        }

        private void barTool_Click ( object sender ,EventArgs e )
        {
            FormPrintBarCode bar = new FormPrintBarCode ( );
            bar . StartPosition = FormStartPosition . CenterScreen;
            bar . Show ( );
        }

        private void reportTool_Click ( object sender ,EventArgs e )
        {
            BarCodeReport report = new BarCodeReport ( );
            report . StartPosition = FormStartPosition . CenterScreen;
            report . Show ( );
        }

        private void connTool_Click ( object sender ,EventArgs e )
        {
            Connection . Form1 form = new Connection . Form1 ( );
            form . StartPosition = FormStartPosition . CenterScreen;
            form . Show ( );
        }

        private void FormBase_Load ( object sender ,EventArgs e )
        {

        }
    }
}
