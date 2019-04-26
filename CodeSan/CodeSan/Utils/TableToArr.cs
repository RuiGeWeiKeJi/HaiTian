using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace CodeSan . Utils
{
   public class TableToArr
    {
        /// <summary>
        /// dataTable转数组
        /// </summary>
        /// <returns></returns>
        public static string[] tableToOrder ( DataTable table,string columnName )
        {
            //Type type = table . Columns[columnName] . DataType;
            return table . AsEnumerable ( ) . Select ( d => d . Field < string > ( columnName ) ) . ToArray ( );
        }
    }
}
