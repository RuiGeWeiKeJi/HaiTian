using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Data;

namespace barCodeDao . Bll
{
    public class barCodeReportBll
    {
        private readonly Dao.barCodeReportDao _dao=new Dao.barCodeReportDao();

        public barCodeReportBll ( )
        {
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<barCodeEntity . barCodeReportEntity> GetList ( string strWhere )
        {
            DataSet ds = _dao . GetDataSet ( strWhere );
            return DataTableToList ( ds . Tables [ 0 ] );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTable ( string strWhere )
        {
            return _dao . GetDataTable ( strWhere );
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

        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete ( string idxList )
        {
            return _dao . Delete ( idxList );
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="idxList"></param>
        /// <param name="stateOfLibrary">出库</param>
        /// <param name="stateOfStorage">入库</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public bool Edit ( barCodeEntity . barCodeReportEntity _model )
        {
            return _dao . Edit ( _model );
        }

        /// <summary>
        /// 批量编辑
        /// </summary>
        /// <param name="idxList"></param>
        /// <param name="stateOfLibrary"></param>
        /// <param name="stateOfStorage"></param>
        /// <returns></returns>
        public bool BatchEdit ( string idxList ,string stateOfLibrary ,string stateOfStorage )
        {
            return _dao . BatchEdit ( idxList ,stateOfLibrary ,stateOfStorage );
        }

        /// <summary>
        /// 获取Lot ID
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDa ( string strWhere ,string spec ,string zh)
        {
            return _dao . GetDa ( strWhere ,spec ,zh );
        }

        /// <summary>
        /// 获取ID
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetDaT ( string str )
        {
            return _dao . GetDaT ( str );
        }


        /// <summary>
        /// 增加记录
        /// </summary>
        /// <param name="_modelList"></param>
        /// <returns></returns>
        public bool Save ( barCodeEntity . barCodeReportEntity _model,long num ,string serialNum )
        {
            return _dao . Save ( _model ,num ,serialNum );
        }

        /// <summary>
        /// 获取打印列表
        /// </summary>
        /// <param name="first"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDataTablePrint ( string first ,int num  )
        {
            return _dao . GetDataTablePrint ( first ,num );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOf ( )
        {
            return _dao . GetDataTableOf ( );
        }

        /// <summary>
        /// 获取入库单据类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLaa ( )
        {
            return _dao . GetDataTableLaa ( );
        }

        /// <summary>
        /// 生成入库记录
        /// </summary>
        /// <param name="idxList"></param>
        /// <param name="documentType"></param>
        /// <returns></returns>
        public bool InsertToLibrary ( List<int> idxList ,string rklx,DataTable table )
        {
            return _dao . InsertToLibrary ( idxList ,rklx,table );
        }

        /// <summary>
        /// 获取轴号数量
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableCount (string strWhere )
        {
            return _dao . GetDataTableCount ( strWhere );
        }

        /// <summary>
        /// 获取服务器时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetTime ( )
        {
            return _dao . GetTime ( );
        }

    }
}
