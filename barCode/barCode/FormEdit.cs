using System;
using System . Windows . Forms;

namespace barCode
{
    public partial class FormEdit :Form
    {
        string saoMiao=string.Empty;
        public FormEdit (string orderNum,string remark ,string saoMiao,string ckNum,string rkNum ,DateTime? dt,string batchSa )
        {
            InitializeComponent ( );
            
            cmbSao . Items . Add ( "F" );
            cmbSao . Items . Add ( "T" );
            textBox1 . Text = orderNum;
            textBox4 . Text = rkNum;
            textBox5 . Text = ckNum;
            dtTime . Text = dt . ToString ( );
            richBatch . Text = batchSa;
            
            this . saoMiao = saoMiao;

            richTextBox1 . Text = remark;
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
            x = 0;
            if ( !string . IsNullOrEmpty ( textBox4 . Text ) && int . TryParse ( textBox4 . Text ,out x ) == false )
            {
                errorProvider1 . SetError ( textBox4 ,"数量必须是整数" );
                return;
            }

            barCodeDao . Bll . barCodeReportBll _bll = new barCodeDao . Bll . barCodeReportBll ( );

            bool result = _bll . Edit ( id ,richTextBox1 . Text ,textBox1 . Text ,cmbSao . Text ,textBox4 . Text ,textBox5 . Text ,dtTime . Text ,richBatch . Text );
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
