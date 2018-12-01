using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolModels;
using MySchoolDal;

namespace MySchoolBll
{
    public class TeacherManager
    {
        #region MyRegion
        private TeacherService teacherService = new TeacherService() ;
        #endregion

        #region 新增老师
        /// <summary>
        /// 新增老师
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns>true:新增成功，false：新增失败</returns>
        public bool AddTeacher(Teacher teacher)
        {
            try
            {
                return teacherService.AddTeacher(teacher);
            }
            catch (Exception ex)
            {
                throw ex;
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
            try
            {
                return teacherService.GetAllTeacher();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                return teacherService.DeleteTeacherById(teacherId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
