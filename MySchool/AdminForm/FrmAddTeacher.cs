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
    public partial class FrmAddTeacher : Form
    {

        #region 常量、变量定义
        private GradeManager gradeManager = new GradeManager();
        private TeacherManager teacherManager = new TeacherManager();
        #endregion

        public FrmAddTeacher()
        {
            InitializeComponent();
        }

        private void FrmAddTeacher_Load(object sender, EventArgs e)
        {
            BindDataGrade();
        }

        //窗体加载前加载学期cboGrade
        private void BindDataGrade()
        {
            this.cboGrade.DataSource = gradeManager.GetGradeData();
            cboGrade.DisplayMember = "GradeName";
            cboGrade.ValueMember = "GradeId";
        }

        //检查非空
        private bool CheckNotEmpty() {
            if (this.txtTeacherName.Text=="") {
                MessageBox.Show("教师姓名不能为空！", "输入提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtTeacherName.Focus();
                return false;
            }
            if (this.txtTeacherAge.Text == "")
            {
                MessageBox.Show("教师年龄不能为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTeacherAge.Focus();
                return false;
            }
            if (this.txtTeachYear.Text == "")
            {
                MessageBox.Show("教师教龄不能为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTeachYear.Focus();
                return false;
            }
            if (this.cboGrade.Text == "")
            {
                MessageBox.Show("学期不能为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboGrade.Focus();
                return false;
            }
            return true;
        }

        //点击添加教师信息事件
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckNotEmpty())
                {
                    return;
                }
                Teacher teacher = new Teacher();
                teacher.Name = txtTeacherName.Text.Trim().ToString();
                teacher.Age = Convert.ToInt32(txtTeacherAge.Text.Trim());
                teacher.TeachYear = Convert.ToInt32(txtTeachYear.Text.Trim());
                teacher.GradeId = Convert.ToInt32(cboGrade.SelectedValue);
                bool result = teacherManager.AddTeacher(teacher);
                if (result)
                {
                    MessageBox.Show("添加成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //刷新 teacher数据
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //取消、返回
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
