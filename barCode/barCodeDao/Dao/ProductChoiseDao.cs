using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Data;
using StudentMgr;

namespace barCodeDao . Dao
{
    public class ProductChoiseDao
    {
        public ProductChoiseDao ( )
        {
            
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DISTINCT BAR001,BAR002 FROM HDTBAR" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataSet (  )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT BAR009,BAR010,BAR011,BAR006,BAR007 FROM HDTBAR" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public barCodeEntity.barCodeReportEntity GetModel ( DataRow row )
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
    }
}
