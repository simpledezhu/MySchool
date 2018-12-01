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

namespace MySchool.AdminForm
{
    public partial class FrmReviewResult : Form
    {
        #region 变量、常量定义
        public const string OPERATIONFAILED = "操作错误";
        public const string OPERATIONSUCCESS = "操作成功";
        public const string OPERATIONWARN = "操作提示";
        public const string NOEXPORT = "无数据导出！";
        public const string INPUTWARN = "输入提示";
        public const string SELECTSUBJECT = "请造择科目";
        public const string INPUTRESULT = "请输入成绩";
        public const string SELECTEXAMDATE = "请输入考试时间";
        public const string INPUTDATAWRONG1 = "输入的时间格式有误";
        public const string INPUTDATAWRONG2 = "请输入数字！";
        public const string INPUTDATAWRONG3 = "请输的成绩不在0-100之间！";
        public const string UPDATESUCCESS = "更新成功！";
        public const string GRADEIDNOSAME = "年级编号不一致!";
        public const string UPDATEFAILED = "更新失败！";
        public const string ISDELETE = "确认删除？";
        public const string DELETESUCCESS = "删除成功！";
        public const string DELETEFAILED = "删除失败！";
        #endregion

        #region 成员变量的定义
        private StudentManager studentManager = new StudentManager();
        private GradeManager gradeManager = new GradeManager();
        private SubjectManager subjectManager = new SubjectManager();
        private ResultManager resultManager = new ResultManager();
        #endregion

        public FrmReviewResult()
        {
            InitializeComponent();
        }

