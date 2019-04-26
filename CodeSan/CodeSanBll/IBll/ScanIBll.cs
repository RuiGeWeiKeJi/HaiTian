using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace CodeSanBll . IBll
{
    interface ScanIBll
    {
        /// <summary>
        /// 获取未完结订单
        /// </summary>
        /// <returns></returns>
        DataTable getDataTableOfOrder ( string LotId );

        /// <summary>
        /// 获取规格
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        DataTable getDataTableLotId ( string code );


        /// <summary>
        /// 依据LotId 获取记录
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        DataTable getDataTableForLotId ( string lotId );


        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="da"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        bool signOfStorage ( DataTable da , CodeSanEntity . ControlStoEntity _entity );

        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getTableForQuery ( string strWhere );

    }
}
