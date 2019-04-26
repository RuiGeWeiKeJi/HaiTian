using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using CodeSanEntity;

namespace CodeSanBll . Bll
{
    public class ScanBll : IBll . ScanIBll
    {
        private readonly Dao . ScanDao dal = null;
        public ScanBll ( )
        {
            dal = new Dao . ScanDao ( );
        }

        /// <summary>
        /// 获取未完结订单
        /// </summary>
        /// <returns></returns>
        public DataTable getDataTableOfOrder ( string LotId )
        {
            return dal . getDataTableOfOrder ( LotId );
        }

        /// <summary>
        /// 获取规格
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public DataTable getDataTableLotId ( string code )
        {
            return dal . getDataTableLotId ( code );
        }


        /// <summary>
        /// 依据LotId 获取记录
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        public DataTable getDataTableForLotId ( string lotId )
        {
            return dal . getDataTableForLotId ( lotId );
        }

        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="da"></param>
        /// <param name="_entity"></param>
        /// <returns></returns>
        public bool signOfStorage ( DataTable da , ControlStoEntity _entity )
        {
            return dal . signOfStorage ( da , _entity );
        }

        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableForQuery ( string strWhere )
        {
            return dal . getTableForQuery ( strWhere );
        }
    }
}
