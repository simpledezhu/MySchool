using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolModels;

namespace MySchoolDal
{
    public class SubjectService
    {

        #region 常量、变量的定义
        public readonly string connString = ConfigurationManager.ConnectionStrings["Myschool"].ConnectionString;
        #endregion

        #region 获取所有的科目信息
        /// <summary>
        /// 获取所有的科目信息
        /// </summary>
        /// <returns>所有的年级信息的集合</returns>
        public List<Subject> GetSubjectData()
        {

            //定义list集合
            List<Subject> subjects = new List<Subject>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from Subject");
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //创建执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    Subject subjcet = new Subject();
                    subjcet.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    subjcet.SubjectName = Convert.ToString(reader["SubjectName"]);
                    subjcet.ClassHour = Convert.ToInt32(reader["ClassHour"]);
                    subjcet.GradeId = Convert.ToInt32(reader["GradeId"]);
                    subjects.Add(subjcet);
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
            return subjects;
        }
        #endregion

        #region 根据年级编号获取所有的科目信息
        /// <summary>
        /// 根据年级编号获取所有的科目信息
        /// </summary>
        /// <returns>根据年级编号返回所有的年级信息的集合</returns>
        public List<Subject> GetSubjectDataByGradeId(int gradeId)
        {

            //定义list集合
            List<Subject> subjects = new List<Subject>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Subject");
            sb.AppendLine("where GradeId=@GradeId");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@GradeId",gradeId)
            };

            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //创建执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //设置参数
                comm.Parameters.AddRange(parameters);
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    Subject subjcet = new Subject();
                    subjcet.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    subjcet.SubjectName = Convert.ToString(reader["SubjectName"]);
                    subjcet.ClassHour = Convert.ToInt32(reader["ClassHour"]);
                    subjcet.GradeId = Convert.ToInt32(reader["GradeId"]);
                    subjects.Add(subjcet);
                    Console.WriteLine("SubjectName:"+ reader["SubjectName"] +",SubjectNo:"+ reader["SubjectNo"]);
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
            return subjects;
        }
        #endregion

        #region 根据科目编号获取所有的科目信息
        /// <summary>
        /// 根据科目编号获取所有的科目信息
        /// </summary>
        /// <returns>根据科目编号获取所有的科目信息的集合</returns>
        public Subject GetGradeDataBySubjectNo(int subjectNo)
        {
            //创建返回对象
            Subject subject = null;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Subject");
            sb.AppendLine("where SubjectNo=@SubjectNo");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@SubjectNo",subjectNo)
            };

            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                
                //创建执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //设置参数
                comm.Parameters.AddRange(parameters);
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    subject = new Subject();
                    subject.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    subject.SubjectName = Convert.ToString(reader["SubjectName"]);
                    subject.ClassHour = Convert.ToInt32(reader["ClassHour"]);
                    subject.GradeId = Convert.ToInt32(reader["GradeId"]);
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
            return subject;
        }
        #endregion

        #region 根据科目名称查询科目编号
        /// <summary>
        /// 根据科目名称查询科目编号
        /// </summary>
        /// <returns>科目编号</returns>
        public int GetGradeDataBySubjectName(int subjectName)
        {
            //创建返回值
            int result=0;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select SubjectNo from Subject");
            sb.AppendLine("where SubjectName=@SubjectName");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@SubjectName",subjectName)
            };

            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //创建执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //设置参数
                comm.Parameters.AddRange(parameters);
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    result= Convert.ToInt32(reader["SubjectNo"]);
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
            return result;
        }
        #endregion

    }
}
