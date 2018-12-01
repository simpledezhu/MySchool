using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModels
{
    [Serializable]
    public class Teacher
    {
        private int _id = 0;
        private string _name = string.Empty;
        private int _age = 0;
        private int _teacheYear = 0 ;
        private int _gradeId = 0;

        /// <summary>
        /// 老师id
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        /// <summary>
        /// 老师姓名
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        /// <summary>
        /// 老师年级
        /// </summary>
        public int Age { get => _age; set => _age = value; }
        /// <summary>
        /// 老师教龄
        /// </summary>
        public int TeachYear { get => _teacheYear; set => _teacheYear = value; }
        /// <summary>
        /// 老师班级Id
        /// </summary>
        public int GradeId { get => _gradeId; set => _gradeId = value; }
    }
}
