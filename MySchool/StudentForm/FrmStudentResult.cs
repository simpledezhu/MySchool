using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchoolBll;
using MySchoolModels;

namespace MySchool.StudentForm
{
    public partial class FrmStudentResult : Form
    {

        #region 变量、常量的定义
        public const string OPERATIONFAILED = "操作错误";
        public Student _student = new Student();
        private StudentManager studentManager = new StudentManager();
        private GradeManager gradeManager = new GradeManager();
        private SubjectManager subjectManager = new SubjectManager();
        private ResultManager resultManager = new ResultManager();

        #endregion

        public  FrmStudentResult()
        {
            InitializeComponent();
            //影藏多查询的列
            this.dataGridView1.AutoGenerateColumns = false;
        }

        //窗体加载事件
        private void FrmStudentResult_Load(object sender, EventArgs e)
        {
            try
            {
                //获取学生的信息
                _student = studentManager.GetStudentByNo(Convert.ToInt32(UserInfo.loginId));
                this.labelGradeName.Text = gradeManager.GetGradeDataById(_student.GradeId).GradeName;
                BindCbox();
                BindDGVByStudentNoAndSubjectNo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONFAILED,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        //绑定Combox
        private void BindCbox()
        {
            this.chooseSubject.DataSource = subjectManager.GetSubjectDataByGradeId(_student.GradeId);
            //DisplayMember绑定的是需显示的字段,
            this.chooseSubject.DisplayMember = "SubjectName";
            //ValueMember绑定的是对应的值
            this.chooseSubject.ValueMember = "SubjectNo";
        }



        //根据学生ID和科目ID查询成绩信息
        private void BindDGVByStudentNoAndSubjectNo() {
            this.dataGridView1.DataSource = resultManager.ReviewStudentResultBySubjectNoAndStudentNo(Convert.ToInt32(this.chooseSubject.SelectedValue), Convert.ToInt32(_student.StudentNo));

        }



        //Combox中Subject内容变化进行查询
        private void chooseSubject_DropDownClosed(object sender, EventArgs e)
        {
            BindDGVByStudentNoAndSubjectNo();
        }
    }
}
