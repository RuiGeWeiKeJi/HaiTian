using System;
using System . Collections . Generic;
using System . Text;
using System . Data;
using StudentMgr;
using System . Data . SqlClient;
using System . Collections;

namespace barCodeDao . Dao
{
    public class barCodeReportDao
    {
        public barCodeReportDao ( )
        {

        }
        
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetDataSet ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT * FROM HDTBAR" );

            return SqlHelper . Query ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTable ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT A.idx,BAR001,BAR002,BAR003,BAR004,BAR005,BAR006,BAR007,BAR008,BAR009,BAR016,BAR017,BAR018,BAR019,BAR020,BAR022,BAR023,BAR024,BAR025,0.00 BAR0,0.00 BAR3,DEA980 FROM HDTBAR A LEFT JOIN TPADEA B ON A.BAR001=B.DEA001 " );
            strSql . Append ( "WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public barCodeEntity . barCodeReportEntity GetModel ( DataRow row )
        {
            barCodeEntity . barCodeReportEntity _model = new barCodeEntity . barCodeReportEntity ( );

            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                    _model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                if ( row [ "BAR001" ] != null && row [ "BAR001" ] . ToString ( ) != "" )
                    _model . BAR001 = row [ "BAR001" ] . ToString ( );
                if ( row [ "BAR002" ] != null && row [ "BAR002" ] . ToString ( ) != "" )
                    _model . BAR002 = row [ "BAR002" ] . ToString ( );
                if ( row [ "BAR003" ] != null && row [ "BAR003" ] . ToString ( ) != "" )
                    _model . BAR003 = row [ "BAR003" ] . ToString ( );
                if ( row [ "BAR004" ] != null && row [ "BAR004" ] . ToString ( ) != "" )
                    _model . BAR004 = row [ "BAR004" ] . ToString ( );
                if ( row [ "BAR005" ] != null && row [ "BAR005" ] . ToString ( ) != "" )
                    _model . BAR005 = row [ "BAR005" ] . ToString ( );
                if ( row [ "BAR006" ] != null && row [ "BAR006" ] . ToString ( ) != "" )
                    _model . BAR006 = row [ "BAR006" ] . ToString ( );
                if ( row [ "BAR007" ] != null && row [ "BAR007" ] . ToString ( ) != "" )
                    _model . BAR007 = row [ "BAR007" ] . ToString ( );
                if ( row [ "BAR008" ] != null && row [ "BAR008" ] . ToString ( ) != "" )
                    _model . BAR008 = row [ "BAR008" ] . ToString ( );
                if ( row [ "BAR009" ] != null && row [ "BAR009" ] . ToString ( ) != "" )
                    _model . BAR009 = row [ "BAR009" ] . ToString ( );
                if ( row [ "BAR010" ] != null && row [ "BAR010" ] . ToString ( ) != "" )
                    _model . BAR010 = row [ "BAR010" ] . ToString ( );
                if ( row [ "BAR011" ] != null && row [ "BAR011" ] . ToString ( ) != "" )
                    _model . BAR011 = row [ "BAR011" ] . ToString ( );
                if ( row [ "BAR012" ] != null && row [ "BAR012" ] . ToString ( ) != "" )
                    _model . BAR012 = row [ "BAR012" ] . ToString ( );
                if ( row [ "BAR013" ] != null && row [ "BAR013" ] . ToString ( ) != "" )
                    _model . BAR013 = row [ "BAR013" ] . ToString ( );
                if ( row [ "BAR014" ] != null && row [ "BAR014" ] . ToString ( ) != "" )
                    _model . BAR014 = DateTime . Parse ( row [ "BAR014" ] . ToString ( ) );
                if ( row [ "BAR015" ] != null && row [ "BAR015" ] . ToString ( ) != "" )
                    _model . BAR015 = DateTime . Parse ( row [ "BAR015" ] . ToString ( ) );
                if ( row [ "BAR016" ] != null && row [ "BAR016" ] . ToString ( ) != "" )
                    _model . BAR016 = row [ "BAR016" ] . ToString ( );
                if ( row [ "BAR017" ] != null && row [ "BAR017" ] . ToString ( ) != "" )
                    _model . BAR017 = row [ "BAR017" ] . ToString ( );
            }

            return _model;
        }

        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete ( string idxList )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM HDTBAR" );
            strSql . Append ( " WHERE idx in ("+idxList+")" );

