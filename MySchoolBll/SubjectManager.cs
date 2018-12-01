using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolDal;
using MySchoolModels;

namespace MySchoolBll
{
    public class SubjectManager
    {
        #region 常量、变量的定义
        private SubjectService subjectService = new SubjectService();
        #endregion

        #region 获取所有的科目信息
        /// <summary>
        /// 获取所有的科目信息
        /// </summary>
        /// <returns>所有的年级信息的集合</returns>
        public List<Subject> GetSubjectData()
        {
            try
            {
               return subjectService.GetSubjectData();
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }
        #endregion

        #region 根据年级编号获取所有的科目信息
        /// <summary>
        /// 根据年级编号获取所有的科目信息
        /// </summary>
        /// <returns>根据年级编号返回所有的年级信息的集合</returns>
        public List<Subject> GetSubjectDataByGradeId(int gradeId)
        {
            try
            {
                return subjectService.GetSubjectDataByGradeId(gradeId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        #endregion

        #region 根据科目编号获取所有的科目信息
        /// <summary>
        /// 根据科目编号获取所有的科目信息
        /// </summary>
        /// <returns>根据科目编号获取所有的科目信息的集合</returns>
        public Subject GetGradeDataBySubjectNo(int subjectNo)
        {
            try
            {
                return subjectService.GetGradeDataBySubjectNo(subjectNo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region 根据科目名称查询科目编号
        /// <summary>
        /// 根据科目名称查询科目编号
        /// </summary>
        /// <returns>科目编号</returns>
        public int GetGradeDataBySubjectName(int subjectName)
        {
            try
            {
                return subjectService.GetGradeDataBySubjectName(subjectName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
