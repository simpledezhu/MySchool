using MySchoolBll;
using MySchoolModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool.AdminForm
{
    public partial class FrmAddResult : Form
    {
        #region 常量、变量定义
        private const string INPUTWARN = "输入提示";
        private const string OPERATIONWARN = "操作提示";
        private const string OPERATIONFAILED = "操作错误！";
        private const string SELECTSUBJECT = "请选择科目！";
        private const string INPUTRESULT = "请输入成绩！";
        private const string EXAMDATE = "请输入考试时间！";
        private const string INPUTDATAWRONG1 = "输入的时间格式有误!";
        private const string INPUTDATAWRONG2 = "请输入数字！";
        private const string INPUTDATAWRONG3 = "请输的成绩不在0 ~100之间！";
        private const string ADDFAILED = "添加失败!";
        private const string ADDSUCCESS = "添加成功!";

        //实例化变量
        private GradeManager gradeManager = new GradeManager();
        private SubjectManager subjectManager = new SubjectManager();
        private ResultManager resultManager = new ResultManager();
        #endregion

        #region 属性定义
	    public string studentNo { get; set; }
        public string studentName { get; set; } 
        #endregion

        public FrmAddResult()
        {
            InitializeComponent();
        }

        //窗体加载
        private void FrmAddResult_Load(object sender, EventArgs e)
        {
            this.lbStuName.Text = studentName;
            GradeDataBind();
            SubjectDataBind();
            this.cboSubject.SelectedIndex = 1;
        }

        //返回按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //给cboGrade 绑定数据源
        private void GradeDataBind()
        {
            try
            {
                List<Grade> gradeList = gradeManager.GetGradeData();
                this.cboGrade.DataSource = gradeList;
                this.cboGrade.DisplayMember = "GradeName";
                this.cboGrade.ValueMember = "GradeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONFAILED,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //给cboSubject 绑定数据源
        private void SubjectDataBind()
        {
            try
            {
                List<Subject> subjectList = subjectManager.GetSubjectData();
                this.cboSubject.DataSource = subjectList;
                this.cboSubject.DisplayMember = "SubjectName";
                this.cboSubject.ValueMember = "SubjectNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //学生成绩信息格式验证
        private bool CheckResultFormat(string examResult)
        {
            try
            {
                //判断成绩是否符合规范
                int result = int.Parse(examResult);
                if (result < 0 || result > 100) {
                    MessageBox.Show(INPUTDATAWRONG3, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else{
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(INPUTDATAWRONG2, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //非空验证
        private bool CheckInputNoEmpty()
        {
            //判断 科目是否选择
            if (this.cboSubject.Text=="") {
                MessageBox.Show(SELECTSUBJECT,INPUTWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.cboSubject.Focus();
                return false;
            }
            
            //判断科目成绩是否选择
            if (this.txtResult.Text=="") {
                MessageBox.Show(INPUTRESULT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtResult.Focus();
                return false;
            }
            return true;
        }

        //给学生添加成绩事件
        private void btnAddResult_Click(object sender, EventArgs e)
        {
            try
            {
                //验证
                if (!CheckInputNoEmpty())
                {
                    MessageBox.Show(INPUTDATAWRONG3, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(!CheckResultFormat(txtResult.Text.Trim().ToString()))
                {
                    return;
                }
                //创建实体类
                Result result = new Result();
                result.StudentNo = Convert.ToInt32(this.studentNo);
                result.SubjectNo = Convert.ToInt32(this.cboSubject.SelectedValue);
                result.StudentResult = Convert.ToInt32(this.txtResult.Text.Trim());
                result.ExamDate = this.dptExamDate.Value;
                int resultCode = resultManager.AddStudentResult(result);
                if (resultCode > 0)
                {
                    MessageBox.Show(ADDSUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else {
                    MessageBox.Show(ADDFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(OPERATIONWARN, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }










    }
}
