using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
//using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SmartDeviceProjectBll
{
    public static class SeverState
    {

        /// <summary>
        /// 检测网络连接状态
        /// </summary>
        /// <param name="urls"></param>
        public static bool CheckServeStatus( /*string[] urls*/ )
        {
            bool restlt = true;
            //int errCount = 0;//ping时连接失败个数

            if (!LocalConnectionStatus())
            {
                MessageBox.Show("网络异常~无连接");
                restlt = false;
            }
            //else if (!MyPing(urls, out errCount))
            //{
            //    if ((double)errCount / urls.Length >= 0.3)
            //    {
            //        MessageBox.Show("网络异常~连接多次无响应");
            //        restlt = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("网络不稳定");
            //        restlt = false;
            //    }
            //}
            else
            {
                restlt = true;
            }

            return restlt;
        }

        #region 网络检测

        private const int INTERNET_CONNECTION_MODEM = 1;
        private const int INTERNET_CONNECTION_LAN = 2;

        [System.Runtime.InteropServices.DllImport("winInet.dll")]
        private static extern bool InternetGetConnectedState(ref int dwFlag, int dwReserved);

        /// <summary>
        /// 判断本地的连接状态
        /// </summary>
        /// <returns></returns>
        private static bool LocalConnectionStatus()
        {
            System.Int32 dwFlag = new Int32();
            if (!InternetGetConnectedState(ref dwFlag, 0))
            {
                //MessageBox . Show ( "LocalConnectionStatus--未连网!" );
                return false;
            }
            else
            {
                if ((dwFlag & INTERNET_CONNECTION_MODEM) != 0)
                {
                    //MessageBox . Show ( "LocalConnectionStatus--采用调制解调器上网。" );
                    return true;
                }
                else if ((dwFlag & INTERNET_CONNECTION_LAN) != 0)
                {
                    //MessageBox . Show ( "LocalConnectionStatus--采用网卡上网。" );
                    return true;
                }
            }
            return false;
        }

        /*
         
        /// <summary>
        /// Ping命令检测网络是否畅通
        /// </summary>
        /// <param name="urls">URL数据</param>
        /// <param name="errorCount">ping时连接失败个数</param>
        /// <returns></returns>
        public static bool MyPing(string[] urls, out int errorCount)
        {
            bool isconn = true;
            Ping ping = new Ping();
            errorCount = 0;
            try
            {
                PingReply pr;
                for (int i = 0; i < urls.Length; i++)
                {
                    pr = ping.Send(urls[i]);
                    if (pr.Status != IPStatus.Success)
                    {
                        isconn = false;
                        errorCount++;
                    }
                    //MessageBox . Show ( "Ping " + urls [ i ] + "    " + pr . Status . ToString ( ) );
                }
            }
            catch
            {
                isconn = false;
                errorCount = urls.Length;
            }
            //if (errorCount > 0 && errorCount < 3)
            //  isconn = true;
            return isconn;
        }

        */

        #endregion
    }
}
