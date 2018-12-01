using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySchoolModels;

namespace MySchoolDal
{
    /// <summary>
    /// 提供学员信息的操作
    /// </summary>
    public class StudentService
    {
        #region 常量，变量定义
        public readonly string conString = ConfigurationManager.ConnectionStrings["MySchool"].ConnectionString;
        #endregion

        #region 检查学号是否存在
        /// <summary>
        /// 检查学号是否存在
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <returns>true：存在，false：不存在</returns>
        public bool CheckStudentIsExist(int studentNo)
        {
            //设置标识符
            bool flag = false;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select COUNT(*) from Student where StudentNo = @StudentNo");
            //设置参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",studentNo),
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //参数添加
                comm.Parameters.AddRange(parameters);
                //执行
                int result = Convert.ToInt32(comm.ExecuteScalar());
                //判断
                if (result > 0) {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        #endregion

        #region 检查登录
        /// <summary>
        /// 检查登录
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <param name="loginPwd">密码</param>
        /// <returns>true:登录成功，false：登录失败</returns>
        public bool CheckStudentLogin(int studentNo, string loginPwd)
        {
            bool flag = false;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Student where StudentNo=@StudentNo and LoginPwd=@LoginPwd");
            //参数
            SqlParameter[] parameters = {
                new SqlParameter ("@StudentNo",studentNo),
                new SqlParameter ("@LoginPwd",loginPwd)
            };
            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                //打开连接
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);
                //执行语句
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                if (reader.Read()) {
                    flag = true;
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
            return flag;
        }
        #endregion

        #region 根据学号获取学生对象
        /// <summary>
        /// 根据学号获取学生对象
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <returns>学生对象</returns>
        public Student GetStudentByNo(int studentNo)
        {
            Student stu = null;

            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Student where StudentNo = @StudentNo");
            //设置参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",studentNo),
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                //连接数据库
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //参数添加
                comm.Parameters.AddRange(parameters);
                //执行
                SqlDataReader reader = comm.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    stu = new Student();
                    stu.StudentNo = studentNo;
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.StudentName = Convert.ToString(reader["StudentName"]);
                    stu.Gender = Convert.ToString(reader["Gender"]);
                    stu.GradeId = Convert.ToInt32(reader["GradeId"]);
                    stu.Phone = Convert.ToString(reader["Phone"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.BornDate = Convert.ToDateTime(reader["BornDate"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.IdentityCard = Convert.ToString(reader["IdentityCard"]);
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
            return stu;
        }
        #endregion

        #region 检查身份证号是否存在
        /// <summary>
        /// 检查身份证号是否存在
        /// </summary>
        /// <param name="identityCard">身份证号</param>
        /// <returns>true：存在，false：不存在</returns>
        public bool CheckIdentityCard(string identityCard)
        {
            //设置标识符
            bool flag = false;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select COUNT(*) from Student where IdentityCard = @IdentityCard");
            //设置参数
            SqlParameter[] parameters = {
                new SqlParameter("@IdentityCard",identityCard),
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //参数添加
                comm.Parameters.AddRange(parameters);
                //执行
                int result = Convert.ToInt32(comm.ExecuteScalar());
                //判断
                if (result > 0)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        #endregion

        #region 检查年级Id是否一致
        /// <summary>
        /// 检查年级Id是否一致
        /// </summary>
        /// <param name="subjectNo">年级Id</param>
        /// <returns>存在行数</returns>
        public int CheckGradeId(int subjectNo)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select COUNT(*) from Student where GradeId = (select GradeId from Subject where SubjectNo = @SubjectNo)");

            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@SubjectNo",subjectNo)
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //参数添加
                comm.Parameters.AddRange(parameters);
                //执行
                int result = Convert.ToInt32(comm.ExecuteScalar());
                return result;
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

        #region 新增学员
        /// <summary>
        /// 新增学员
        /// </summary>
        /// <param name="student">学员参数</param>
        /// <returns>受影响行数</returns>
        public int AddStudent(Student student)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into Student values(@StudentNo,@loginPwd,@StudentName,@Gender,@GradeId,@Phone,@Address,@BornDate,@Email,@IdentityCard)");

            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",student.StudentNo),
                new SqlParameter("@loginPwd",student.LoginPwd),
                new SqlParameter("@StudentName",student.StudentName),
                new SqlParameter("@Gender",student.Gender),
                new SqlParameter("@GradeId",student.GradeId),
                new SqlParameter("@Phone",student.Phone),
                new SqlParameter("@Address",student.Address),
                new SqlParameter("@BornDate",student.BornDate),
                new SqlParameter("@Email",student.Email),
                new SqlParameter("@IdentityCard",student.IdentityCard)
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //参数添加
                comm.Parameters.AddRange(parameters);
                //执行
                int result = comm.ExecuteNonQuery();
                return result;
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

        #region 根据学生学号更改学生信息
        /// <summary>
        /// 更改学生信息
        /// </summary>
        /// <param name="student"></param>
        public int UpdateStudent(Student student)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update  Student set StudentNo=@StudentNo,LoginPwd=@LoginPwd,StudentName=@StudentName,Gender=@Gender,GradeId=@GradeId,Phone=@Phone,Address=@Address,BornDate=@BornDate,Email=@Email,IdentityCard=@IdentityCard where StudentNo=@StudentNO");

            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",student.StudentNo),
                new SqlParameter("@LoginPwd",student.LoginPwd),
                new SqlParameter("@StudentName",student.StudentName),
                new SqlParameter("@Gender",student.Gender=="男"?1:0),
                new SqlParameter("@GradeId",student.GradeId),
                new SqlParameter("@Phone",student.Phone),
                new SqlParameter("@Address",student.Address),
                new SqlParameter("@BornDate",student.BornDate),
                new SqlParameter("@Email",student.Email),
                new SqlParameter("@IdentityCard",student.IdentityCard)
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //参数添加
                comm.Parameters.AddRange(parameters);
                ////设置为执行存储过程
                //comm.CommandType = CommandType.StoredProcedure;
                //执行
                int result = comm.ExecuteNonQuery();
                return result;
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

        #region 根据学号删除学员信息
        /// <summary>
        /// 根据学号删除学员信息
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <returns>受影响行数</returns>
        public int DeleteStudentInfo(int studentNo)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from Student where StudentNo=@StudentNo");

            //配置参数
            SqlParameter[] parameters = {
                new SqlParameter("@StudentNo",studentNo),
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //执行工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //参数添加
                comm.Parameters.AddRange(parameters);
                ////设置为执行存储过程
                //comm.CommandType = CommandType.StoredProcedure;
                //执行
                int result = comm.ExecuteNonQuery();
                return result;
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

        #region 获取学员全部信息
        /// <summary>
        /// 获取学员全部信息
        /// </summary>
        /// <returns>学员集合</returns>
        public List<Student> GetStudentData()
        {
            List<Student> students = new List<Student>();
            //Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Student");

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //创建工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Student stu = new Student();
                    stu.StudentNo = Convert.ToInt32(reader["StudentNo"]); ;
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.StudentName = Convert.ToString(reader["StudentName"]);
                    stu.Gender = Convert.ToString(reader["Gender"]);
                    stu.GradeId = Convert.ToInt32(reader["GradeId"]);
                    stu.Phone = Convert.ToString(reader["Phone"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.BornDate = Convert.ToDateTime(reader["BornDate"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.IdentityCard = Convert.ToString(reader["IdentityCard"]);
                    students.Add(stu);
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
            return students;
        }
        #endregion

        #region 根据姓名和年级条件查询学生信息
        /// <summary>
        /// 根据姓名和年级条件查询学生信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="gradeId">学生Id</param>
        /// <returns>学生集合</returns>
        public List<Student> GetStudentDataByNameAndGrade(string name,int gradeId)
        {
            List<Student> students = new List<Student>();
            //Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Student where  GradeId= @GradeId and StudentName like + '%' + @StudentName + '%' ");
            //参数
            SqlParameter[] parameters ={
                new SqlParameter("@StudentName",name),
                new SqlParameter("@GradeId",gradeId)
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                //创建工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Student stu = new Student();
                    stu.StudentNo = Convert.ToInt32(reader["StudentNo"]); ;
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.StudentName = Convert.ToString(reader["StudentName"]);
                    stu.Gender = Convert.ToString(reader["Gender"]);
                    stu.GradeId = Convert.ToInt32(reader["GradeId"]);
                    stu.Phone = Convert.ToString(reader["Phone"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.BornDate = Convert.ToDateTime(reader["BornDate"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.IdentityCard = Convert.ToString(reader["IdentityCard"]);
                    students.Add(stu);
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
            return students;
        }
        #endregion

        #region 根据姓名条件查询学生信息的集合
        /// <summary>
        /// 根据姓名条件查询学生信息的集合
        /// </summary>
        /// <param name="name">姓名</param>
        /// <returns>学生的集合</returns>
        public List<Student> GetStudentDataByName(string name)
        {
            List<Student> students = new List<Student>();
            //Sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from Student where StudentName like +'%'+ @StudentName +'%'");
            //参数
            SqlParameter[] parameters ={
                new SqlParameter("@StudentName",name),
            };

            //连接对象
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                //创建工具
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                //添加参数
                comm.Parameters.AddRange(parameters);

                //打开数据库
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Student stu = new Student();
                    stu.StudentNo = Convert.ToInt32(reader["StudentNo"]); ;
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.StudentName = Convert.ToString(reader["StudentName"]);
                    stu.Gender = Convert.ToString(reader["Gender"]);
                    stu.GradeId = Convert.ToInt32(reader["GradeId"]);
                    stu.Phone = Convert.ToString(reader["Phone"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.BornDate = Convert.ToDateTime(reader["BornDate"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.IdentityCard = Convert.ToString(reader["IdentityCard"]);
                    students.Add(stu);
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
            return students;

        }

        #endregion


    }
}
