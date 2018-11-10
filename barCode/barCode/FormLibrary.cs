using System;
using System . Collections . Generic;
using System . Data;
using System . Windows . Forms;

namespace barCode
{
    public partial class FormLibrary :Form
    {
        List<int> _idxList;
        DataTable table;
        public FormLibrary ( List<int> idxList,DataTable table )
        {
            InitializeComponent ( );
            _idxList = idxList;
            this . table = table;
            
            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            comboBox1 . DataSource = _bll . GetDataTableLaa ( );
            comboBox1 . DisplayMember = "LAA002";
            comboBox1 . ValueMember = "LAA001";
        }
        
        private void button1_Click ( object sender ,EventArgs e )
        {
            errorProvider1 . Clear ( );
            if ( string . IsNullOrEmpty ( comboBox1 . Text ) )
            {
                errorProvider1 . SetError ( comboBox1 ,"请选择单据类型" );
                return;
            }
            if ( comboBox1 . SelectedValue . ToString ( ) . Trim ( ) != "002" )
            {
                errorProvider1 . SetError ( comboBox1 ,"请选择入库,否则不予生成入库单" );
                return;
            }
            //int x = 0;
            //if ( string . IsNullOrEmpty ( texbar002 . Text . Trim ( ) ) )
            //{
            //    errorProvider1 . SetError ( texbar002 ,"请填写入库数量" );
            //    return;
            //}
            //if ( int . TryParse ( texbar002 . Text ,out x ) == false )
            //{
            //    errorProvider1 . SetError ( texbar002 ,"入库数量必须为整数" );
            //    return;
            //}

            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            bool result = _bll . InsertToLibrary ( _idxList ,comboBox1 . SelectedValue . ToString ( ) ,this . table );
            if ( result == true )
            {
                this . DialogResult = System . Windows . Forms . DialogResult . OK;
            }
            else
                MessageBox . Show ( "入库失败,请重试" );
        }

        private void button2_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = System . Windows . Forms . DialogResult . Cancel;
        }

    }
}
