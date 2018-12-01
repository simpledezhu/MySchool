using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModels
{
    [Serializable]
    public class Result
    {
        private int _studentNo = 0;
        private int _subjectNo = 0;
        private int _studentResult = 0;
        private DateTime _examDate  ;

        /// <summary>
        /// 学生Id
        /// </summary>
        public int StudentNo { get => _studentNo; set => _studentNo = value; }
        /// <summary>
        /// 科目编号
        /// </summary>
        public int SubjectNo { get => _subjectNo; set => _subjectNo = value; }
        /// <summary>
        /// 考试成绩
        /// </summary>
        public int StudentResult { get => _studentResult; set => _studentResult = value; }
        /// <summary>
        /// 考试日期
        /// </summary>
        public DateTime ExamDate { get => _examDate; set => _examDate = value; }
    }
}
