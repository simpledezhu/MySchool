using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySchoolModels;

namespace MySchoolDal
{
    //查询年级相关数据
    public class GradeService
    {
        #region 常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["MySchool"].ConnectionString;
        #endregion

        #region 获取所有的年级信息
        /// <summary>
        /// 获取所有的年级信息
        /// </summary>
        /// <returns>所有的年级信息的集合</returns>
        public List<Grade> GetGradeData()
        {

            //定义list集合
            List<Grade> grades = new List<Grade>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from Grade");
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            try
            {                
                //打开连接
                conn.Open();
                //创建执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);

                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    Grade grade = new Grade();
                    grade.GradeId = Convert.ToInt32(reader["GradeId"]);
                    grade.GradeName = Convert.ToString(reader["GradeName"]);
                    grades.Add(grade);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return grades;
        }
        #endregion

        #region 根据年级Id获取年级信息
        /// <summary>
        /// 根据年级Id获取年级信息
        /// </summary>
        /// <param name="gradeId">年级Id</param>
        /// <returns>年级对象</returns>
        public Grade GetGradeDataById(int gradeId)
        {
            //定义返回的grade对象
            Grade grade = null;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Grade");
            sb.AppendLine("where GradeId = @GradeId");

            //参数
            SqlParameter[] parameters = {
                new SqlParameter("@GradeId",gradeId)
            };

            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //创建执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);
                //comm.Parameters.Add("@GradeId",SqlDbType.Int,10);
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    grade = new Grade();
                    grade.GradeId = Convert.ToInt32(reader["GradeId"]);
                    grade.GradeName = Convert.ToString(reader["GradeName"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return grade;
        }
        #endregion

        #region 根据年级名称查询年级编号
        /// <summary>
        /// 根据年级名称查询年级编号
        /// </summary>
        /// <param name="gradeName">年级名称</param>
        /// <returns>年级编号：如果是0代表没找到</returns>
        public int GetGradeId(string gradeName)
        {

            //定义返回的 id 对象
            int id = 0;

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select GradeId from Grade");
            sb.AppendLine("where GradeName = @GradeName");

            //参数
            SqlParameter[] parameters = {
                new SqlParameter("@GradeName",gradeName)
            };

            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //打开连接
                conn.Open();
                //创建执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);
                //comm.Parameters.Add("@GradeId",SqlDbType.Int,10);
                
                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["GradeId"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return id;
        } 
        #endregion



    }
}
