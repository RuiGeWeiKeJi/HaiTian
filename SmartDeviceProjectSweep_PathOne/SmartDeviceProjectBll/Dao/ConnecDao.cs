using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentMgr;
using System.Data.SqlClient;
using System.Collections;

namespace SmartDeviceProjectBll.Dao
{
    public class ConnecDao
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(string connstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT name FROM master..sysdatabases ORDER BY name ");
            //strSql.Append("select COUNT(1) coun from R_BASE");

            return SqlHelper.ExecuteDataTablees(connstr, strSql.ToString());
        }

        /// <summary>
        /// 测试数据库是否连接成功
        /// </summary>
        /// <param name="connstr"></param>
        /// <returns></returns>
        public bool TestConnection(string connstr)
        {
            return SqlHelper.connectionTest(connstr);
        }

        /// <summary>
        /// 是否存在Lot ID
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool Exists ( string str )
        {
            //INNER JOIN DCSIBB ON IBB003=BAR001
            StringBuilder strSql=new StringBuilder ( );
            strSql.Append ( "SELECT COUNT(1) COUN FROM HDTBAR " );
            strSql.AppendFormat("WHERE BAR008='{0}' AND BAR016!='T' ", str);

            return SqlHelper.Exists ( strSql.ToString ( ) );
        }

        /// <summary>
        /// 此条码是否和订单关联
        /// </summary>
        /// <param name="orderNum"></param>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public bool Exists(string orderNum,string barCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) COUN FROM HDTBAR A INNER JOIN DCSIBB B ON A.BAR001=B.IBB003 ");
            strSql.AppendFormat("WHERE IBB001='{0}' AND BAR008='{1}'", orderNum, barCode);

