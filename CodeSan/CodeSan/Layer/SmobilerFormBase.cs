using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using Smobiler . Core;
using Smobiler . Core . Controls;

namespace CodeSan
{
    partial class SmobilerFormBase : Smobiler . Core . Controls . MobileForm
    {
        public SmobilerFormBase ( ) : base ( )
        {
            InitializeComponent ( );
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pClose_Press ( object sender , EventArgs e )
        {
            this . Close ( );
        }
    }
}