using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchoolDal;
using MySchoolModels;

namespace MySchoolBll
{
    public class ResultManager
    {
        private ResultService resultService = new ResultService();

        #region 新增学员成绩
        /// <summary>
        /// 新增学员成绩
        /// </summary>
        /// <param name="result">成绩</param>
        /// <returns>受影响的行数</returns>
        public int AddStudentResult(Result result)
        {
            try
            {
                return resultService.AddStudentResult(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region 查询学生的成绩
        /// <summary>
        /// 查询学生的成绩
        /// </summary>
        /// <param name="studentName">姓名</param>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewResultByStuNameAndSubjectNo(string studentName, string subjectNo)
        {
            try
            {
                return resultService.ReviewResultByStuNameAndSubjectNo(studentName, subjectNo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            try
            {
                return resultService.ReviewStudentResultBySubjectNo(subjectNo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            return resultService.ReviewStudentResultByStudentNo(studentNo);
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
            return resultService.ReviewStudentResultBySubjectNoAndStudentNo(subjectNo, studentNo);
        }
        #endregion

        #region 更新学院成绩表
        /// <summary>
        /// 更新学院成绩表
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public int UpdateStudentResult(Result result)
        {
            try
            {
                return resultService.UpdateStudentResult(result);
            }
            catch (Exception ex)
            {

                throw ex;
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
            try
            {
                return resultService.DeleteStudentResult(studentNo,subjectNo);
            }
            catch (Exception ex)
            {

                throw ex;
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
            try
            {
                return resultService.ReviewAllResults();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        public List<Result> ReviewResultByStuNameAndSubjectNoAndGradeId(string studentName, string subjectNo, string gradeId)
        {
            try
            {
                return resultService.ReviewResultByStuNameAndSubjectNoAndGradeId(studentName,subjectNo,gradeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
