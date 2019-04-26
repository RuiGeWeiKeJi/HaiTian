using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace CodeSanEntity
{
    public class SqlConnConfigEntity
    {
        private string _ip;
        private string _name;
        private string _password;
        private string _stu;

        /// <summary>
        /// 服务器IP地址
        /// </summary>
        public string Ip
        {
            get
            {
                return _ip;
            }

            set
            {
                _ip = value;
            }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
        /// <summary>
        /// 库
        /// </summary>
        public string Stu
        {
            get
            {
                return _stu;
            }

            set
            {
                _stu = value;
            }
        }
    } 
}
