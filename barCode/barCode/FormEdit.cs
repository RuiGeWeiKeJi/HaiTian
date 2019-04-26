using System;
using System . Windows . Forms;

namespace barCode
{
    public partial class FormEdit :Form
    {
        string saoMiao=string.Empty;
        barCodeEntity . barCodeReportEntity _model = new barCodeEntity . barCodeReportEntity ( );

        public FormEdit ( barCodeEntity . barCodeReportEntity _model )
        {
            InitializeComponent ( );

            cmbSao . Items . Add ( "F" );
            cmbSao . Items . Add ( "T" );
            textBox1 . Text = _model . BAR009;
            textBox4 . Text = _model . BAR019 . ToString ( );
            textBox5 . Text = _model . BAR020 . ToString ( );
            dtTime . Text = _model . BAR024 . ToString ( );
            richBatch . Text = _model . BAR025;

            this . saoMiao = _model . BAR016;

            richTextBox1 . Text = _model . BAR017;
            this . _model . BAR011 = _model . BAR011;
            this . _model = _model;
        }
        
        public int id;
        
        private void FormEdit_Load ( object sender ,EventArgs e )
        {
            cmbSao . Text = saoMiao . Trim ( );
        }
        private void button1_Click ( object sender ,EventArgs e )
        {
            int x = 0;
            if ( !string . IsNullOrEmpty ( textBox5 . Text ) && int . TryParse ( textBox5 . Text ,out x ) == false )
            {
                errorProvider1 . SetError ( textBox5 ,"数量必须是整数" );
                return;
            }
            _model . BAR020 = x;
            x = 0;
            if ( !string . IsNullOrEmpty ( textBox4 . Text ) && int . TryParse ( textBox4 . Text ,out x ) == false )
            {
                errorProvider1 . SetError ( textBox4 ,"数量必须是整数" );
                return;
            }
            _model . BAR019 = x;
            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );

            _model . idx = id;
            _model . BAR017 = richTextBox1 . Text;
            _model . BAR009 = textBox1 . Text;
            _model . BAR016 = cmbSao . Text;
            if ( string . IsNullOrEmpty ( dtTime . Text ) )
                _model . BAR024 = null;
            else
                _model . BAR024 = Convert . ToDateTime ( dtTime . Text );
            _model . BAR025 = richBatch . Text;
            bool result = _bll . Edit ( _model );
            if ( result == true )
            {
                MessageBox . Show ( "编辑成功" );
                this . DialogResult = System . Windows . Forms . DialogResult . OK;
            }
            else
                MessageBox . Show ( "编辑失败,请重试" );
        }
        private void button2_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = System . Windows . Forms . DialogResult . Cancel;
        }

    }
}
