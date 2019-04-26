using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using CodeSanEntity;

namespace CodeSanBll . Bll
{
  
    public class SqlConnConfigBll :IBll.SqlConnConfigIBll
    {
        private readonly Dao . SqlConnConfigDao dal = null;
        public SqlConnConfigBll ( )
        {
            dal = new Dao . SqlConnConfigDao ( );
        }

        /// <summary>
        /// 连接数据库是否成功
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ConnResult ( SqlConnConfigEntity model )
        {
            return dal . ConnResult ( model );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="connstr"></param>
        /// <returns></returns>
        public DataTable GetDataTable ( SqlConnConfigEntity model )
        {
            return dal . GetDataTable ( model );
        }
    }
}
