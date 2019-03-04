using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace barCodeEntity
{
    public class checkProductEntity
    {
        public checkProductEntity ( )
        {
        }

        private string _dea001;
        private string _dea002;
        private string _dea057;

        /// <summary>
        /// 品号
        /// </summary>
        public string DEA001
        {
            get
            {
                return _dea001;
            }
            set
            {
                _dea001 = value;
            }
        }

        /// <summary>
        /// 品名
        /// </summary>
        public string DEA002
        {
            get
            {
                return _dea002;
            }
            set
            {
                _dea002 = value;
            }
        }

        /// <summary>
        /// 规格
        /// </summary>
        public string DEA057
        {
            get
            {
                return _dea057;
            }
            set
            {
                _dea057 = value;
            }
        }
    }
}
