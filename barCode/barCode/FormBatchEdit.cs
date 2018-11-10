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
    public partial class FormBatchEdit :Form
    {
        public FormBatchEdit ( )
        {
            InitializeComponent ( );
            
            comboBox1 . Items . Add ( "T" );
            comboBox1 . Items . Add ( "F" );
            comboBox2 . Items . Add ( "T" );
            comboBox2 . Items . Add ( "F" );
        }
        
        public List<int> idxList;
        
        private void btnOk_Click ( object sender ,EventArgs e )
        {
            errorProvider1 . Clear ( );
            bool isOk = true;
            if ( string . IsNullOrEmpty ( comboBox1 . Text ) )
            {
                errorProvider1 . SetError ( comboBox1 ,"请选择入库标记" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( comboBox2 . Text ) )
            {
                errorProvider1 . SetError ( comboBox2 ,"请选择出库标记" );
                isOk = false;
            }
            if ( isOk == false )
                return;
            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            string idxLi = "";
            foreach ( int str in idxList )
            {
                if ( idxLi == "" )
                    idxLi = str . ToString ( );
                else
                    idxLi = idxLi + "," + str . ToString ( );
            }
            bool result = _bll . BatchEdit ( idxLi ,comboBox1 . Text ,comboBox2 . Text );
            if ( result == true )
            {
                MessageBox . Show ( "编辑成功" );
                this . DialogResult = System . Windows . Forms . DialogResult . OK;
            }
            else
                MessageBox . Show ( "编辑失败,请重试" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = System . Windows . Forms . DialogResult . Cancel;
        }
    }
}
