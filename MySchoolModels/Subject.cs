using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModels
{   
    [Serializable]
    public class Subject
    {
        private int _subjectNo = 0;
        private string _subjectName = String.Empty;
        private int _classHour = 0;
        private int _gradeId = 0;

        /// <summary>
        /// 课程Id
        /// </summary>
        public int SubjectNo { get => _subjectNo; set => _subjectNo = value; }
        /// <summary>
        /// 课程名字
        /// </summary>
        public string SubjectName { get => _subjectName; set => _subjectName = value; }
        /// <summary>
        /// 课时
        /// </summary>
        public int ClassHour { get => _classHour; set => _classHour = value; }
        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId { get => _gradeId; set => _gradeId = value; }
    }
}
