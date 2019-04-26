using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace CodeSanBll . Bll
{
    public class StoProBll:IBll.StoProIBll
    {
        private readonly Dao . StoProDao dal = null;
        public StoProBll ( )
        {
            dal = new Dao . StoProDao ( );
        }

        /// <summary>
        /// 获取出库类别
        /// </summary>
        /// <param name="choise"></param>
        /// <returns></returns>
        public DataTable getTableForType ( string choise )
        {
            return dal . getTableForType ( choise );
        }

        /// <summary>
        /// 获取经办人
        /// </summary>
        /// <returns></returns>
        public DataTable getTableForUser ( )
        {
            return dal . getTableForUser ( );
        }
    }
}
