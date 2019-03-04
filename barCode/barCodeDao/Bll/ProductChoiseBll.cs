using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace barCodeDao . Bll
{
    public class ProductChoiseBll
    {
        private readonly Dao.ProductChoiseDao _dao=new Dao.ProductChoiseDao();
        public ProductChoiseBll ( )
        {
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable ( )
        {
            return _dao . GetDataTable ( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetListOnly ( )
        {
            return _dao . GetDataSet ( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<barCodeEntity . barCodeReportEntity> DataTableToList ( DataTable dt )
        {
            List<barCodeEntity . barCodeReportEntity> modelList = new List<barCodeEntity . barCodeReportEntity> ( );
            int rowcount = dt . Rows . Count;
            if ( rowcount > 0 )
            {
                barCodeEntity . barCodeReportEntity _mode;
                for ( int i = 0 ; i < rowcount ; i++ )
                {
                    _mode = _dao . GetModel ( dt . Rows [ i ] );
                    if ( _mode != null )
                        modelList . Add ( _mode );
                }
            }

            return modelList;
        }

    }
}
