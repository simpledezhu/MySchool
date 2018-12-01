using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolModels;
using MySchoolDal;

namespace MySchoolBll
{
    public class GradeManager
    {
        private GradeService gradeService = new GradeService();

        #region 获取所有的年级信息
        /// <summary>
        /// 获取所有的年级信息
        /// </summary>
        /// <returns>所有的年级信息的集合</returns>
        public List<Grade> GetGradeData()
        {
            try
            {
                return gradeService.GetGradeData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                return gradeService.GetGradeDataById(gradeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据年级名称查询年级编号
        /// <summary>
        /// 根据年级名称查询年级编号
        /// </summary>
        /// <param name="gradeName">年级名称</param>
        /// <returns>年级编号：如果是0代表没找到</returns>
        private int GetGradeId(string gradeName)
        {
            return gradeService.GetGradeId(gradeName);
        }
        #endregion
    }
}