            int row = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="idxList"></param>
        /// <param name="stateOfLibrary">出库</param>
        /// <param name="stateOfStorage">入库</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public bool Edit ( int idxList ,string remark ,string orderNum ,string saoMiao ,string rkNum ,string ckNum ,string dt ,string batchS )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE HDTBAR SET " );
            strSql . Append ( "BAR016=@BAR016," );
            strSql . Append ( "BAR017=@BAR017," );
            strSql . Append ( "BAR009=@BAR009," );
            strSql . Append ( "BAR019=@BAR019," );
            strSql . Append ( "BAR020=@BAR020," );
            strSql . Append ( "BAR024=@BAR024," );
            strSql . Append ( "BAR025=@BAR025 " );
            strSql . Append ( "  WHERE idx=@idx" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@BAR017",SqlDbType.NVarChar,200),
                new SqlParameter("@BAR009",SqlDbType.NVarChar,20),
                new SqlParameter("@BAR016",SqlDbType.NChar,10),
                new SqlParameter("@BAR019",SqlDbType.Int,4),
                new SqlParameter("@BAR020",SqlDbType.Int,4),
                new SqlParameter("@BAR024",SqlDbType.Date,3),
                new SqlParameter("@BAR025",SqlDbType.NVarChar,255),
                new SqlParameter("@idx",SqlDbType.Int)
            };
            parameter [ 0 ] . Value = remark;
            parameter [ 1 ] . Value = orderNum;
            parameter [ 2 ] . Value = saoMiao;
            parameter [ 3 ] . Value = Convert . ToInt32 ( rkNum );
            parameter [ 4 ] . Value = Convert . ToInt32 ( ckNum );
            if ( string . IsNullOrEmpty ( dt ) )
                parameter [ 5 ] . Value = DBNull . Value;
            else
                parameter [ 5 ] . Value = Convert . ToDateTime ( dt );
            parameter [ 6 ] . Value = batchS;
            parameter [ 7 ] . Value = idxList;

            int row = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
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
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE HDTBAR SET " );
            strSql . Append ( "BAR012=@BAR012," );
            if ( stateOfLibrary . Equals ( "F" ) )
                strSql . Append ( "BAR011='',BAR014=NULL," );
            strSql . Append ( "BAR013=@BAR013" );
            if ( stateOfStorage . Equals ( "F" ) )
                strSql . Append ( ",BAR010='',BAR015=NULL " );
            strSql . Append ( "  WHERE idx IN (" + idxList + ")" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@BAR012",SqlDbType.NChar,10),
                new SqlParameter("@BAR013",SqlDbType.NChar,10)
            };
            parameter [ 0 ] . Value = stateOfLibrary;
            parameter [ 1 ] . Value = stateOfStorage;

