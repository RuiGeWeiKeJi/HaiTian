using StringEncrypt;
using System;
using System . Collections . Generic;
using System . IO;
using System . Linq;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace barCode
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main ( )
        {
            //Devexpress 13.1  汉化
            System . Threading . Thread . CurrentThread . CurrentUICulture = new System . Globalization . CultureInfo ( "zh-CN" );

            Application . SetUnhandledExceptionMode ( UnhandledExceptionMode . CatchException );
            //添加非UI上的异常.
            AppDomain . CurrentDomain . UnhandledException += new UnhandledExceptionEventHandler ( CurrentDomain_UnhandledException );

            Application . EnableVisualStyles ( );
            Application . SetCompatibleTextRenderingDefault ( false );
            //if ( new Encrypt ( ) . registerYesOrNo ( ) == false )
            //    Application . Run ( new RegistrationCode . RegisterForm ( ) );
            //else
                Application . Run ( new FormBase ( ) );
        }

        private static void CurrentDomain_UnhandledException ( object sender ,UnhandledExceptionEventArgs e )
        {
            try
            {
                Exception ex = ( Exception ) e . ExceptionObject;

                WriteLog ( ex . Message + "\n\nStack Trace:\n" + ex . StackTrace );
            }
            catch ( Exception exc )
            {
                try
                {
                    MessageBox . Show ( " Error" ,
                        " Could not write the error to the log. Reason: "
                        + exc . Message ,MessageBoxButtons . OK ,MessageBoxIcon . Stop );
                }
                finally
                {
                    Application . Exit ( );
                }
            }
        }

        static void WriteLog ( string str )
        {
            if ( !Directory . Exists ( "ErrLog" ) )
            {
                Directory . CreateDirectory ( "ErrLog" );
            }
            string fileName = DateTime . Now . ToString ( "yyyy-MM-dd" ) + "ErrLog.txt";
            using ( var sw = new StreamWriter ( @"ErrLog\" + fileName ,true ) )
            {
                sw . WriteLine ( "***********************************************************************" );
                sw . WriteLine ( DateTime . Now . ToString ( "HH:mm:ss" ) );
                sw . WriteLine ( str );
                sw . WriteLine ( "---------------------------------------------------------" );
                sw . Close ( );
            }
        }
    }
}
