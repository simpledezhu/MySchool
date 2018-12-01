using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolDal;
using MySchoolModels;

namespace MySchoolBll
{
    public class StudentManager
    {
        #region 变量、常量的定义
        StudentService studentService = new StudentService();
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
            try
            {
                return studentService.CheckStudentLogin(studentNo, loginPwd);
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
            }
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
            try
            {
                return studentService.GetStudentByNo(studentNo); ;
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
            }
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
            try
            {
                return studentService.CheckIdentityCard(identityCard) ;
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
            }
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
            try
            {
                return studentService.CheckGradeId(subjectNo) ;
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
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
            try
            {
                return studentService.AddStudent(student) ;
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
            }
        }
        #endregion

        #region 更改学生信息
        /// <summary>
        /// 更改学生信息
        /// </summary>
        /// <param name="student"></param>
        public int UpdateStudent(Student student)
        {
            try
            {
                return studentService.UpdateStudent(student);
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
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
            try
            {
                return studentService.DeleteStudentInfo(studentNo);
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
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
            try
            {
                return studentService.GetStudentData();
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
            }
            
        }
        #endregion

        #region 根据姓名和年级条件查询学生信息
        /// <summary>
        /// 根据姓名和年级条件查询学生信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="gradeId">学生Id</param>
        /// <returns>学生集合</returns>
        public List<Student> GetStudentDataByNameAndGrade(string name, int gradeId)
        {
            try
            {
                return studentService.GetStudentDataByNameAndGrade(name,gradeId); 
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
            }
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
            try
            {
                return studentService.GetStudentDataByName(name);
            }
            catch (Exception ex)
            {
                //抛出异常，到时候到表现层处理
                throw ex;
            }
        }
        #endregion


    }
}
