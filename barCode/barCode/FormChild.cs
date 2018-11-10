using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Windows . Forms;

namespace barCode
{
    public partial class FormChild :Form
    {
        public FormChild ( )
        {
            InitializeComponent ( );

            toolBatchEdit . Visible = false;
            toolStripSeparator5 . Visible = false;
        }

        protected virtual int Query ( )
        {
            return 0;
        }
        protected virtual int Delete ( )
        {
            return 0;
        }
        protected virtual int  Refresh ( )
        {
            return 0;
        }
        protected virtual int Edit ( )
        {
            return 0;
        }
        protected virtual int BatchEdit ( )
        {
            return 0;
        }
        protected virtual int Storage ( )
        {
            return 0;
        }
        protected virtual int Export ( )
        {
            return 0;
        }

        private void toolQuery_Click ( object sender ,EventArgs e )
        {
            Query ( );
        }

        private void toolDelete_Click ( object sender ,EventArgs e )
        {
            Delete ( );
        }

        private void toolRefresh_Click ( object sender ,EventArgs e )
        {
            Refresh ( );
        }

        private void toolEdit_Click ( object sender ,EventArgs e )
        {
            Edit ( );
        }
        private void toolBatchEdit_Click ( object sender ,EventArgs e )
        {
            BatchEdit ( );
        }
        private void toolStorage_Click ( object sender ,EventArgs e )
        {
            Storage ( );
        }

        private void FormChild_Load ( object sender ,EventArgs e )
        {

        }

        private void toolExport_Click ( object sender ,EventArgs e )
        {
            Export ( );
        }


    }
}
