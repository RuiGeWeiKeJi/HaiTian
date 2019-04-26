using System;
using Smobiler . Core . Controls;
using System . Data;

namespace CodeSan . ControlForSmobiler
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class SmobilerUserControlSto : Smobiler . Core . Controls . MobileUserControl
    {
        private readonly CodeSanBll . Bll . StoProBll _bll;
        public CodeSanEntity . ControlStoEntity _model;
        DataTable tableType, tableUser;

        public SmobilerUserControlSto ( ) : base ( )
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent ( );

            this . labelTitle . Text = Utils . BaseColumn . storage;

            _bll = new CodeSanBll . Bll . StoProBll ( );
            _model = new CodeSanEntity . ControlStoEntity ( );
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
                foreach ( DataRow row in tableType . Rows )
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
        /// 经办人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popListUser_Selected ( object sender , EventArgs e )
        {
            if ( popListUser . Selection != null )
            {
                txtUser . Text = popListUser . Selection . Text;
                txtUser . Tag = popListUser . Selection . Value;
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
                txtType . Text = popListType . Selection . Text;
                txtType . Tag = popListType . Selection . Value;
            }
        }

        private void btnCan_Press ( object sender , EventArgs e )
        {
            _model . Type = string . Empty;
            _model . User = string . Empty;
            this . Close ( );
        }
        private void btnOk_Press ( object sender , EventArgs e )
        {
            _model . Type = txtType . Tag . ToString ( );
            _model . User = txtUser . Tag . ToString ( );
            this . Close ( );
        }

    }
}