using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolDal;
using MySchoolModels;


namespace MySchoolBll
{
    public class AdminManager
    {
        #region 变量、常量定义
        AdminService adminService = new AdminService();
        #endregion

        #region 执行管理员登录检查
        /// <summary>
        /// 执行管理员登录检查
        /// </summary>
        /// <param name="loginId">用户名</param>
        /// <param name="loginPwd">密码</param>
        /// <returns>true:登录成功，false：登录失败</returns>
        public bool CheckAdminLogin(string loginId, string loginPwd)
        {
            try
            {
                return adminService.CheckAdminLogin(loginId,loginPwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

    }
}
