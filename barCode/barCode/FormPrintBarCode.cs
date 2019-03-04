using System;
using System . Data;
using System . Windows . Forms;

namespace barCode
{
    public partial class FormPrintBarCode :Form
    {
        public FormPrintBarCode ( )
        {
            InitializeComponent ( );

            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );

            DateTime dtOne = _bll . GetTime ( );
            textBox3 . Text = ( Convert . ToInt32 ( dtOne . Year . ToString ( ) . Substring ( 2 ,2 ) ) + 50 ) . ToString ( ) + ( dtOne . Month + 50 ) . ToString ( ) + ( dtOne . Day ) . ToString ( ) . PadLeft ( 2 ,'0' );
            //BarCodeUtility . GetDataSource ( comboBox4 ,"BAR006" );
            BarCodeUtility . GetDataSource ( comboBox1 ,"BAR007" );
            textBox1 . Text = "1";
        }

        DataSet RDataSet;

        //Print
        private void button1_Click ( object sender ,EventArgs e )
        {
            errorProvider1 . Clear ( );
            int number = 0;
            bool isOk = true;
            if ( int . TryParse ( textBox1 . Text ,out number ) == false )
            {
                errorProvider1 . SetError ( textBox1 ,"请输入正确的打印数量" );
                isOk = false;
            }
            if ( texProduct . Tag == null )
            {
                errorProvider1 . SetError ( texProduct ,"品号不可为空" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( texProduct . Text ) )
            {
                errorProvider1 . SetError ( texProduct ,"品名不可为空" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( texSpec . Text ) )
            {
                errorProvider1 . SetError ( texSpec ,"规格不可为空" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( textBox3 . Text ) )
            {
                errorProvider1 . SetError ( textBox3 ,"型号不可为空" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( comboBox1 . Text ) )
            {
                errorProvider1 . SetError ( comboBox1 ,"轴号不可为空" );
                isOk = false;
            }
            if ( isOk == false )
                return;
            numOf ( );
            if ( Save ( ) == false )
                return;
            RDataSet = new DataSet ( );

            getDataTable ( );
            FastReport . Report report = new FastReport . Report ( );        
            string path = "";
            path = Application . StartupPath;
            //if ( string . IsNullOrEmpty ( texPack . Text ) )
            report . Load ( path + "\\PrintBarCode.frx" );
            //else
            //report . Load ( path + "\\PrintBarCodeA.frx" );
            report . RegisterData ( RDataSet );
            report . Show ( );
        }

        private void btnOnly_Click ( object sender ,EventArgs e )
        {
            errorProvider1 . Clear ( );
            int number = 0;
            bool isOk = true;
            if ( int . TryParse ( textBox1 . Text ,out number ) == false )
            {
                errorProvider1 . SetError ( textBox1 ,"请输入正确的打印数量" );
                isOk = false;
            }
            if ( texProduct . Tag == null )
            {
                errorProvider1 . SetError ( texProduct ,"品号不可为空" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( texProduct . Text ) )
            {
                errorProvider1 . SetError ( texProduct ,"品名不可为空" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( textBox3 . Text ) )
            {
                errorProvider1 . SetError ( textBox3 ,"型号不可为空" );
                isOk = false;
            }
            if ( string . IsNullOrEmpty ( comboBox1 . Text ) )
            {
                errorProvider1 . SetError ( comboBox1 ,"轴号不可为空" );
                isOk = false;
            }
            if ( isOk == false )
                return;
            numOf ( );
            if ( Save ( ) == false )
                return;

            RDataSet = new DataSet ( );
            getDataTable ( );
            FastReport . Report report = new FastReport . Report ( );
            string path = "";
            path = Application . StartupPath;
            report . Load ( path + "\\PrintBarCodeB.frx" );
            report . RegisterData ( RDataSet );
            report . Show ( );
        }

        void getDataTable ( )
        {
            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            DataTable de = _bll . GetDataTablePrint ( textBox2 . Text ,Convert . ToInt32 ( textBox1 . Text ) );
            
            de . TableName = "Code";
            RDataSet . Tables . Add ( de );
        }

        bool Save ( )
        {
            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            barCodeEntity . barCodeReportEntity _mode = new barCodeEntity . barCodeReportEntity ( );
            _mode . BAR001 = texProduct . Tag . ToString ( ) . Trim ( );
            _mode . BAR002 = texProduct . Text;
            _mode . BAR003 = texType . Text;
            _mode . BAR004 = texSpec . Text;
            //_mode . BAR005 = texPack . Text;
            _mode . BAR005 = string . Empty;
            _mode . BAR006 = "RHT";
            _mode . BAR007 = comboBox1 . Text;
            _mode . BAR012 = "F";
            _mode . BAR013 = "F";
            _mode . BAR008 = "RHT" + comboBox1 . Text + "-" + textBox2 . Text;
            _mode . BAR018 = textBox2 . Text;
            _mode . BAR023 = Convert . ToInt32 ( textBox1 . Text );
            
            bool result = false;
           
            if ( _mode != null )
            {
                result = _bll . Save ( _mode ,Convert . ToInt64 ( textBox1 . Text ) ,textBox2 . Text );
            }

            return result;
        }

        private void FormPrintBarCode_Load ( object sender , EventArgs e )
        {
            
        }

        private void button2_Click ( object sender ,EventArgs e )
        {
            CheckProduct chec = new CheckProduct ( );
            chec . StartPosition = FormStartPosition . CenterScreen;
            DialogResult result = chec . ShowDialog ( );
            if ( result == System.Windows.Forms.DialogResult.OK )
            {
                barCodeEntity . barCodeReportEntity _model = chec . SelectBarcode;
                if ( _model != null )
                {
                    texProduct . Tag = _model . BAR001;
                    texProduct . Text = _model . BAR002;
                    texType . Text = _model . BAR003;
                    texSpec . Text = _model . BAR004;
                    //texPack . Text = _model . BAR005;
                }
            }
        }

        private void comboBox4_TextChanged ( object sender ,EventArgs e )
        {
            if ( texProduct . Tag != null  )
            {
                numOf ( );
            }
        }

        void numOf ( )
        {
            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );
            barCodeEntity . barCodeReportEntity _mode = new barCodeEntity . barCodeReportEntity ( );
            _mode . BAR007 = comboBox1 . Text;
            DateTime dt = _bll . GetTime ( );
            string x = string . Empty;
            x = texProduct . Tag . ToString ( ) . Substring ( texProduct . Tag . ToString ( ) . Length - 4 );
            x = x + " ";
            foreach ( char c in _mode . BAR007 )
            {
                if ( c >= 48 && c <= 57 )
                {
                    x = x + c . ToString ( );
                }
                else if ( c . ToString ( ) . Equals ( "-" ) )
                {
                    x = x + " " + 0 . ToString ( );
                }
                else if ( c >= 65 && c <= 90 )
                {
                    x = x + ( ( int ) c ) . ToString ( );
                }
            }
            _mode . BAR004 = texSpec . Text;
            string [ ] str = _mode . BAR004 . Split ( '*' );
            if ( str . Length > 2 )
            {
                x = x + " ";
                for ( int i = 0 ; i < 2 ; i++ )
                {
                    foreach ( char c in str [ i ] )
                    {
                        if ( c >= 48 && c <= 57 )
                        {
                            x = x + c . ToString ( );
                        }
                    }
                }
            }
            textBox2 . Text = x;
        }

    }
}
