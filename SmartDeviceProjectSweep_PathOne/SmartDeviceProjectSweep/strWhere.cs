using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProjectSweep
{
    public class PassDataWinFormEventArgs   :EventArgs
    {
        private string _strWhere;
        public string StrW
        {
            get { return _strWhere; }
            set { _strWhere = value; }
        }

        public PassDataWinFormEventArgs(string StrW)
        {
            this._strWhere = StrW;
        }
    }
}
