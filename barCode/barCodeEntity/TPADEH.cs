using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace barCodeEntity
{
    public class TPADEH
    {
        public TPADEH ( )
        {

        }

        private string _dhe001;
        private string _dhe002;
        private string _dhe003;
        private DateTime? _dhe004;
        private DateTime? _dhe005;

        /// <summary>
        /// 品号
        /// </summary>
        public string Dhe001
        {
            get
            {
                return _dhe001;
            }

            set
            {
                _dhe001 = value;
            }
        }

        /// <summary>
        /// 轴号
        /// </summary>
        public string Dhe002
        {
            get
            {
                return _dhe002;
            }

            set
            {
                _dhe002 = value;
            }
        }

        /// <summary>
        /// 批号说明
        /// </summary>
        public string Dhe003
        {
            get
            {
                return _dhe003;
            }

            set
            {
                _dhe003 = value;
            }
        }

        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime? Dhe004
        {
            get
            {
                return _dhe004;
            }

            set
            {
                _dhe004 = value;
            }
        }

        /// <summary>
        /// 入库日期
        /// </summary>
        public DateTime? Dhe005
        {
            get
            {
                return _dhe005;
            }

            set
            {
                _dhe005 = value;
            }
        }
    }
}
