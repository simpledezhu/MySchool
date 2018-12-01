using MySchoolModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolDal
{
    public  class TeacherService
    {
        #region 变量、常量的定义
        private static readonly string conString = ConfigurationManager.ConnectionStrings["Myschool"].ConnectionString;
        #endregion

        #region 新增老师
        /// <summary>
        /// 新增老师
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns>true:新增成功，false：新增失败</returns>
        public bool AddTeacher(Teacher teacher)
        {
            //配置sql 语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into Teacher(name,age,teachYear,gradeId) values(@name,@age,@teachYear,@gradeId)");

            SqlParameter[] parameters = {
                new SqlParameter("@name",teacher.Name),
                new SqlParameter("@age",teacher.Age),
                new SqlParameter("@teachYear",teacher.TeachYear),
                new SqlParameter("@gradeId",teacher.GradeId),
            };

            //创建连接
            SqlConnection conn = new SqlConnection(conString);
            //创建执行器
            SqlCommand comm = new SqlCommand(sb.ToString(), conn);
            try
            {
                conn.Open();
                comm.Parameters.AddRange(parameters);
                return comm.ExecuteNonQuery() > 0;
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

        #region 查询所有老师信息
        /// <summary>
        /// 查询所有老师信息
        /// </summary>
        /// <returns></returns>
        public List<TeacherBusiness> GetAllTeacher()
        {
            //定义结果集合
            List<TeacherBusiness> teachers = new List<TeacherBusiness>();
            //定义Sql 语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select a.*,b.GradeName from Teacher a inner join  Grade b on a.gradeId = b.GradeId");

            //创建连接对象
            SqlConnection conn = new SqlConnection(conString);
            //创建执行器
            SqlCommand comm = new SqlCommand(sb.ToString(), conn);
            try
            {
                //打开连接
                conn.Open();
                //执行sql语句
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    TeacherBusiness teacher = new TeacherBusiness();
                    teacher.Id = Convert.ToInt32(reader["id"]);
                    teacher.Name = Convert.ToString(reader["name"]);
                    teacher.Age = Convert.ToInt32(reader["age"]);
                    teacher.TeachYear = Convert.ToInt32(reader["teachYear"]);
                    teacher.GradeId = Convert.ToInt32(reader["gradeId"]);
                    teacher.GradeName = Convert.ToString(reader["gradeName"]);
                    teachers.Add(teacher);
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
            return teachers;
        }
        #endregion

        #region 根据老师Id删除信息
        /// <summary>
        /// 根据老师Id删除信息
        /// </summary>
        /// <param name="teacherId">老师id</param>
        /// <returns>true:新增成功，false：新增失败</returns>
        public bool DeleteTeacherById(int teacherId)
        {
            //配置sql 语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from Teacher where id=@id");

            SqlParameter[] parameters = {
                new SqlParameter("@id",teacherId),
            };

            //创建连接
            SqlConnection conn = new SqlConnection(conString);
            //创建执行器
            SqlCommand comm = new SqlCommand(sb.ToString(), conn);
            try
            {
                conn.Open();
                comm.Parameters.AddRange(parameters);
                return comm.ExecuteNonQuery() > 0;
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

    }
}
