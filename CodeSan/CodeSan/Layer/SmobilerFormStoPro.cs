using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using Smobiler . Core;
using Smobiler . Core . Controls;
using System . Data;
using CodeSan . Utils;

namespace CodeSan . Layer
{
    partial class SmobilerFormStoPro : SmobilerFormBaseBack
    {
        private readonly CodeSanBll . Bll . StoProBll _bll;
        DataTable tableType, tableUser;

        public SmobilerFormStoPro ( ) : base ( )
        {
            //This call is required by the SmobilerForm.
            InitializeComponent ( );

            _bll = new CodeSanBll . Bll . StoProBll ( );
        }

        /// <summary>
        /// 出库类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press ( object sender , EventArgs e )
        {
            tableType = _bll . getTableForType ( Utils . BaseColumn . storage );
            try
            {
                popListType . Groups . Clear ( );
                PopListGroup typeGroup = new PopListGroup { Title = "出库类型" };
                foreach ( DataRow row in tableType.Rows )
                {
                    PopListItem item = new PopListItem
                    {
                        Value = row["LAA001"] . ToString ( ) ,
                        Text = row["LAA002"] . ToString ( )
                    };
                    typeGroup . Items . Add ( item );
                }
                popListType . Groups . Add ( typeGroup );
                this . popListType . ShowDialog ( );
            }
            catch ( Exception ex )
            {
                Toast ( ex . Message );
            }
        }

        /// <summary>
        /// 经办人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUser_Press ( object sender , EventArgs e )
        {
            tableUser = _bll . getTableForUser ( );
            try
            {
                popListUser . Groups . Clear ( );
                PopListGroup typeGroup = new PopListGroup { Title = "出库类型" };
                foreach ( DataRow row in tableUser . Rows )
                {
                    PopListItem item = new PopListItem
                    {
                        Value = row["DBA001"] . ToString ( ) ,
                        Text = row["DBA002"] . ToString ( )
                    };
                    typeGroup . Items . Add ( item );
                }
                popListUser . Groups . Add ( typeGroup );
                this . popListUser . ShowDialog ( );
            }
            catch ( Exception ex )
            {
                Toast ( ex . Message );
            }
        }

        /// <summary>
        /// 出库类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popListType_Selected ( object sender , EventArgs e )
        {
            if ( popListType . Selection != null )
            {
                labType . Text = popListType . Selection . Text;
            }
        }
        /// <summary>
        /// 经办人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popListUser_Selected ( object sender , EventArgs e )
        {
            if ( popListUser . Selection != null )
            {
                labUser . Text = popListUser . Selection . Text;
            }
        }

        private void btnCan_Press ( object sender , EventArgs e )
        {
            this . Close ( );
        }


        private void btnOk_Press ( object sender , EventArgs e )
        {

            this . Close ( );
        }

    }
}