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
    public partial class FrmStudentInfo : Form
    {

        #region 变量、常量定义
        public const string OPERATIONFAILED = "操作播误!";
        public const string INPUTWARN = "输入提示";
        public const string INPUTPWD = "请输入密码!";
        public const string INPUTNAME = "请输入姓名!";
        public const string INPUTSTUNO = "请输入学号!";
        public const string INPUTSEX = "请选择性别!";
        public const string INPUTGRADENO = "请选择年级";
        public const string INPUTIDENTITYCARD = "请输入身份证号!";
        public const string INPUTDATEWRONG = "输入的出生年月日格式有误!";
        public const string INPUTEMAILWRONG = "输入的Exail格式有误!";
        public const string OPERATIONWARN = "操作提示";
        public const string UPDATEFAILED = "更新失败!";
        public const string UPDATESUCCESS = "更新成功!";
        public const string INSERTSUCCESS = "插入成功!";
        public const string INSERTFAILED = "插入失败!";
        public const string DELETESUCCESS = "删除成功!";
        public const string DELETEFAILED = "删除失败!";
        public const string SEARCHFAILED = "查询失败！";
        public const string STUDENTNOISEXIST = "学号已存在!";
        public const string ISDELETE = "确定要删除该用户吗？";
        public const string NOEXPORT = "无数据导出！";

        List<Grade> gradeList = new List<Grade>();
        StudentManager studentManager = new StudentManager();
        GradeManager gradeManager = new GradeManager();

        #endregion

        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 绑定年级信息
        /// </summary>
        public void GradeDataBind()
        {
            //给查询中Grade 的combobox绑定数据
            gradeList = gradeManager.GetGradeData();
            this.cboGrade.DataSource = gradeList;
            this.cboGrade.DisplayMember = "GradeName";
            this.cboGrade.ValueMember = "GradeId";

            //给修改中Grade 的combobox绑定数据
            this.cboStudentGrade.DataSource = gradeList;
            this.cboStudentGrade.DisplayMember = "GradeName";
            this.cboStudentGrade.ValueMember = "GradeId";

        }

        /// <summary>
        /// 学生全部信息绑定
        /// </summary>
        public void StudentDataBind()
        {
            List<Student> students = studentManager.GetStudentData();
            this.dgvStuInfor.DataSource = students;
        }

        /// <summary>
        /// 根据检索条件取得学生信息并绑定
        /// </summary>
        public void StudentDataBindByName()
        {
            List<Student> studentList = studentManager.GetStudentDataByNameAndGrade(this.txtName.Text.Trim(), Convert.ToInt32(this.cboGrade.SelectedValue));
            this.dgvStuInfor.DataSource = studentList;
        }

        /// <summary>
        /// 实体类实现学生表和年级表的关联显示
        /// </summary>
        public void SetGradeName() {
            DataGridViewComboBoxColumn cbo = (DataGridViewComboBoxColumn)this.dgvStuInfor.Columns["GradeId"];
            cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            cbo.DataSource = gradeManager.GetGradeData();
            cbo.DisplayMember = "GradeName";
            cbo.ValueMember = "GradeId";
        }


        /// <summary>
        /// 加载框体
        /// </summary>
        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            dgvStuInfor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                GradeDataBind();
                StudentDataBind();
                SetGradeName();
                this.cboGrade.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONFAILED,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //单击查询事件
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvStuInfor.DataSource = studentManager.GetStudentDataByNameAndGrade(this.txtName.Text.Trim(), Convert.ToInt32(this.cboGrade.SelectedValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(SEARCHFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //显示被选中学生信息方法
        public void SetModifyData() {
            //判断有没有被选中的行
            if (this.dgvStuInfor.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = this.dgvStuInfor.CurrentRow;
                this.lbStuNo.Text = dgvr.Cells[0].Value.ToString();
                this.txtStuPwd.Text = dgvr.Cells[1].Value.ToString();
                this.txtStuName.Text = dgvr.Cells[2].Value.ToString();
                Console.WriteLine(dgvr.Cells[3].Value.ToString());
                if (dgvr.Cells[3].Value.ToString().Equals("True"))
                {
                    this.rbStuGirl.Checked = true;
                }
                else
                {
                    this.rbStuBoy.Checked = true;
                }
                this.cboStudentGrade.Text = gradeList[Convert.ToInt32(dgvr.Cells[4].Value) - 1].GradeName.ToString();
                this.txtStuPhone.Text = dgvr.Cells[5].Value.ToString();
                this.txtStuAddress.Text = dgvr.Cells[6].Value.ToString();
                this.dtpBornDate.Text = dgvr.Cells[7].Value.ToString();
                this.txtStuEmail.Text = dgvr.Cells[8].Value.ToString();
                this.txtStuIdentityCard.Text = dgvr.Cells[9].Value.ToString();
            }
        }

        //单击在修改框中显示学生数据
        private void dgvStuInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetModifyData();
        }

        //检查输入非空
        public bool CheckInputNoEmpty()
        {
            if (this.txtStuPwd.Text.Trim()=="") {
                MessageBox.Show(INPUTPWD,INPUTWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtStuPwd.Focus();
                return false;
            }
            if (this.txtStuName.Text.Trim() == "")
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuName.Focus();
                return false;
            }
            if (!this.rbStuGirl.Checked && !this.rbStuBoy.Checked)
            { 
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuName.Focus();
                return false;
            }
            if (this.cboStudentGrade.Text.Trim()=="")
            {
                MessageBox.Show(INPUTGRADENO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStudentGrade.Focus();
                return false;
            }
            if (this.txtStuIdentityCard.Text.Trim() == "")
            {
                MessageBox.Show(INPUTIDENTITYCARD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStudentGrade.Focus();
                return false;
            }
            return true;
        }

        //验证日期和邮箱的格式
        public bool CheckForamt()
        {
            //验证邮箱
            if (!(this.txtStuEmail.Text.Trim()==""))
            {
                if (!this.txtStuEmail.Text.Contains("@"))
                {
                    MessageBox.Show(INPUTEMAILWRONG,INPUTWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.txtStuIdentityCard.Focus();
                    return false;
                }

            }
            return true;

        }

        //单击修改学生数据
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNoEmpty()) {
                    return;                //跳出程序
                }
                if (!CheckForamt()) {
                    return;                //跳出程序
                }
                string strSex = "";
                if (this.rbStuGirl.Checked)
                {
                    strSex = "1";
                }
                else if (this.rbStuBoy.Checked)
                {
                    strSex = "0";
                }
                else
                {
                    return;
                }

                //创建实体类来接收数据
                Student student = new Student();
                student.StudentNo = Convert.ToInt32(this.lbStuNo.Text.Trim());
                student.LoginPwd = this.txtStuPwd.Text.Trim();
                student.StudentName = this.txtStuName.Text.Trim();
                student.Gender = strSex;
                student.GradeId = Convert.ToInt32(this.cboStudentGrade.SelectedValue);
                student.Phone = this.txtStuPhone.Text.Trim();
                student.Address = this.txtStuAddress.Text.Trim();
                student.BornDate = this.dtpBornDate.Value;
                student.Email = this.txtStuEmail.Text.Trim();
                student.IdentityCard = this.txtStuIdentityCard.Text.Trim();

                int result = new StudentManager().UpdateStudent(student);  //返回受影响行数
                if (result > 0)
                {
                    MessageBox.Show(UPDATESUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show(UPDATEFAILED,OPERATIONWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
                //刷新学生信息
                StudentDataBind();
                SetGradeName();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Console.WriteLine(ex.Message);
            }
        }

        //右击点击“删除”按钮时
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(ISDELETE,OPERATIONWARN,MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if (dr == DialogResult.OK) {        //确定删除
                    //获取 选中当前单元格数据（即获取被删除的学生学号）
                    string iCellValue = this.dgvStuInfor.CurrentRow.Cells[0].Value.ToString();
                    int result = studentManager.DeleteStudentInfo(Convert.ToInt32(iCellValue));
                    if (result > 0)
                    {
                        MessageBox.Show(DELETESUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //删除成功后，重新绑定数据
                        StudentDataBind();
                    }
                    else {
                        MessageBox.Show(DELETEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONFAILED,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //返回事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //右击点击添加学生成绩事件
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddResult far = new FrmAddResult();
            far.studentNo = this.dgvStuInfor.CurrentRow.Cells[0].Value.ToString();
            far.studentName = this.dgvStuInfor.CurrentRow.Cells[2].Value.ToString();
            //显示FrmAddResult ：添加学生成绩窗口
            far.Show();
        }



    }
}
