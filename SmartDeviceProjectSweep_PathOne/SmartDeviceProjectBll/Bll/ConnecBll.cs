using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SmartDeviceProjectBll.Bll
{
    public class ConnecBll
    {
        Dao.ConnecDao _dao = new Dao.ConnecDao();

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(string connstr)
        {
            return _dao.GetDataTable(connstr);
        }

        /// <summary>
        /// 测试数据库是否连接成功
        /// </summary>
        /// <param name="connstr"></param>
        /// <returns></returns>
        public bool TestConnection(string connstr)
        {
            return _dao.TestConnection(connstr);
        }


        /// <summary>
        /// 是否存在Lot ID
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool Exists ( string str )
        {
            return _dao.Exists ( str );
        }

        /// <summary>
        /// 此条码是否和订单关联
        /// </summary>
        /// <param name="orderNum"></param>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public bool Exists(string orderNum, string barCode)
        {
            return _dao.Exists(orderNum, barCode);
        }

        /// <summary>
        /// 本批条码是否和本订单关联
        /// </summary>
        /// <param name="orderNum"></param>
        /// <param name="lotId"></param>
        /// <param name="startLotId"></param>
        /// <param name="endLotId"></param>
        /// <returns></returns>
        public bool Exists(string orderNum, string lotId, string startLotId, string endLotId)
        {
            return _dao.Exists(orderNum, lotId, startLotId, endLotId);
        }

        /// <summary>
        /// 根据Lot Id获取记录
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfLot ( string str )
        {
            return _dao.GetDataTableOfLot ( str );
        }


        /// <summary>
        /// 批量获取Lot Id
        /// </summary>
        /// <param name="lotId"></param>
        /// <param name="startLotId"></param>
        /// <param name="endLotId"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfLotIdSome(string lotId, string startLotId, string endLotId)
        {
            return _dao.GetDataTableOfLotIdSome(lotId, startLotId, endLotId);
        }

        /// <summary>
        /// 获取Lot Id
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLotId()
        {
            return _dao.GetDataTableLotId();
        }

        /// <summary>
        /// 根据流水 获取LOT ID
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable GetDataTableLotId(string num)
        {
            return _dao.GetDataTableLotId(num);
        }

        /// <summary>
        /// 更新扫描状态
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool signOfLi ( string str )
        {
            return _dao.signOfLi ( str );
        }
        public bool signOfLiF(string str)
        {
            return _dao.signOfLiF(str);
        }

        /// <summary>
        /// 更新扫描状态
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool signOfLi(DataTable da)
        {
            return _dao.signOfLi(da);
        }
        public bool signOfLiT(DataTable da)
        {
            return _dao.signOfLiT(da);
        }

        /// <summary>
        /// 更新出库状态
        /// </summary>
        /// <param name="da"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool signOfStorage(DataTable da, string orderType, string personNum)
        {
            return _dao.signOfStorage(da, orderType, personNum);
        }


        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfOnly()
        {
            return _dao.GetDataTableOfOnly();
        }

        /// <summary>
        /// 获取条码记录表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfAll(string strWhere)
        {
            return _dao.GetDataTableOfAll(strWhere);
        }

        /// <summary>
        /// 查询订单号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfQuery(string strWhere)
        {
            return _dao.GetDataTableOfQuery(strWhere);
        }

        /// <summary>
        /// 获取未完结订单
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfOrder()
        {
            return _dao.GetDataTableOfOrder();
        }

        /// <summary>
        /// 获取入库单据类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLaa(string choise)
        {
            return _dao.GetDataTableLaa(choise);
        }
        /// <summary>
        /// 获取经办人
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTabledba()
        {
            return _dao.GetDataTabledba();
        }


        /// <summary>
        /// 获取轴号
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string zh(string code)
        {
            return _dao.zh(code);
        }



        /// <summary>
        /// 根据轴号  获取Lot Id
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        public string lotidDt(string spe, string lotId)
        {
            return _dao.lotidDt(spe,lotId);
        }

        /// <summary>
        /// 根据轴号  获取Spe
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        public DataTable lotidDt(string lotId)
        {
            return _dao.lotidDt(lotId);
        }


        /// <summary>
        /// 获取剩余出库数量
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        public int lotNum(string lotId)
        {
            return _dao.lotNum(lotId);
        }

    }
}
