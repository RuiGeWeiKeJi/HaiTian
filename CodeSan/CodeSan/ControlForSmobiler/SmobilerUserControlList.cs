using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using Smobiler . Core;
using Smobiler . Core . Controls;

namespace CodeSan . ControlForSmobiler
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class SmobilerUserControlList : Smobiler . Core . Controls . MobileUserControl
    {
        public SmobilerUserControlList ( ) : base ( )
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent ( );
        }
    }
}