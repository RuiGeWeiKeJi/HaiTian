using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;

namespace CodeSanBll . Dao
{
    public class StoProDao
    {
        /// <summary>
        /// 获取出库类别
        /// </summary>
        /// <param name="choise"></param>
        /// <returns></returns>
        public DataTable getTableForType ( string choise )
        {
            StringBuilder strSql = new StringBuilder ( );
            if ( choise . Equals ( "出库" ) )
                strSql . Append ( "SELECT DISTINCT LAA001,LAA002 FROM JSKLAA WHERE LAA001='15'" );
            else
                strSql . Append ( "SELECT DISTINCT LAA001,LAA002 FROM JSKLAA WHERE LAA001 IN ('13','14')" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取经办人
        /// </summary>
        /// <returns></returns>
        public DataTable getTableForUser ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DISTINCT DBA001,DBA002 FROM TPADBA" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
