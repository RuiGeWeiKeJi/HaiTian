using System;
using System . Data;
using CodeSan . Layer;
using CodeSan . Utils;
using Smobiler . Core . Controls;

namespace CodeSan
{
    partial class SmobilerFormCon : SmobilerFormBaseBack
    {
        private readonly CodeSanBll . Bll . SqlConnConfigBll _bll;
        private readonly CodeSanEntity . SqlConnConfigEntity _model;
        bool result = false;
        DataTable tableResult;

        public SmobilerFormCon ( ) : base ( )
        {
            //This call is required by the SmobilerForm.
            InitializeComponent ( );

            _bll = new CodeSanBll . Bll . SqlConnConfigBll ( );
            _model = new CodeSanEntity . SqlConnConfigEntity ( );

            readForConfig ( );
        }

        private void txtPass_TextChanged ( object sender , EventArgs e )
        {
            if ( testAndRead ( ) )
                readDatabase ( );
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Press ( object sender , EventArgs e )
        {
            if ( testAndRead ( ) == false )
                MessageBox . Show ( "连接失败" );
            else
                MessageBox . Show ( "连接成功" );
        }

        /// <summary>
        /// 测试连接  读取数据
        /// </summary>
        /// <returns></returns>
        bool testAndRead ( )
        {
            result = false;
            _model . Ip = txtIp . Text;
            _model . Name = txtName . Text;
            _model . Password = txtPass . Text;
            result = _bll . ConnResult ( _model );
            if ( result )
            {
                tableResult = _bll . GetDataTable ( _model );
                if ( tableResult == null || tableResult . Rows . Count < 1 )
                    return false;
                //readDatabase ( );
            }

            return result;
        }

        /// <summary>
        /// 选择生产库
        /// </summary>
        void readDatabase ( )
        {
            try
            {
                string[] itemList = TableToArr . tableToOrder ( tableResult , "name" );
                popListOne . Groups . Clear ( );
                PopListGroup typeGroup = new PopListGroup { Title = "生产库" };
                foreach ( string s in itemList )
                {
                    PopListItem item = new PopListItem
                    {
                        Text = s
                    };
                    typeGroup . Items . Add ( item );
                }
                popListOne . Groups . Add ( typeGroup );
                this . popListOne . ShowDialog ( );
            }
            catch ( Exception ex )
            {
                Toast ( ex . Message );
            }
        }

        /// <summary>
        /// 读取配置文件数据
        /// </summary>
        void readForConfig ( )
        {
            txtIp . Text = Utility . IniUtil . ReadIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "host" );
            txtName . Text = Utility . IniUtil . ReadIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "user" );
            txtPass . Text = Utility . IniUtil . ReadIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "password" );
            txtStu . Text = Utility . IniUtil . ReadIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "dbname" );
        }

        /// <summary>
        /// 写配置文件
        /// </summary>
        void writeForConfig ( )
        {

            _model . Ip = txtIp . Text;
            _model . Name = txtName . Text;
            _model . Password = txtPass . Text;
            _model . Stu = txtStu . Text;

            Utility . IniUtil . WriteIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "host" , _model . Ip );
            Utility . IniUtil . WriteIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "user" , _model . Name );
            Utility . IniUtil . WriteIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "password" , _model . Password );
            Utility . IniUtil . WriteIniValue ( AppDomain . CurrentDomain . SetupInformation . ApplicationBase + "config.ini" , "DB" , "dbname" , _model . Stu );

        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Press ( object sender , EventArgs e )
        {
            writeForConfig ( );
            this . Close ( );
        }

        private void panel1_Press ( object sender , EventArgs e )
        {
            this . Close ( );
        }

        private void popListOne_Selected ( object sender , EventArgs e )
        {
            if ( popListOne . Selection != null )
            {
                txtStu . Text = popListOne . Selection . Text;
            }
        }

        /// <summary>
        /// 选择库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoise_Press ( object sender , EventArgs e )
        {
            if ( testAndRead ( ) )
                readDatabase ( );
        }

    }
}