using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using MySchoolModels;

namespace MySchoolDal
{
    public class ResultService
    {

        #region 常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["MySchool"].ConnectionString;
        #endregion

        #region 新增学员成绩
        /// <summary>
        /// 新增学员成绩
        /// </summary>
        /// <param name="result">成绩</param>
        /// <returns>受影响的行数</returns>
        public int AddStudentResult(Result result)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into Result values(@StudentNo,@SubjectNo,@StudentResult,@ExamDate)");
            //参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",result.StudentNo),
                new SqlParameter("@SubjectNo",result.SubjectNo),
                new SqlParameter("@StudentResult",result.StudentResult),
                new SqlParameter("@ExamDate",result.ExamDate)
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);
                //打开数据库
                conn.Open();
                //执行
                int result1 =  comm.ExecuteNonQuery();
                return result1;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 根据学生姓名，科目编号查询学生的成绩
        /// <summary>
        /// 查询学生的成绩
        /// </summary>
        /// <param name="studentName">姓名</param>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewResultByStuNameAndSubjectNo(string studentName, string subjectNo)
        {
            //定义list集合
            List<Result> results = new List<Result>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select r.StudentNo,r.SubjectNo,r.StudentResult,r.ExamDate");
            sb.AppendLine("from Result r,Student s");
            sb.AppendLine("where r.StudentNo=s.StudentNo and r.SubjectNo=@SubjectNo and s.StudentName like @StudentName");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@SubjectNo",subjectNo),
                new SqlParameter("@studentName","%"+studentName+"%")
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
                    Result result = new Result();
                    result.StudentNo = Convert.ToInt32(reader["StudentNo"]);
                    result.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    result.StudentResult = Convert.ToInt32(reader["StudentResult"]);
                    result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);
                    results.Add(result);
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
            return results;
        }
        #endregion

        #region 根据科目编号查询成绩
        /// <summary>
        /// 根据科目编号查询成绩
        /// </summary>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultBySubjectNo(string subjectNo)
        {
            //定义list集合
            List<Result> results = new List<Result>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select StudentNo,SubjectNo,StudentResult,ExamDate");
            sb.AppendLine("from Result ");
            sb.AppendLine("where  SubjectNo=@SubjectNo ");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@SubjectNo",subjectNo),
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
                    Result result = new Result();
                    result.StudentNo = Convert.ToInt32(reader["StudentNo"]);
                    result.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    result.StudentResult = Convert.ToInt32(reader["StudentResult"]);
                    result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);
                    results.Add(result);
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
            return results;
        }
        #endregion

        #region 根据学生学号查询成绩
        /// <summary>
        /// 根据学生学号查询成绩
        /// </summary>
        /// <param name="studentNo">学生学号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultByStudentNo(int studentNo)
        {
            //定义list集合
            List<Result> results = new List<Result>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select StudentNo,SubjectNo,StudentResult,ExamDate");
            sb.AppendLine("from Result ");
            sb.AppendLine("where  StudentNo=@StudentNo");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",studentNo),
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
                    Result result = new Result();
                    result.StudentNo = Convert.ToInt32(reader["StudentNo"]);
                    result.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    result.StudentResult = Convert.ToInt32(reader["StudentResult"]);
                    result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);
                    results.Add(result);
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
            return results;
        }
        #endregion

        #region 根据学生学号，科目编号查询学生的成绩
        /// <summary>
        /// 根据学生学号，科目编号查询学生的成绩
        /// </summary>
        /// <param name="subjectNo">科目编号</param>
        /// <param name="studentNo">学号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultBySubjectNoAndStudentNo(int subjectNo, int studentNo)
        {
            //定义list集合
            List<Result> results = new List<Result>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select StudentNo,SubjectNo,StudentResult,ExamDate");
            sb.AppendLine("from Result ");
            sb.AppendLine("where SubjectNo=@SubjectNo and StudentNo=@StudentNo");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@SubjectNo",subjectNo),
                new SqlParameter("@StudentNo",studentNo)
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
                    Result result = new Result();
                    result.StudentNo = Convert.ToInt32(reader["StudentNo"]);
                    result.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    result.StudentResult = Convert.ToInt32(reader["StudentResult"]);
                    result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);
                    results.Add(result);
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
            return results;
        }
        #endregion

        #region 更新学生成绩表
        /// <summary>
        /// 更新学生成绩表
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public int UpdateStudentResult(Result result)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update Result set StudentNo=@StudentNo,SubjectNo=@SubjectNo,StudentResult=@StudentResult,ExamDate=@ExamDate where StudentNo=@StudentNo and SubjectNo=@SubjectNo");
            //参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",result.StudentNo),
                new SqlParameter("@SubjectNo",result.SubjectNo),
                new SqlParameter("@StudentResult",result.StudentResult),
                new SqlParameter("@ExamDate",result.ExamDate)
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);
                ////设置执行类型
                //comm.CommandType = CommandType.StoredProcedure;
                //打开数据库
                conn.Open();
                //执行
                int result1 = comm.ExecuteNonQuery();
                return result1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        #endregion

        #region 根据学号，科目编号删除学员信息
        /// <summary>
        /// 根据学号，科目编号删除学员信息
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <param name="subjectNo">科目编号</param>
        /// <returns></returns>
        public int DeleteStudentResult(int studentNo, int subjectNo)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from Result where StudentNo=@StudentNo and SubjectNo=@SubjectNO");
            //参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",studentNo),
                new SqlParameter("@SubjectNo",subjectNo),
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);
                //打开数据库
                conn.Open();
                //执行
                int result1 = comm.ExecuteNonQuery();
                return result1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 查询所有学生成绩
        /// <summary>
        /// 查询所有学生成绩
        /// </summary>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewAllResults()
        {
            //定义list集合
            List<Result> results = new List<Result>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select StudentNo,SubjectNo,StudentResult,ExamDate from Result");

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
                    Result result = new Result();
                    result.StudentNo = Convert.ToInt32(reader["StudentNo"]);
                    result.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    result.StudentResult = Convert.ToInt32(reader["StudentResult"]);
                    result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);
                    results.Add(result);
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
            return results;
        }
        #endregion

        #region 根据学生姓名，科目编号,年级编号查询学生的成绩
        /// <summary>
        /// 根据学生姓名，科目编号,年级编号查询学生的成绩
        /// </summary>
        /// <param name="studentName">姓名</param>
        /// <param name="subjectNo">科目编号</param>
        /// <param name="gradeNo">年级ID</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewResultByStuNameAndSubjectNoAndGradeId(string studentName, string subjectNo,string gradeId)
        {
            //定义list集合
            List<Result> results = new List<Result>();

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select r.StudentNo,r.SubjectNo,r.StudentResult,r.ExamDate");
            sb.AppendLine("from Result r,Student s");
            sb.AppendLine("where r.StudentNo=s.StudentNo and r.SubjectNo=@SubjectNo and s.GradeId=@GradeId and s.StudentName like @StudentName");
            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@SubjectNo",subjectNo),
                new SqlParameter("@GradeId",gradeId),
                new SqlParameter("@studentName","%"+studentName+"%")
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
                    Result result = new Result();
                    result.StudentNo = Convert.ToInt32(reader["StudentNo"]);
                    result.SubjectNo = Convert.ToInt32(reader["SubjectNo"]);
                    result.StudentResult = Convert.ToInt32(reader["StudentResult"]);
                    result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);
                    results.Add(result);
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
            return results;
        }
        #endregion
    }
}
