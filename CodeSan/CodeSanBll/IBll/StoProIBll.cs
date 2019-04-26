using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace CodeSanBll . IBll
{
    interface StoProIBll
    {
        /// <summary>
        /// 获取出库类别
        /// </summary>
        /// <param name="choise"></param>
        /// <returns></returns>
        DataTable getTableForType ( string choise );

        /// <summary>
        /// 获取经办人
        /// </summary>
        /// <returns></returns>
        DataTable getTableForUser ( );
    }
}
