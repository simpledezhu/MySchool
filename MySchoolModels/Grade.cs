using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModels
{
    [Serializable]
    public class Grade
    {
        private int _gradeId=0;
        private string _gradeName = string.Empty;

        /// <summary>
        ///年级编号
        /// </summary>
        public int GradeId { get => _gradeId; set => _gradeId = value; }
        /// <summary>
        /// 年级名称
        /// </summary>
        public string GradeName { get => _gradeName; set => _gradeName = value; }
    }
}
