using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;

namespace CodeSanBll
{
    public class DicSystem
    {
        /// <summary>
        /// 获取系统日期
        /// </summary>
        /// <returns></returns>
        public static DateTime getTimeNow ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GETDATE() t" );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return DateTime . Now;
            else
            {
                string time = table . Rows[0]["t"] . ToString ( );
                if ( string . IsNullOrEmpty ( time ) )
                    return DateTime . Now;
                else
                    return Convert . ToDateTime ( time );
            }
        }
    }
}
