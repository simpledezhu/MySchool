using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModels
{
    [Serializable]
    public class Admin
    {
        private string _loginId = string.Empty;
        private string _loginPwd = string .Empty;

        /// <summary>
        /// 用户id
        /// </summary>
        public string LoginId { get => _loginId; set => _loginId = value; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string LoginPwd { get => _loginPwd; set => _loginPwd = value; }



    }
}
