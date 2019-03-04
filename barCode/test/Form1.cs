using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;
using StudentMgr;

namespace test
{
    public partial class Form1 :Form
    {
        public Form1 ( )
        {
            InitializeComponent ( );
        }

        private void Form1_Load ( object sender ,EventArgs e )
        {
            string [ ] url = { "192.168.1.2222" };
            if ( SeverState . CheckServeStatus ( url ) == false )
                return;
            MessageBox . Show ( "123" );

            //DataTable da = SqlHelper . ExecuteDataTable ( "SELECT BAR001,BAR007,BAR008 FROM HDTBAR" );
            //string [ ] fileName = { "BAR001" ,"BAR007" };
            //da = distinct ( da ,fileName );
            //gridControl1 . DataSource = da;
        }

        /// <summary>
        /// 去重复行
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        DataTable distinct ( DataTable dt ,string[]  fileName )
        {
            DataView dv = dt . DefaultView;
            DataTable disti = dv . ToTable ( "Dist" ,true ,fileName );
            return disti;
        }

    }
}