            return SqlHelper.Exists(strSql.ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT BAR006 FROM HDTBAR ");
            strSql.AppendFormat("WHERE BAR007='{0}' AND BAR012='T'", lotId);
            DataTable da = SqlHelper.ExecuteDataTable(strSql.ToString());
            if (da != null && da.Rows.Count > 0)
            {
                startLotId = da.Rows[0]["BAR006"].ToString() + lotId + "-" + startLotId;
                endLotId = da.Rows[0]["BAR006"].ToString() + lotId + "-" + endLotId;
                strSql = new StringBuilder();
                strSql.Append("SELECT BAR008 FROM HDTBAR ");
                strSql.AppendFormat(" WHERE BAR008 BETWEEN '{0}' AND '{1}'  AND BAR016!='T'", startLotId, endLotId);

                DataTable de = SqlHelper.ExecuteDataTable(strSql.ToString());
                if (de != null || de.Rows.Count > 0)
                {
                    string str = "";
                    for (int i = 0; i < de.Rows.Count; i++)
                    {
                        lotId = "";
                        lotId = de.Rows[i]["BAR008"].ToString();
                        if (!string.IsNullOrEmpty(lotId))
                        {
                            if (str == "")
                                str = "'" + lotId + "'";
                            else
                                str = str + "," + "'" + lotId + "'";
                        }
                    }
                    if (str == "")
                        return false;
                    else 
                    {
                        strSql = new StringBuilder();
                        strSql.Append("SELECT COUNT(1) COUN FROM HDTBAR A INNER JOIN DCSIBB B ON A.BAR001=B.IBB003 ");
                        strSql.AppendFormat("WHERE IBB001='{0}' AND BAR008 IN (" + str + ")", orderNum);

                        return SqlHelper.Exists(strSql.ToString());
                    }
                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// 根据Lot Id获取记录
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfLot(string str)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT BAR001,BAR004,BAR008,BAR007,ISNULL(BAR020,0) BAR020 FROM HDTBAR ");
            strSql.AppendFormat("WHERE BAR008='{0}' AND BAR012='T' AND BAR016!='T'", str);

            return SqlHelper.ExecuteDataTable(strSql.ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT BAR006 FROM HDTBAR ");
            strSql.AppendFormat("WHERE BAR007='{0}' AND BAR012='T'", lotId);
            DataTable da = SqlHelper.ExecuteDataTable(strSql.ToString());
            if (da != null && da.Rows.Count > 0)
            {
                startLotId = da.Rows[0]["BAR006"].ToString() +  lotId + "-" + startLotId;
                endLotId = da.Rows[0]["BAR006"].ToString() +  lotId + "-" + endLotId;
                strSql = new StringBuilder();
                strSql.Append("SELECT BAR001,BAR004,BAR008,BAR007 FROM HDTBAR ");
                strSql.AppendFormat(" WHERE BAR008 BETWEEN '{0}' AND '{1}'  AND BAR016!='T'", startLotId, endLotId);

                return SqlHelper.ExecuteDataTable(strSql.ToString());
            }
            else
                return null;
        }

        /// <summary>
        /// 获取Lot Id
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLotId()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT BAR007 FROM HDTBAR WHERE BAR012='T' AND ISNULL(BAR019,0)-ISNULL(BAR020,0)>0 ");

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 根据流水 获取LOT ID
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable GetDataTableLotId(string num)
        {
            StringBuilder strSql=new StringBuilder();
            strSql.Append("SELECT BAR008 FROM HDTBAR ");
            strSql.AppendFormat("WHERE BAR018='{0}'",num);

            return SqlHelper.ExecuteDataTable(strSql.ToString());

        }

        /// <summary>
        /// 更新扫描状态
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool signOfLi ( string str)
        {
            StringBuilder strSql=new StringBuilder ( );
            strSql.Append ( "UPDATE HDTBAR SET " );
            strSql.Append ( "BAR016='T'" );
            strSql.AppendFormat(" WHERE BAR018='{0}'", str);

            int row = SqlHelper.ExecuteNonQuery(strSql.ToString());
            if ( row > 0 )
                return true;
            else
                return false;
        }
        public bool signOfLiF(string str)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE HDTBAR SET ");
            strSql.Append("BAR016='F'");
            strSql.AppendFormat(" WHERE BAR008='{0}'", str);

            int row = SqlHelper.ExecuteNonQuery(strSql.ToString());
            if (row > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更新扫描状态
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool signOfLi(DataTable da)
        {
            if (da != null && da.Rows.Count > 0)
            {
                StringBuilder strSql = new StringBuilder();
                ArrayList SQLString = new ArrayList();
                for (int i = 0; i < da.Rows.Count; i++)
                {
                    strSql = new StringBuilder();
                    strSql.Append("UPDATE HDTBAR SET ");
                    strSql.Append("BAR016='F'");
                    strSql.AppendFormat(" WHERE BAR008='{0}'", da.Rows[i]["BAR008"].ToString());
                    SQLString.Add(strSql.ToString());
                }
                return SqlHelper.ExecuteSqlTran(SQLString);
            }
            else
                return false;
        }

        public bool signOfLiT(DataTable da)
        {
            if (da != null && da.Rows.Count > 0)
            {
                StringBuilder strSql = new StringBuilder();
                ArrayList SQLString = new ArrayList();
                for (int i = 0; i < da.Rows.Count; i++)
                {
                    strSql = new StringBuilder();
                    strSql.Append("UPDATE HDTBAR SET ");
                    strSql.Append("BAR016='T'");
                    strSql.AppendFormat(" WHERE BAR008='{0}'", da.Rows[i]["BAR008"].ToString());
                    SQLString.Add(strSql.ToString());
                }
                return SqlHelper.ExecuteSqlTran(SQLString);
            }
            else
                return false;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfOnly()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT BAR001,BAR006,BAR007,BAR008,BAR009,BAR010,BAR011 FROM HDTBAR  WHERE  BAR012='T'");

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 获取条码记录表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfAll(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM HDTBAR ");
            strSql.Append("WHERE " + strWhere);

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 查询订单号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfQuery(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();                                               
            strSql.Append("SELECT BAR001,BAR002,IBB001 FROM HDTBAR INNER JOIN DCSIBB ON IBB003=BAR001 ");
            strSql.Append("WHERE BAR001=@BAR001");
            SqlParameter[] parameter = { 
                                       new SqlParameter("@BAR001",SqlDbType.NVarChar,20)
                                       };
            parameter[0].Value = strWhere;

            return SqlHelper.ExecuteDataTable(strSql.ToString(), parameter);
        }

        /// <summary>
        /// 获取未完结订单
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfOrder()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT IBB001 FROM DCSIBB WHERE IBB015='N' AND IBB023='T' ORDER BY IBB001 DESC");

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 获取出库单据类型 销货
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLaa(string choise)
        {
            StringBuilder strSql = new StringBuilder();
            if (choise == "1")
                strSql.Append("SELECT DISTINCT LAA001,LAA002 FROM JSKLAA WHERE LAA001='15'");
            else
                strSql.Append("SELECT DISTINCT LAA001,LAA002 FROM JSKLAA WHERE LAA001 IN ('13','14')");

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 获取经办人
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTabledba()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT DBA001,DBA002 FROM TPADBA");

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }


        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="da"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool signOfStorage(DataTable da,string orderType,string personNum)
        {
            if (da != null && da.Rows.Count > 0)
            {
                ArrayList SQLString = new ArrayList();
                StringBuilder strSql = new StringBuilder();
                SmartDeviceProjectEntity.HDTBAR _model = new SmartDeviceProjectEntity.HDTBAR();
                //13     样品      14     返工类别   --其它出库
                if (orderType == "13" || orderType == "14")
                {
                    SmartDeviceProjectEntity.JSKLIA _modelTre = new SmartDeviceProjectEntity.JSKLIA();
                    SmartDeviceProjectEntity.JSKLIB _modelFor = new SmartDeviceProjectEntity.JSKLIB();
                    LIALIB(da, SQLString, strSql, _modelTre, _modelFor, personNum, orderType, _model);
                }
                //15      销货
                else if (orderType == "15")
                {
                    SmartDeviceProjectEntity.JSKKEA _modelOne = new SmartDeviceProjectEntity.JSKKEA();
                    SmartDeviceProjectEntity.JSKKEB _modelTwo = new SmartDeviceProjectEntity.JSKKEB();
                    KEAKEB(da, SQLString, strSql, _modelOne, _modelTwo, personNum, orderType, _model);
                }
                else
                    return false;

                return SqlHelper.ExecuteSqlTran(SQLString); 
            }
            else
                return false;
        }

        void LIALIB(DataTable dt, ArrayList SQLString, StringBuilder strSql, SmartDeviceProjectEntity.JSKLIA _modelTre, SmartDeviceProjectEntity.JSKLIB _modelFor, string personNum, string orderType, SmartDeviceProjectEntity.HDTBAR _model)
        {
            SQLString.Clear();
            
            _modelTre.LIA001 = _model.BAR010 = storageOfOddNumJSKLIA();
            _modelTre.LIA002 = "条码";
            _modelTre.LIA003 = DateTime.Now.ToString("yyyyMMdd"); 
            _modelTre.LIA004 = orderType;
            _modelTre.LIA005 = personNum;          
            _modelTre.LIA012 = "F";
            DataTable da = GetDataTableJSKLIA(personNum);
            if (da != null && da.Rows.Count > 0)
            {
                _modelTre.LIA016 = da.Rows[0]["DBA005"].ToString();
            }
            else
                _modelTre.LIA016 = string.Empty;
            SQLString.Add(IsertJSKLIA(_modelTre, strSql));
            _modelFor.LIB001 = _modelTre.LIA001;
            List<string> strList = new List<string>();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _model.BAR009 = dt.Rows[i]["IBB001"].ToString();
                _model.BAR008 = dt.Rows[i]["BAR008"].ToString();
                _model.BAR020 = string.IsNullOrEmpty(dt.Rows[i]["BAR020"].ToString()) == true ? 0 : Convert.ToInt32(dt.Rows[i]["BAR020"].ToString());

                _model.BAR020 += getCkNum(_model.BAR008);


                SQLString.Add(EditHDTBAR(strSql, _model));
            }

            string[] fileNames = { "BAR001", "BAR007" };
            DataTable ds = distinct(dt, fileNames);
            for (int k = 0; k < ds.Rows.Count; k++)
            {
                _modelFor.LIB003 = ds.Rows[k]["BAR001"].ToString();

                //if (!string.IsNullOrEmpty(dt.Select("BAR001='" + _modelFor.LIB003 + "'").Length.ToString()))
                //    _modelFor.LIB008 = dt.Select("BAR001='" + _modelFor.LIB003 + "'").Length;
                //else
                //    _modelFor.LIB008 = 0;

                _modelFor.LIB008 = string.IsNullOrEmpty(dt.Rows[k]["BAR020"].ToString()) == true ? 0 : Convert.ToInt32(dt.Rows[k]["BAR020"].ToString());

                if (strList.Count < 1)
                    _modelFor.LIB002 = "001";
                else
                {
                    _modelFor.LIB002 = maxStrList(strList).ToString();
                    if (Convert.ToInt32(_modelFor.LIB002) < 9)
                        _modelFor.LIB002 = "00" + (Convert.ToInt32(_modelFor.LIB002) + 1).ToString();
                    else if (Convert.ToInt32(_modelFor.LIB002) >= 9 && Convert.ToInt32(_modelFor.LIB002) < 99)
                        _modelFor.LIB002 = "0" + (Convert.ToInt32(_modelFor.LIB002) + 1).ToString();
                    else
                        _modelFor.LIB002 = (Convert.ToInt32(_modelFor.LIB002) + 1).ToString();
                }
                strList.Add(_modelFor.LIB002);
                DataTable de = GetDataTableJSKLIB(_modelFor.LIB003);
                if (de != null && de.Rows.Count > 0)
                {
                    _modelFor.LIB004 = de.Rows[0]["DEA002"].ToString();
                    _modelFor.LIB005 = de.Rows[0]["DEA003"].ToString();
                    _modelFor.LIB006 = de.Rows[0]["DEA008"].ToString();
                    _modelFor.LIB024 = de.Rows[0]["DEA057"].ToString();
                    _modelFor.LIB960 = de.Rows[0]["BAR007"].ToString();
                    _modelFor.LIB980 = Math.Round(acreage(de.Rows[0]["DEA057"].ToString()) * _modelFor.LIB008, 2);
                    _modelFor.LIB961 = de.Rows[0]["DEA961"].ToString();
                    _modelFor.LIB019 = de.Rows[0]["BAR007"].ToString();
                    //_modelFor.LIB008 = string.IsNullOrEmpty(de.Rows[0]["COUN"].ToString()) == true ? 0 : Convert.ToInt32(de.Rows[0]["COUN"].ToString());
                }
                else
                {
                    _modelFor.LIB004 = string.Empty;
                    _modelFor.LIB005 = string.Empty;
                    _modelFor.LIB006 = string.Empty;
                    _modelFor.LIB024 = string.Empty;
                    _modelFor.LIB960 = string.Empty;
                    _modelFor.LIB980 = 0;
                    _modelFor.LIB961 = string.Empty;
                    _modelFor.LIB019 = string.Empty;
                    //_modelFor.LIB008 = 0;
                }

                _modelFor.LIB007 = -1;
                _modelFor.LIB011 = "F";
                
                _modelFor.LIB020 = 1;
                _modelFor.LIB021 = 1;
                _modelFor.LIB022 = _modelFor.LIB005;
                _modelFor.LIB023 = _modelFor.LIB008;

                SQLString.Add(IsertJSKLIB(_modelFor, strSql));
            }
        }

        void KEAKEB(DataTable dt, ArrayList SQLString, StringBuilder strSql, SmartDeviceProjectEntity.JSKKEA _modelOne, SmartDeviceProjectEntity.JSKKEB _modelTwo, string personNum, string orderType, SmartDeviceProjectEntity.HDTBAR _model)
        {
            try
            {
                SQLString.Clear();
                DataTable da, de; int num = 0;
                List<string> strCount = new List<string>(); List<string> strList = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    num = 0;
                    _model.BAR009 = dt.Rows[i]["IBB001"].ToString().Trim();
                    if (i == 0)
                    {
                        strCount.Add(_model.BAR009);
                        _modelOne.KEA001 = _model.BAR010 = storageOfOddNum();
                    }
                    else
                    {
                        if (!strCount.Contains(_model.BAR009))
                        {
                            _modelOne.KEA001 = _model.BAR010 = (Convert.ToInt64(_modelOne.KEA001) + 1).ToString();
                            strCount.Add(_model.BAR009);
                        }
                    }
                    _model.BAR008 = dt.Rows[i]["BAR008"].ToString();
                    _model.BAR020 = string.IsNullOrEmpty(dt.Rows[i]["BAR020"].ToString()) == true ? 0 : Convert.ToInt32(dt.Rows[i]["BAR020"].ToString());
                    num = _model.BAR020;
                    _model.BAR020 += getCkNum(_model.BAR008);
                    _modelOne.KEA002 = "条码";
                    _modelOne.KEA003 = DateTime.Now.ToString("yyyyMMdd");
                    da = GetDataTableJSKKEA(_model.BAR009);
                    if (da != null && da.Rows.Count > 0)
                    {
                        _modelOne.KEA004 = da.Rows[0]["IBA004"].ToString();
                        _modelOne.KEA005 = da.Rows[0]["DFA001"].ToString();
                        _modelOne.KEA006 = "";
                        _modelOne.KEA007 = da.Rows[0]["IBA006"].ToString();
                        _modelOne.KEA008 = "RMB";
                        _modelOne.KEA040 = "F";
                    }
                    else
                    {
                        _modelOne.KEA004 = string.Empty;
                        _modelOne.KEA005 = string.Empty;
                        _modelOne.KEA006 = string.Empty;
                        _modelOne.KEA007 = string.Empty;
                        _modelOne.KEA008 = string.Empty;
                        _modelOne.KEA040 = string.Empty;
                    }
                    string str = InsertJSKKEA(_modelOne, strSql);
                    if (SQLString.Count < 1)
                        SQLString.Add(str);
                    else
                    {
                        if (!SQLString.Contains(str))
                            SQLString.Add(str);
                    }
                    str = "";
                    str = EditHDTBAR(strSql, _model);
                    if (SQLString.Count < 1)
                        SQLString.Add(str);
                    else
                    {
                        if (!SQLString.Contains(str))
                            SQLString.Add(str);
                    }

                    _modelTwo.KEB001 = _modelOne.KEA001;
                    de = GetDataTableJSKKEB(_model.BAR009, _model.BAR008);
                    if (de != null && de.Rows.Count > 0)
                    {
                        for (int k = 0; k < de.Rows.Count; k++)
                        {
                            if (strList.Count < 1)
                                _modelTwo.KEB002 = "001";
                            else
                            {
                                _modelTwo.KEB002 = maxStrList(strList).ToString();
                                if (Convert.ToInt32(_modelTwo.KEB002) < 9)
                                    _modelTwo.KEB002 = "00" + (Convert.ToInt32(_modelTwo.KEB002) + 1).ToString();
                                else if (Convert.ToInt32(_modelTwo.KEB002) >= 9 && Convert.ToInt32(_modelTwo.KEB002) < 99)
                                    _modelTwo.KEB002 = "0" + (Convert.ToInt32(_modelTwo.KEB002) + 1).ToString();
                                else
                                    _modelTwo.KEB002 = (Convert.ToInt32(_modelTwo.KEB002) + 1).ToString();
                            }
                            strList.Add(_modelTwo.KEB002);

                            _modelTwo.KEB003 = de.Rows[k]["IBB003"].ToString();
                            _modelTwo.KEB004 = de.Rows[k]["IBB004"].ToString();
                            _modelTwo.KEB005 = de.Rows[k]["IBB005"].ToString();
                            _modelTwo.KEB006 = de.Rows[k]["DEA008"].ToString();
                            //_modelTwo.KEB007 = string.IsNullOrEmpty(de.Rows[k]["IBB006"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB006"].ToString());
                            _modelTwo.KEB037 = _modelTwo.KEB007 = num;
                            _modelTwo.KEB009 = string.IsNullOrEmpty(de.Rows[k]["IBB008"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB008"].ToString());
                            _modelTwo.KEB010 = string.IsNullOrEmpty(de.Rows[k]["IBB009"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB009"].ToString());
                            _modelTwo.KEB011 = string.IsNullOrEmpty(de.Rows[k]["IBB010"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB010"].ToString());
                            _modelTwo.KEB012 = string.IsNullOrEmpty(de.Rows[k]["IBB011"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB011"].ToString());
                            _modelTwo.KEB013 = de.Rows[k]["IBB012"].ToString();
                            _modelTwo.KEB015 = "32";
                            _modelTwo.KEB016 = dt.Rows[i]["IBB001"].ToString();
                            _modelTwo.KEB017 = de.Rows[k]["IBB002"].ToString();
                            _modelTwo.KEB019 = string.IsNullOrEmpty(de.Rows[k]["IBB021"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB021"].ToString());
                            _modelTwo.KEB020 = string.IsNullOrEmpty(de.Rows[k]["IBB022"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB022"].ToString());
                            _modelTwo.KEB021 = "F";
                            _modelTwo.KEB029 = string.IsNullOrEmpty(de.Rows[k]["IBB031"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB031"].ToString());
                            _modelTwo.KEB030 = string.IsNullOrEmpty(de.Rows[k]["IBB032"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB032"].ToString());
                            _modelTwo.KEB031 = string.IsNullOrEmpty(de.Rows[k]["IBB033"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB033"].ToString());
                            _modelTwo.KEB034 = 1;
                            _modelTwo.KEB035 = 1;
                            _modelTwo.KEB036 = de.Rows[k]["IBB038"].ToString();
                            //_modelTwo.KEB037 = string.IsNullOrEmpty(de.Rows[k]["IBB039"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB039"].ToString());
                            _modelTwo.KEB039 = string.IsNullOrEmpty(de.Rows[k]["IBB040"].ToString()) == true ? 0 : Convert.ToDecimal(de.Rows[k]["IBB040"].ToString());
                            _modelTwo.KEB040 = de.Rows[k]["IBB041"].ToString();
                            _modelTwo.KEB041 = de.Rows[k]["BAR007"].ToString();
                            _modelTwo.KEB960 = de.Rows[k]["BAR007"].ToString();
                            _modelTwo.KEB980 = Math.Round(acreage(de.Rows[k]["DEA057"].ToString()) * _modelTwo.KEB007, 2);
                            _modelTwo.KEB961 = de.Rows[k]["DEA961"].ToString();
                            str = "";
                            str = IsertJSKKEB(_modelTwo, strSql);
                            if (SQLString.Count < 1)
                                SQLString.Add(str);
                            else
                            {
                                if (!SQLString.Contains(str))
                                    SQLString.Add(str);
                            }
                        }
                    }
                    else
                    {
                        if (strList.Count < 1)
                            _modelTwo.KEB002 = "001";
                        else
                        {
                            _modelTwo.KEB002 = maxStrList(strList).ToString();
                            if (Convert.ToInt32(_modelTwo.KEB002) < 9)
                                _modelTwo.KEB002 = "00" + (Convert.ToInt32(_modelTwo.KEB002) + 1).ToString();
                            else if (Convert.ToInt32(_modelTwo.KEB002) >= 9 && Convert.ToInt32(_modelTwo.KEB002) < 99)
                                _modelTwo.KEB002 = "0" + (Convert.ToInt32(_modelTwo.KEB002) + 1).ToString();
                            else
                                _modelTwo.KEB002 = (Convert.ToInt32(_modelTwo.KEB002) + 1).ToString();
                        }
                        strList.Add(_modelTwo.KEB002);
                        _modelTwo.KEB003 = string.Empty;
                        _modelTwo.KEB004 = string.Empty;
                        _modelTwo.KEB005 = string.Empty;
                        _modelTwo.KEB006 = string.Empty;
                        _modelTwo.KEB007 = 0;
                        _modelTwo.KEB009 = 0;
                        _modelTwo.KEB010 = 0;
                        _modelTwo.KEB011 = 0;
                        _modelTwo.KEB012 = 0;
                        _modelTwo.KEB013 = string.Empty;
                        _modelTwo.KEB015 = "32";
                        _modelTwo.KEB016 = string.Empty;
                        _modelTwo.KEB017 = string.Empty;
                        _modelTwo.KEB019 = 0;
                        _modelTwo.KEB020 = 0;
                        _modelTwo.KEB021 = "F";
                        _modelTwo.KEB029 = 0;
                        _modelTwo.KEB030 = 0;
                        _modelTwo.KEB031 = 0;
                        _modelTwo.KEB034 = 1;
                        _modelTwo.KEB035 = 1;
                        _modelTwo.KEB036 = string.Empty;
                        _modelTwo.KEB037 = 0;
                        _modelTwo.KEB039 = 0;
                        _modelTwo.KEB040 = string.Empty;
                        _modelTwo.KEB960 = string.Empty;
                        _modelTwo.KEB980 = 0;
                        _modelTwo.KEB961 = string.Empty;
                        str = "";
                        str = IsertJSKKEB(_modelTwo, strSql);
                        if (SQLString.Count < 1)
                            SQLString.Add(str);
                        else
                        {
                            if (!SQLString.Contains(str))
                                SQLString.Add(str);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\r" + ex.StackTrace);
            }
        }

        /// <summary>
        /// 计算面积
        /// </summary>
        /// <param name="speci"></param>
        /// <returns></returns>
        Decimal acreage(string speci)
        {
            if (!string.IsNullOrEmpty(speci))
            {
                string[] str = speci.Split('*');
                if (str.Length >= 2)
                    return Math.Round(Convert.ToDecimal(str[0]) * Convert.ToDecimal(str[1]) * Convert.ToDecimal(str[2]), 4);
                else
                    return 0;
            }
            else
                return 0;
        }

        /// <summary>
        /// 获取出库数量
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        int getCkNum(string num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ISNULL(BAR020,0) BAR020 FROM HDTBAR ");
            strSql.AppendFormat("WHERE BAR008='{0}'", num);

            DataTable dt = SqlHelper.ExecuteDataTable(strSql.ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dt.Rows[0]["BAR020"].ToString()))
                    return 0;
                else
                    return Convert.ToInt32(dt.Rows[0]["BAR020"].ToString());
            }
            else
                return 0;
        }

        /// <summary>
        /// 去重复行
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        DataTable distinct(DataTable dt, string[] fileName)
        {
            DataView dv = dt.DefaultView;
            DataTable disti = dv.ToTable("Dist", true, fileName);
            return disti;
        }

        /// <summary>
        /// 获取list中最大值
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        int maxStrList(List<string> strList)
        {
            int idx = 0;
            foreach (string str in strList)
            {
                if (idx == 0)
                    idx = Convert.ToInt32(str);
                else
                {
                    if (idx < Convert.ToInt32(str))
                        idx = Convert.ToInt32(str);
                }
            }

            return idx;
        }
        /// <summary>
        /// 获取JSKKEA对应字段数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableJSKKEA(string orderNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT IBA004,IBA005,IBA006,DFA001 FROM DCSIBB A RIGHT JOIN DCSIBA B ON A.IBB001=B.IBA001 LEFT JOIN TPADFA C ON B.IBA004=C.DFA001 ");
            strSql.AppendFormat("WHERE IBB001='{0}'", orderNum);

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }
        /// <summary>
        /// 获取JSKKEB对应字段数据
        /// </summary>
        /// <param name="orderNum"></param>
        /// <returns></returns>
        public DataTable GetDataTableJSKKEB(string orderNum,string lotId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT IBB002,IBB003,IBB004,IBB005,DEA008,IBB006,IBB008,IBB009,IBB010,IBB011,IBB012,IBB021,IBB022,IBB031,IBB032,IBB033,IBB038,IBB039,IBB040,IBB002,IBB041,DEA057,IBB960,DEA961,ISNULL(BAR007,'') BAR007 FROM DCSIBB A LEFT JOIN TPADEA B ON A.IBB003=B.DEA001 LEFT JOIN HDTBAR C ON A.IBB003=C.BAR001 AND A.IBB004=C.BAR002 ");
            strSql.AppendFormat("WHERE IBB001='{0}' AND BAR008='{1}'", orderNum, lotId);

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }
        /// <summary>
        /// 获取JSKLIA对应的字段数据
        /// </summary>
        /// <param name="pingNum"></param>
        /// <returns></returns>
        public DataTable GetDataTableJSKLIA(string personNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DBA005 FROM TPADBA ");
            strSql.AppendFormat("WHERE DBA001='{0}'", personNum);

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }
        /// <summary>
        /// 获取JSKLIB对应的字段数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableJSKLIB(string pingNum)
        {
            //DEA008仓库    DEA003辅助单位   DEA057规格
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DEA008,DEA003,DEA057,DEA002,BAR007,COUNT(1) COUN,DEA961 FROM TPADEA A INNER JOIN HDTBAR B ON A.DEA001=B.BAR001 ");
            strSql.AppendFormat("WHERE DEA001='{0}'", pingNum);
            strSql.Append(" GROUP BY DEA008,DEA003,DEA057,DEA002,BAR007,DEA961");

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }
        /// <summary>
        /// 增加记录到JSKKEA
        /// </summary>
        /// <param name="_modelOne"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        string InsertJSKKEA(SmartDeviceProjectEntity.JSKKEA _modelOne,StringBuilder strSql)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO JSKKEA (");
            strSql.Append("KEA001,KEA002,KEA003,KEA004,KEA005,KEA006,KEA007,KEA008,KEA040)");
            strSql.Append(" VALUES (");
            strSql.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", _modelOne.KEA001, _modelOne.KEA002, _modelOne.KEA003, _modelOne.KEA004, _modelOne.KEA005, _modelOne.KEA006, _modelOne.KEA007, _modelOne.KEA008, _modelOne.KEA040);

            return strSql.ToString();
        }
        /// <summary>
        /// 增加记录到JSKKEB
        /// </summary>
        /// <param name="_modelTwo"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        string IsertJSKKEB(SmartDeviceProjectEntity.JSKKEB _modelTwo, StringBuilder strSql)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO JSKKEB (");
            strSql.Append("KEB001,KEB002,KEB003,KEB004,KEB005,KEB006,KEB007,KEB009,KEB010,KEB011,KEB012,KEB013,KEB015,KEB016,KEB017,KEB019,KEB020,KEB021,KEB029,KEB030,KEB031,KEB034,KEB035,KEB036,KEB037,KEB039,KEB040,KEB041,KEB960,KEB980,KEB961)");
            strSql.Append(" VALUES (");
            strSql.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}')",
                _modelTwo.KEB001, _modelTwo.KEB002, _modelTwo.KEB003, _modelTwo.KEB004, _modelTwo.KEB005, _modelTwo.KEB006, _modelTwo.KEB007, _modelTwo.KEB009, _modelTwo.KEB010, _modelTwo.KEB011,
                _modelTwo.KEB012, _modelTwo.KEB013, _modelTwo.KEB015, _modelTwo.KEB016, _modelTwo.KEB017, _modelTwo.KEB019, _modelTwo.KEB020, _modelTwo.KEB021, _modelTwo.KEB029, _modelTwo.KEB030,
                _modelTwo.KEB031, _modelTwo.KEB034, _modelTwo.KEB035, _modelTwo.KEB036, _modelTwo.KEB037, _modelTwo.KEB039, _modelTwo.KEB040, _modelTwo.KEB041, _modelTwo.KEB960, _modelTwo.KEB980,
                _modelTwo.KEB961);

            return strSql.ToString();
        }
        /// <summary>
        /// 增加记录到JSKLIA
        /// </summary>
        /// <param name="_modelTre"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        string IsertJSKLIA(SmartDeviceProjectEntity.JSKLIA _modelTre,StringBuilder strSql)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO JSKLIA (");
            strSql.Append("LIA001,LIA002,LIA003,LIA004,LIA005,LIA012,LIA016)");
            strSql.Append(" VALUES (");
            strSql.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", _modelTre.LIA001, _modelTre.LIA002, _modelTre.LIA003, _modelTre.LIA004, _modelTre.LIA005, _modelTre.LIA012, _modelTre.LIA016);

            return strSql.ToString();
        }
        /// <summary>
        /// 增加记录到JSKLIB
        /// </summary>
        /// <param name="_modelFor"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        string IsertJSKLIB(SmartDeviceProjectEntity.JSKLIB _modelFor,StringBuilder strSql)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO JSKLIB(");
            strSql.Append("LIB001,LIB002,LIB003,LIB004,LIB005,LIB006,LIB007,LIB008,LIB011,LIB019,LIB020,LIB021,LIB022,LIB023,LIB024,LIB960,LIB961,LIB980)");
            strSql.Append(" VALUES (");
            strSql.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')", _modelFor.LIB001, _modelFor.LIB002, _modelFor.LIB003, _modelFor.LIB004, _modelFor.LIB005, _modelFor.LIB006, _modelFor.LIB007, _modelFor.LIB008, _modelFor.LIB011, _modelFor.LIB019, _modelFor.LIB020, _modelFor.LIB021, _modelFor.LIB022, _modelFor.LIB023, _modelFor.LIB024, _modelFor.LIB960, _modelFor.LIB961, _modelFor.LIB980);

            return strSql.ToString();
        }
        /// <summary>
        /// 编辑条码记录表状态
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        string EditHDTBAR( StringBuilder strSql, SmartDeviceProjectEntity.HDTBAR _model)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE HDTBAR SET ");
            strSql.Append("BAR013='T',");
            strSql.Append("BAR016='F',");
            strSql.AppendFormat("BAR010='{0}',", _model.BAR010);
            strSql.AppendFormat("BAR009='{0}',", _model.BAR009);
            strSql.AppendFormat("BAR015='{0}',", DateTime.Now);
            strSql.AppendFormat("BAR020='{0}'", _model.BAR020);
            strSql.AppendFormat(" WHERE BAR008='{0}'", _model.BAR008);

            return strSql.ToString();
        }
        /// <summary>
        /// 获取出库单号  JSKKEA
        /// </summary>
        /// <returns></returns>
        public string storageOfOddNum()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(KEA001) KEA001 FROM JSKKEA ");
            strSql.Append("WHERE KEA001 LIKE '" + DateTime.Now.ToString("yyyyMMdd") + "%'");

            DataTable da = SqlHelper.ExecuteDataTable(strSql.ToString());
            string strOdd = "";
            if (da != null && da.Rows.Count > 0)
            {
                strOdd = da.Rows[0]["KEA001"].ToString();
                if (string.IsNullOrEmpty(strOdd))
                    strOdd = DateTime.Now.ToString("yyyyMMdd") + "001";
                else
                    strOdd = (Convert.ToInt64(strOdd) + 1).ToString();
            }
            else
                strOdd = DateTime.Now.ToString("yyyyMMdd") + "001";

            return strOdd;
        }
        /// <summary>
        /// 获取出库单号  JSKLIA 
        /// </summary>
        /// <returns></returns>
        public string storageOfOddNumJSKLIA()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(LIA001) LIA001 FROM JSKLIA ");
            strSql.Append("WHERE LIA001 LIKE '" + DateTime.Now.ToString("yyyyMMdd") + "%'");

            DataTable da = SqlHelper.ExecuteDataTable(strSql.ToString());
            string strOdd = "";
            if (da != null && da.Rows.Count > 0)
            {
                strOdd = da.Rows[0]["LIA001"].ToString();
                if (string.IsNullOrEmpty(strOdd))
                    strOdd = DateTime.Now.ToString("yyyyMMdd") + "001";
                else
                    strOdd = (Convert.ToInt64(strOdd) + 1).ToString();
            }
            else
                strOdd = DateTime.Now.ToString("yyyyMMdd") + "001";

            return strOdd;
        }

        /// <summary>
        /// 获取轴号
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string zh(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("SELECT BAR007 FROM HDTBAR WHERE BAR018='{0}'", code);

            DataTable dt = SqlHelper.ExecuteDataTable(strSql.ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dt.Rows[0]["BAR007"].ToString()))
                    return string.Empty;
                else
                    return dt.Rows[0]["BAR007"].ToString();
            }
            else
                return string.Empty;
        }

        /// <summary>
        /// 根据轴号  获取Lot Id
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        public string lotidDt( string spe,string lotId )
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("SELECT DISTINCT BAR008 FROM HDTBAR WHERE BAR004='{0}' AND BAR007='{1}'  AND ISNULL(BAR020,0)<ISNULL(BAR019,0) ", spe, lotId);

            DataTable dt = SqlHelper.ExecuteDataTable(strSql.ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dt.Rows[0]["BAR008"].ToString()))
                    return string.Empty;
                else
                    return dt.Rows[0]["BAR008"].ToString();
            }
            else
                return string.Empty;
        }

        /// <summary>
        /// 根据轴号  获取Spe
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        public DataTable lotidDt(string lotId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("SELECT DISTINCT BAR004 FROM HDTBAR WHERE BAR008='{0}'AND ISNULL(BAR020,0)<ISNULL(BAR019,0) ", lotId);

            return SqlHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 获取剩余出库数量
        /// </summary>
        /// <param name="lotId"></param>
        /// <returns></returns>
        public int lotNum(string lotId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("SELECT ISNULL(BAR019,0)-ISNULL(BAR020,0) BAR FROM HDTBAR WHERE BAR008='{0}'", lotId);

            DataTable dt = SqlHelper.ExecuteDataTable(strSql.ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dt.Rows[0]["BAR"].ToString()))
                    return 0;
                else
                    return Convert.ToInt32(dt.Rows[0]["BAR"].ToString());
            }
            else
                return 0;
        }

    }
}
