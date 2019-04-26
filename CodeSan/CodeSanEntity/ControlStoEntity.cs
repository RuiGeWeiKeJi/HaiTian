using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace CodeSanEntity
{
    public class ControlStoEntity
    {
        private string _type;
        private string _user;

        /// <summary>
        /// 出库类型
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        /// <summary>
        /// 出库经办人
        /// </summary>
        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }
    }
}
