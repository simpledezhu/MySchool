using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModels
{
    [Serializable]
    public class Student
    {
        private int _studentNo=0;
        private string _loginPwd = String.Empty;
        private string _studentName = String.Empty;
        private string _gender = String.Empty;
        private int    _gradeId = 0;
        private string _phone = String.Empty;
        private string _address = String.Empty;
        private DateTime _bornDate;
        private string _email = String.Empty;
        private string _identityCard = String.Empty;

        /// <summary>
        ///学生Id
        /// </summary>
        public int StudentNo { get => _studentNo; set => _studentNo = value; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get => _loginPwd; set => _loginPwd = value; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get => _studentName; set => _studentName = value; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get => _gender; set => _gender = value; }
        /// <summary>
        /// 分数
        /// </summary>
        public int GradeId { get => _gradeId; set => _gradeId = value; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get => _phone; set => _phone = value; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BornDate { get => _bornDate; set => _bornDate = value; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IdentityCard { get => _identityCard; set => _identityCard = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
