using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using CodeSanEntity;

namespace CodeSanBll . Dao
{
    public class SqlConnConfigDao
    {
        /// <summary>
        /// 连接数据库是否成功
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ConnResult ( SqlConnConfigEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "Data Source={0};" , model . Ip );
            strSql . Append ( "Initial Catalog=master;" );
            strSql . AppendFormat ( "User Id={0};" , model . Name );
            strSql . AppendFormat ( "Password={0};" , model . Password );

            return SqlHelper . connectionTest ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable ( SqlConnConfigEntity model )
        {
            StringBuilder conn = new StringBuilder ( );
            conn . AppendFormat ( "Data Source={0};" , model . Ip );
            conn . Append ( "Initial Catalog=master;" );
            conn . AppendFormat ( "User Id={0};" , model . Name );
            conn . AppendFormat ( "Password={0};" , model . Password );

            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT name FROM master..sysdatabases ORDER BY name " );

            return SqlHelper . ExecuteDataTable ( conn . ToString ( ) , strSql . ToString ( ) );
        }

    }
}