            int row = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取Lot ID
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDa ( string strWhere ,string spec ,string zh)
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT BAR018 FROM HDTBAR " );
            strSql . AppendFormat ( " WHERE BAR018 LIKE '{0}%' AND BAR004='{1}' AND BAR007='{2}'" ,strWhere ,spec ,zh );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取ID
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetDaT ( string str )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT BAR018 FROM HDTBAR " );
            strSql . AppendFormat ( " WHERE BAR018='{0}'" ,str );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "BAR018" ] . ToString ( ) ) )
                    return string . Empty;
                else
                    return dt . Rows [ 0 ] [ "BAR018" ] . ToString ( );
            }
            else
                return string . Empty;
        }

        /// <summary>
        /// 增加记录
        /// </summary>
        /// <param name="_modelList"></param>
        /// <returns></returns>
        public bool Save ( barCodeEntity . barCodeReportEntity _model ,long num ,string serialNum )
        {
            Hashtable SQLString = new Hashtable ( );
            if ( _model != null )
            {
                StringBuilder strSql = new StringBuilder ( );
                SqlParameter [ ] parameter = null;

                if ( Exists ( _model . BAR018 ) == false )
                {                  
                    strSql . Append ( "INSERT INTO HDTBAR (" );
                    strSql . Append ( "BAR001,BAR002,BAR003,BAR004,BAR005,BAR006,BAR007,BAR008,BAR012,BAR013,BAR016,BAR018,BAR019,BAR020,BAR022,BAR023)" );                    strSql . Append ( " VALUES (" );
                    strSql . Append ( "@BAR001,@BAR002,@BAR003,@BAR004,@BAR005,@BAR006,@BAR007,@BAR008,@BAR012,@BAR013,@BAR016,@BAR018,0,0,GETDATE(),@BAR023)" );
                    //strSql . Append ( "SELECT SCOPE_IDENTITY();" );
                    parameter = new SqlParameter [ ] {
                        new SqlParameter("@BAR001",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR002",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR003",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR004",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR005",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR006",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR007",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR008",SqlDbType.NVarChar,60),
                        new SqlParameter("@BAR012",SqlDbType.NChar,10),
                        new SqlParameter("@BAR013",SqlDbType.NChar,10),
                        new SqlParameter("@BAR016",SqlDbType.NChar,10),
                        new SqlParameter("@BAR018",SqlDbType.NVarChar,40),
                        new SqlParameter("@BAR023",SqlDbType.Int,4)
                         };
                    parameter [ 0 ] . Value = _model . BAR001;
                    parameter [ 1 ] . Value = _model . BAR002;
                    parameter [ 2 ] . Value = _model . BAR003;
                    parameter [ 3 ] . Value = _model . BAR004;
                    parameter [ 4 ] . Value = _model . BAR005;
                    parameter [ 5 ] . Value = _model . BAR006;
                    parameter [ 6 ] . Value = _model . BAR007;
                    parameter [ 7 ] . Value = _model . BAR008;
                    parameter [ 8 ] . Value = "F";
                    parameter [ 9 ] . Value = "F";
                    parameter [ 10 ] . Value = "F";
                    parameter [ 11 ] . Value = _model . BAR018;
                    parameter [ 12 ] . Value = _model . BAR023;

                    SQLString . Add ( strSql ,parameter );
                }
                else
                {
                    strSql = new StringBuilder ( );
                    strSql . Append ( "UPDATE HDTBAR SET " );
                    strSql . Append ( "BAR022=GETDATE()," );
                    strSql . AppendFormat ( "BAR023=BAR023+{0}" ,_model . BAR023 );
                    strSql . Append ( "WHERE BAR018=@BAR018" );
                    parameter = new SqlParameter [ ] {
                        new SqlParameter("@BAR018",SqlDbType.NVarChar,40)
                    };
                    parameter [ 0 ] . Value = _model . BAR018;
                    SQLString . Add ( strSql ,parameter );
                }
            }
            else
                return false;

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        bool Exists ( string lotId )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM HDTBAR " );
            strSql . AppendFormat ( "WHERE BAR018='{0}'" ,lotId );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取打印列表
        /// </summary>
        /// <param name="first"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDataTablePrint ( string first ,int num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT TOP {0} BAR002,BAR003,BAR004,BAR005,BAR018,BAR008,CONVERT(VARCHAR,CONVERT(INT,SUBSTRING(CONVERT(VARCHAR,YEAR(GETDATE())),3,2))+50)+CONVERT(VARCHAR,MONTH(GETDATE())+50)+RIGHT('0'+CONVERT(VARCHAR,DAY(GETDATE())),2) DT FROM HDTBAR A INNER JOIN TPADEA B ON 1=1 " ,num );
            strSql . AppendFormat ( " WHERE BAR018='{0}'" ,first  );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOf ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DEA001,DEA002,DEA057,DEA960,DEA961 FROM TPADEA" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取入库单据类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLaa ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DISTINCT LAA001 ,LAA002 FROM JSKLAA  WHERE LAA003='1'" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 生成入库记录
        /// </summary>
        /// <param name="idxList"></param>
        /// <param name="documentType"></param>
        /// <returns></returns>
        public bool InsertToLibrary ( List<int> idxList,string rklx ,DataTable table )
        {
            if ( idxList . Count < 1 )
                return false;
            StringBuilder strSql = new StringBuilder ( );
            ArrayList SQLString = new ArrayList ( );
            DataTable dt = LibraryDa ( idxList ,strSql );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                barCodeEntity . JSKLHA _modelOne = new barCodeEntity . JSKLHA ( );
                barCodeEntity . JSKLHB _modelTwo = new barCodeEntity . JSKLHB ( );
                barCodeEntity . barCodeReportEntity _modelTre = new barCodeEntity . barCodeReportEntity ( );
                barCodeEntity . TPADEH _modelDHE = new barCodeEntity . TPADEH ( );
                _modelTre . BAR019 = 0;
                
                _modelOne . LHA002 = "条码";
                _modelOne . LHA004 = rklx;
                _modelOne . LHA001 = _modelTwo . LHB001 = _modelTre . BAR011 = LibraryOrderOddNum ( );
                _modelOne . LHA003 = DateTime . Now . ToString ( "yyyyMMdd" );
                _modelOne . LHA012 = "F";
                
                SQLString . Add ( InsertLHA ( _modelOne ,strSql ) );
                List<string> strList = new List<string> ( );
                for ( int i = 0 ; i < dt . Rows . Count ; i++ )
                {
                    if ( strList . Count < 1 )
                        _modelTwo . LHB002 = "001";
                    else
                    {
                        _modelTwo . LHB002 = maxStrList ( strList ) . ToString ( );
                        if ( Convert . ToInt32 ( _modelTwo . LHB002 ) < 9 )
                            _modelTwo . LHB002 = "00" + ( Convert . ToInt32 ( _modelTwo . LHB002 ) + 1 ) . ToString ( );
                        else if ( Convert . ToInt32 ( _modelTwo . LHB002 ) >= 9 && Convert . ToInt32 ( _modelTwo . LHB002 ) < 99 )
                            _modelTwo . LHB002 = "0" + ( Convert . ToInt32 ( _modelTwo . LHB002 ) + 1 ) . ToString ( );
                        else
                            _modelTwo . LHB002 = ( Convert . ToInt32 ( _modelTwo . LHB002 ) + 1 ) . ToString ( );
                    }
                    strList . Add ( _modelTwo . LHB002 );

                    _modelTre . BAR008 = dt . Rows [ i ] [ "BAR008" ] . ToString ( );
                    if ( table . Select ( "BAR008='" + _modelTre . BAR008 + "'" ) . Length > 0 )
                        _modelTre . BAR019 = Convert . ToInt32 ( table . Select ( "BAR008='" + _modelTre . BAR008 + "'" ) [ 0 ] [ "BAR023" ] . ToString ( ) );

                    _modelTre . BAR023 = 0;
                    SQLString . Add ( EditBAR ( _modelTre ,strSql ) );

                    _modelTwo . LHB003 = _modelDHE . Dhe001 = dt . Rows [ i ] [ "BAR001" ] . ToString ( );
                    _modelTwo . LHB004 = dt . Rows [ i ] [ "BAR002" ] . ToString ( );
                    _modelTwo . LHB005 = dt . Rows [ i ] [ "DEA003" ] . ToString ( );
                    _modelTwo . LHB006 = dt . Rows [ i ] [ "DDA001" ] . ToString ( );
                    _modelTwo . LHB007 = 1;
                    _modelTwo . LHB008 = /*string . IsNullOrEmpty ( dt . Rows [ i ] [ "COUN" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( dt . Rows [ i ] [ "COUN" ] . ToString ( ) );*/_modelTre . BAR019;
                    _modelTwo . LHB011 = "F";
                    _modelTwo . LHB019 = _modelDHE . Dhe002 = dt . Rows [ i ] [ "BAR007" ] . ToString ( );
                    _modelTwo . LHB020 = 1;
                    _modelTwo . LHB021 = 1;
                    _modelTwo . LHB022 = dt . Rows [ i ] [ "DEA003" ] . ToString ( );
                    _modelTwo . LHB023 = _modelTwo . LHB008;
                    _modelTwo . LHB024 = dt . Rows [ i ] [ "BAR004" ] . ToString ( );
                    _modelTwo . LHB960 = dt . Rows [ i ] [ "BAR007" ] . ToString ( );
                    _modelTwo . LHB980 = Math . Round ( acreage ( dt . Rows [ i ] [ "DEA057" ] . ToString ( ) ) * _modelTwo . LHB008 ,2 );
                    _modelTwo . LHB961 = dt . Rows [ i ] [ "DEA961" ] . ToString ( );
                    _modelDHE . Dhe003 = dt . Rows [ i ] [ "BAR025" ] . ToString ( );


                    SQLString . Add ( InsertLHB ( _modelTwo ,strSql ) );
                    if ( ExistsDEH ( _modelDHE ) )
                        SQLString . Add ( UpdateDEH ( _modelDHE ,strSql ) );
                    else
                        SQLString . Add ( InsertDEH ( _modelDHE ,strSql ) );
                }

                //if ( !string . IsNullOrEmpty ( _modelOne . LHA001 ) )
                //{
                //    SQLString . Add ( EditBAR ( _modelTre ,strSql ,idxList ) );
                //}

                return SqlHelper . ExecuteSqlTran ( SQLString );
            }
            else
                return false;
        }
        
        Decimal acreage ( string speci )
        {
            if ( !string . IsNullOrEmpty ( speci ) )
            {
                string [ ] str = speci . Split ( '*' );
                if ( str . Length >= 2 )
                    return Math . Round ( Convert . ToDecimal ( str [ 0 ] ) * Convert . ToDecimal ( str [ 1 ] ) * Convert . ToDecimal ( str [ 2 ] ) ,4 );
                else
                    return 0;
            }
            else
                return 0;
        }
        
        /// <summary>
        /// 获取list中最大值
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        int maxStrList ( List<string> strList )
        {
            int idx = 0;
            foreach ( string str in strList )
            {
                if ( idx == 0 )
                    idx = Convert . ToInt32 ( str );
                else
                {
                    if ( idx < Convert . ToInt32 ( str ) )
                        idx = Convert . ToInt32 ( str );
                }
            }

            return idx;
        }

        /// <summary>
        /// LHA增加一条记录
        /// </summary>
        /// <param name="_modelOne"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public string InsertLHA ( barCodeEntity . JSKLHA _modelOne,StringBuilder strSql )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO JSKLHA (" );
            strSql . Append ( "LHA001,LHA002,LHA003,LHA004,LHA012)" );
            strSql . Append ( " VALUES (" );
            strSql . AppendFormat ( "'{0}','{1}','{2}','{3}','{4}')" ,_modelOne . LHA001 ,_modelOne . LHA002 ,_modelOne . LHA003 ,_modelOne . LHA004 ,_modelOne . LHA012 );

            return strSql . ToString ( );
        }

        /// <summary>
        /// LHB增加一条记录
        /// </summary>
        /// <param name="_modelTwo"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public string InsertLHB ( barCodeEntity . JSKLHB _modelTwo ,StringBuilder strSql )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO JSKLHB (" );
            strSql . Append ( "LHB001,LHB002,LHB003,LHB004,LHB005,LHB006,LHB007,LHB008,LHB011,LHB019,LHB020,LHB021,LHB022,LHB023,LHB024,LHB960,LHB961,LHB980)" );
            strSql . Append ( " VALUES (" );
            strSql . AppendFormat ( "'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')" ,_modelTwo . LHB001 ,_modelTwo . LHB002 ,_modelTwo . LHB003 ,_modelTwo . LHB004 ,_modelTwo . LHB005 ,_modelTwo . LHB006 ,_modelTwo . LHB007 ,_modelTwo . LHB008 ,_modelTwo . LHB011 ,_modelTwo . LHB019 ,_modelTwo . LHB020 ,_modelTwo . LHB021 ,_modelTwo . LHB022 ,_modelTwo . LHB023 ,_modelTwo . LHB024 ,_modelTwo . LHB960 ,_modelTwo . LHB961 ,_modelTwo . LHB980 );

            return strSql . ToString ( );
        }

        /// <summary>
        /// DEH是否存在
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        bool ExistsDEH ( barCodeEntity . TPADEH _model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT COUNT(1) FROM TPADEH WHERE DEH001='{0}' AND DEH002='{1}'" ,_model . Dhe001 ,_model . Dhe002 );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        /// <summary>
        /// DEH增加一条记录
        /// </summary>
        /// <param name="_model"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public string InsertDEH ( barCodeEntity . TPADEH _model ,StringBuilder strSql )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO TPADEH (" );
            strSql . Append ( "DEH001,DEH002,DEH003,DEH004,DEH005) " );
            strSql . Append ( "VALUES (" );
            strSql . AppendFormat ( "'{0}','{1}','{2}',CONVERT(varchar(100), GETDATE(), 112),CONVERT(varchar(100), GETDATE(), 112)) " ,_model . Dhe001 ,_model . Dhe002 ,_model . Dhe003 );

            return strSql . ToString ( );
        }

        /// <summary>
        /// DEH编辑一条记录
        /// </summary>
        /// <param name="_model"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public string UpdateDEH ( barCodeEntity . TPADEH _model ,StringBuilder strSql )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE TPADEH SET " );
            strSql . Append ( "DEH004=CONVERT(varchar(100), GETDATE(), 112)," );
            strSql . Append ( "DEH005=CONVERT(varchar(100), GETDATE(), 112) " );
            strSql . AppendFormat ( "WHERE DEH001='{0}' AND DEH002='{1}'" ,_model . Dhe001 ,_model . Dhe002 );
            return strSql . ToString ( );
        }

        /// <summary>
        /// 回写入库单号及标志
        /// </summary>
        /// <param name="_modelTre"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public string EditBAR ( barCodeEntity . barCodeReportEntity _modelTre ,StringBuilder strSql )
        {
            //string idxStr = "";
            //foreach ( int id in idxList )
            //{
            //    if ( idxStr == "" )
            //        idxStr = id . ToString ( );
            //    else
            //        idxStr += "," + id . ToString ( );
            //}

            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE HDTBAR SET " );
            strSql . AppendFormat ( "BAR011='{0}'," ,_modelTre . BAR011 );
            strSql . AppendFormat ( "BAR012='{0}'," ,"T" );
            strSql . AppendFormat ( "BAR014='{0}'," ,DateTime . Now . ToString ( "yyyy-MM-dd" ) );
            strSql . AppendFormat ( "BAR019=BAR019+'{0}'," ,_modelTre . BAR019 );
            strSql . AppendFormat ( "BAR023='{0}' " ,_modelTre . BAR023 );
            strSql . Append ( " WHERE BAR008='" + _modelTre . BAR008 + "'" );

            return strSql . ToString ( );
        }

        /// <summary>
        /// 获取数据源
        /// </summary>
        /// <param name="idxList"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public DataTable LibraryDa ( List<int> idxList ,StringBuilder strSql)
        {
            string idxStr = "";
            foreach ( int id in idxList )
            {
                if ( idxStr == "" )
                    idxStr = id . ToString ( );
                else
                    idxStr += "," + id . ToString ( );
            }
            strSql = new StringBuilder ( );//BAR004=DEA961
            strSql . Append ( "SELECT BAR001,BAR002,DEA003,DDA001,BAR004,DEA003,BAR007,DEA057,DEA961,BAR008,BAR024,BAR025,BAR014 FROM HDTBAR A LEFT JOIN TPADEA B ON A.BAR001=B.DEA001 LEFT JOIN TPADDA C ON B.DEA008=C.DDA001 " );
            strSql . Append ( "WHERE idx IN (" + idxStr + ")" );
            //strSql . Append ( " GROUP BY BAR001,BAR002,DEA003,DDA001,BAR004,DEA003,BAR007,DEA057,DEA961" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取入库单单号
        /// </summary>
        /// <returns></returns>
        public string LibraryOrderOddNum (  )
        {
            string oddNum = "";
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(LHA001) LHA001 FROM JSKLHA" );
            strSql . Append ( " WHERE LHA001 LIKE '" + DateTime . Now . ToString ( "yyyyMMdd" ) + "%'" );

            DataTable da = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( da != null && da . Rows . Count > 0 )
            {
                if ( !string . IsNullOrEmpty ( da . Rows [ 0 ] [ "LHA001" ] . ToString ( ) ) )
                    oddNum = ( Convert . ToInt64 ( da . Rows [ 0 ] [ "LHA001" ] . ToString ( ) ) + 1 ) . ToString ( );
                else
                    oddNum = DateTime . Now . ToString ( "yyyyMMdd" ) + "001";
            }
            else
                oddNum = DateTime . Now . ToString ( "yyyyMMdd" ) + "001";

            return oddNum;
        }

        /// <summary>
        /// 获取轴号数量
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableCount ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DISTINCT BAR018,DEA057 FROM HDTBAR A LEFT JOIN TPADEA B ON A.BAR001=B.DEA001 " );
            strSql . Append ( "WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取服务器时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetTime ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT GETDATE() t" );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "t" ] . ToString ( ) ) )
                    return DateTime . Now;
                else
                    return Convert . ToDateTime ( dt . Rows [ 0 ] [ "t" ] . ToString ( ) );
            }
            else
                return DateTime . Now;
        }

    }
}
