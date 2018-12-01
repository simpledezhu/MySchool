using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolModels;
using System.Data;
using System.Data.SqlClient;

namespace MySchoolDal
{
    /// <summary>
    /// 提供管理员信息操作
    /// </summary>
    public class AdminService
    {
        #region 常量、变量的定义
        private readonly string conString = ConfigurationManager.ConnectionStrings["Myschool"].ConnectionString;
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
            //定义标志符
            bool flag = false;
            //创建Sql语句   StringBuilder:动态字符串
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from admin");
            sb.AppendLine("where LoginId=@LoginId and LoginPwd=@LoginPwd");
            //设置参数
            SqlParameter[] paras = {
                new SqlParameter("@LoginId",loginId),
                new SqlParameter("@LoginPwd",loginPwd),
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                //1.第一种方式
                cmd.Parameters.AddRange(paras);
                ////2.第二种方式
                //cmd.Parameters.AddWithValue("@LoginId", loginId);
                //cmd.Parameters.AddWithValue("@LoginPwd", loginPwd);
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read()) {
                    flag = true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally {
                conn.Close();
            }
            return flag;
        }
        #endregion

    }
}