        //绑定 年级选择框
        private void GradeDataBind()
        {
            try
            {
                List<Grade> gradeList = gradeManager.GetGradeData();
                gradeList.Insert(0, new Grade() { GradeId = -1, GradeName = "全部" });
                cboGrade.DataSource = gradeList;
                cboGrade.DisplayMember = "GradeName";
                cboGrade.ValueMember = "GradeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //绑定 科目选择框
        private void SubjectDataBind()
        {
            try
            {
                //绑定第一个科目
                List<Subject> subjectList1 = subjectManager.GetSubjectData();
                subjectList1.Insert(0, new Subject() { SubjectNo = -1, SubjectName = "全部" });
                cboSubject.DataSource = subjectList1;
                cboSubject.DisplayMember = "SubjectName";
                cboSubject.ValueMember = "SubjectNo";

                //绑定第二个科目
                List<Subject> subjectList2 = subjectManager.GetSubjectData();
                cboSubject2.DataSource = subjectList2;
                cboSubject2.DisplayMember = "SubjectName";
                cboSubject2.ValueMember = "SubjectNo";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //窗体加载事件
        private void FrmReviewResult_Load(object sender, EventArgs e)
        {
            try
            {
                SubjectDataBind();
                GradeDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //执行查询时的数据绑定
        public void ReviewDataBind()
        {
            string strStuName = this.txtName.Text.Trim();
            string subjectNo = this.cboSubject.SelectedValue.ToString();
            string gradeId = this.cboGrade.SelectedValue.ToString();
            //MessageBox.Show("strStuName的值为："+ strStuName+ ",subjectNo的值为："+ subjectNo+",gradeId的值为："+gradeId);
            if (strStuName == "")
            {
                //如果cboGrade和 cboSubject都是全部时，查询所有学生成绩
                if (this.cboGrade.SelectedIndex == 0 && (int)this.cboSubject.SelectedValue == -1)
                {
                    this.dgvResult.DataSource = resultManager.ReviewAllResults();
                }
                if (this.cboGrade.SelectedIndex == 0 && (int)this.cboSubject.SelectedValue != -1)
                {
                    this.dgvResult.DataSource = resultManager.ReviewStudentResultBySubjectNo(subjectNo);
                }
                if (this.cboGrade.SelectedIndex != 0 && (int)this.cboSubject.SelectedValue == -1)
                {
                    return;
                }
                if (this.cboGrade.SelectedIndex != 0 && (int)this.cboSubject.SelectedValue != -1)
                {
                    //根据学生名字，科目编号查询学习成绩信息
                    this.dgvResult.DataSource = resultManager.ReviewResultByStuNameAndSubjectNo(strStuName, subjectNo);
                }
            }
            if (strStuName !="") {
                if ((int)this.cboSubject.SelectedValue != -1)
                {
                    this.dgvResult.DataSource = resultManager.ReviewResultByStuNameAndSubjectNo(strStuName, subjectNo);
                }
                else {
                    MessageBox.Show("请选择科目和查询学生姓名","查询失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            //设置学生姓名和年级名字
            SetStuNameAndGradeName();
        }

        //设置学生姓名和年级名字
        public void SetStuNameAndGradeName()
        {
            //设置科目名称显示信息
            //DataGridViewRow :当前一行
            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                int id = Convert.ToInt32(row.Cells["SubjectNo"].Value);
                row.Cells["SubjectName"].Value = subjectManager.GetGradeDataBySubjectNo(id).SubjectName;
            }

            //设置 SubjctNo 不显示
            DataGridViewColumn column1 = (DataGridViewColumn)this.dgvResult.Columns["SubjectNo"];
            column1.Visible = false;

            //设置学生姓名显示信息
            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                int id = Convert.ToInt32(row.Cells["StudentNo"].Value);
                row.Cells["StudentName"].Value = studentManager.GetStudentByNo(id).StudentName;
            }
            //设置 StudentNo 不显示
            DataGridViewColumn column2 = (DataGridViewColumn)this.dgvResult.Columns["StudentNo"];
            column2.Visible = false;
            ////设置学生信息
            //DataGridViewComboBoxColumn cbo = (DataGridViewComboBoxColumn)this.dgvResult.Columns["StudentNo"];
            //cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            //cbo.DataSource = studentManager.GetStudentData();
            //cbo.DisplayMember = "StudentName";
            //cbo.ValueMember = "StudentNo";

        }

        //单击查询事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ReviewDataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //年级条件选择更改,二级联动
        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("cboGrade的值为：" + this.cboGrade.SelectedValue.ToString());
            try
            {
                //如果年级选项为全部，则将全部添加到科目中
                if (this.cboGrade.SelectedIndex == 0 )
                {
                    List<Subject> subjectList1 = subjectManager.GetSubjectData();
                    subjectList1.Insert(0, new Subject() { SubjectNo = -1, SubjectName = "全部" });
                    this.cboSubject.DataSource = subjectList1;
                    this.cboSubject.DisplayMember = "SubjectName";
                    this.cboSubject.ValueMember = "SubjectNo";
                    return;
                }
                else
                {
                    //查询到cboSubject 的数据源 ：1.先获得年级号，再查询获得
                    List<Subject> subjectList2 = subjectManager.GetSubjectDataByGradeId(Convert.ToInt32(this.cboGrade.SelectedValue));
                    this.cboSubject.DataSource = subjectList2;
                    this.cboSubject.DisplayMember = "SubjectName";
                    this.cboSubject.ValueMember = "SubjectNo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //右击删除学生信息事件
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(111);
                int iRow = this.dgvResult.CurrentRow.Index;
                if (iRow<0) {
                    return;
                }
                int iStudNo = 0;
                int iSubNo = 0;

                //获得 被选中的行的 StudentNo 的值 
                iStudNo = Convert.ToInt32(this.dgvResult.Rows[iRow].Cells["StudentNo"].Value.ToString());
                iSubNo = Convert.ToInt32(this.dgvResult.Rows[iRow].Cells["SubjectNo"].Value.ToString());

                Console.WriteLine(iStudNo +"  "+iSubNo);

                DialogResult dr = MessageBox.Show(ISDELETE, OPERATIONWARN, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    int iRet =  resultManager.DeleteStudentResult(iStudNo,iSubNo);
                    if (iRet > 0)
                    {
                        MessageBox.Show(DELETESUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //删除成功后，重新绑定数据
                        ReviewDataBind();
                    }
                    else {
                        MessageBox.Show(DELETEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONWARN,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        
        //点击选中当前行的信息添加到修改信息 GroupBox中
        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int iRow = e.RowIndex;
                if (iRow<0) {
                    return;
                }
                DataGridViewRow row = this.dgvResult.Rows[iRow];
                this.lbStuName.Text = row.Cells[0].Value.ToString();
                this.lbStuNo.Text = studentManager.GetStudentDataByName(row.Cells[0].Value.ToString())[0].StudentNo.ToString();
                this.cboSubject2.Text = row.Cells["SubjectName"].Value.ToString();
                this.txtResult.Text = row.Cells["StudentResult"].Value.ToString();
                this.dptExamDate.Text = row.Cells["ExamDate1"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //学生成绩非空信息验证
        private bool CheckInputNotEmpty()
        {
            if (this.cboSubject2.Text=="") {
                MessageBox.Show(SELECTSUBJECT,INPUTWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            if (this.txtResult.Text == "")
            {
                MessageBox.Show(INPUTRESULT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }

        // 对输入的考试时间进行检查验证
        /// <summary>
        /// 检查并格式化时间
        /// </summary>
        /// <param name="examDate"></param>
        /// <returns></returns>
        private string CheckExamDate(string examDate)
        {
            try
            {
                if (examDate == "")
                {
                    return string.Empty;
                }
                DateTime dateTime = Convert.ToDateTime(examDate);
                return dateTime.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }
        }

        //点击修改学生成绩
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNotEmpty()) {
                    return;
                }
                if (CheckExamDate(this.dptExamDate.Text)==string.Empty) {
                    return;
                }
                
                string strExamDate = CheckExamDate(this.dptExamDate.Text);
                Result result = new Result();
                result.StudentNo = Convert.ToInt32(this.lbStuNo.Text);
                result.SubjectNo = Convert.ToInt32(this.cboSubject2.SelectedValue);
                result.StudentResult = Convert.ToInt32(this.txtResult.Text.Trim());
                result.ExamDate = Convert.ToDateTime(this.dptExamDate.Text.Trim());

                Console.WriteLine(result.StudentNo+" " + result.SubjectNo+" "+ result.StudentResult+" "+ result.ExamDate);

                int res =  resultManager.UpdateStudentResult(result);
                if (res > 0)
                {
                    MessageBox.Show(UPDATESUCCESS, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReviewDataBind();
                }
                else {
                    MessageBox.Show(UPDATEFAILED, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
