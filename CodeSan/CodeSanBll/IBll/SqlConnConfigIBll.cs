using CodeSanEntity;
using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace CodeSanBll . IBll
{
    interface SqlConnConfigIBll
    {
        /// <summary>
        /// 连接数据库是否成功
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool ConnResult ( SqlConnConfigEntity model );

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        DataTable GetDataTable ( SqlConnConfigEntity model );

    }
}
