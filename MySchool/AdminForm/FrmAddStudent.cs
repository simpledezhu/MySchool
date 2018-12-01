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
    public partial class FrmAddStudent : Form
    {
        #region 变量、常量的定义
        GradeManager gradeManager = new GradeManager();

        public const string INPUTWARN = "输入提示";
        public const string INPUTPWD ="请输入密码";
        public const string INPUTNAME = "请输入姓名";
        public const string INPUTSTUNO = "请输入学号";
        public const string INPUTSEX = "请选择性别";
        public const string INPUTGRADENO = "请选择年级";
        public const string INPUTIDENTITYCARD = "请输入身份证号";
        public const string INPUTPWDNOTSAME = "两次输入的密码不一致!";
        public const string INPUTDATEWRONG = "输入的出生年月日格式有误!";
        public const string INPUTEMAILWRONG = "输入的Email格式有误!";
        public const string INSERTFAILED = "添加失败！";
        public const string INSERTSUCESS = "添加成功！";
        public const string OPERATIONWARN = "操作提示!";
        public const string STUDENTNOISEXIST = "学号已存在!";
        public const string IDCARDISEXIST = "身份证号已存在!";
        public const string OPERATIONFAILED = "操作错误！";
        #endregion


        public FrmAddStudent()
        {
            InitializeComponent();
        }


        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            GradeDateBind();
        }

        //绑定 年级Combox
        public void GradeDateBind()
        {
            try
            {
                List<Grade> gradeList = gradeManager.GetGradeData();
                this.cboGrade.DataSource = gradeList;
                //显示的是年级
                this.cboGrade.DisplayMember = "GradeName";
                //隐藏的是 代表的值是 GradeId
                this.cboGrade.ValueMember = "GradeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONFAILED,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //非空验证
        public bool CheckInputNotEmpty()
        {
            //判断学号
            if (this.txtStuNo.Text.Trim().Equals("")) {
                MessageBox.Show(INPUTSTUNO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //获取光标
                this.txtStuNo.Focus();
                return false;
            }
            //判断密码
            if (this.txtPwd.Text.Trim().Equals("") || this.txtRePwd.Text.Trim()=="")
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuNo.Focus();
                return false;
            }
            //判断姓名
            if (this.txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return false;
            }
            //判断男女性别
            if (!this.rbBoy.Checked && !this.rbGirl.Checked)
            {
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rbGirl.Focus();
                return false;
            }
            //判断 年级是否为空
            if (this.cboGrade.Text.Trim()=="")
            {
                MessageBox.Show(INPUTGRADENO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboGrade.Focus();
                return false;
            }
            //判断身份证号是否为空
            if (this.txtIdentityCard.Text.Trim() == "")
            {
                MessageBox.Show(INPUTGRADENO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboGrade.Focus();
                return false;
            }
            return true;
        }

        //验证 两次输入的密码是否一致
        public bool CheckPwd()
        {
            if (this.txtPwd.Text.Trim() ==txtPwd.Text.Trim()) {
                return true;
            }
            return false;
        }

        //检查 数据格式是否正确
        public bool CheckFormat()
        {
            //检查日期格式是否转换正确
            //bool flag = false;
            if (!(this.txtBornDate.Text.Trim()==""))
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(this.txtBornDate.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show(INPUTDATEWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            //检查邮箱格式是否正确
            if (!(this.txtEmail.Text.Trim()==""))
            {
                //如果包含@符号
                if (!(this.txtEmail.Text.Trim().Contains("@")))
                {
                    MessageBox.Show(INPUTEMAILWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;

        }

        //单击添加事件
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNotEmpty()) {
                    return;                    //return 表示结束方法
                }
                if (!CheckPwd()) {
                    return;
                }
                if (!CheckFormat()) {
                    return;
                }
                string strSex = "";
                if (this.rbGirl.Checked)
                {
                    strSex = "1";
                }
                else if (this.rbBoy.Checked)
                {
                    strSex = "0";
                }
                else {
                    return;
                }

                //创建实体类来接收数据
                Student student = new Student();
                student.StudentNo = Convert.ToInt32(this.txtStuNo.Text.Trim());
                student.LoginPwd = this.txtPwd.Text.Trim();
                student.StudentName = this.txtName.Text.Trim();
                student.Gender = strSex;
                student.GradeId = Convert.ToInt32(this.cboGrade.SelectedValue);
                student.Phone = this.txtPhone.Text.Trim();
                student.Address = this.txtAddress.Text.Trim();
                student.BornDate = Convert.ToDateTime(this.txtBornDate.Text.Trim());
                student.Email = this.txtEmail.Text.Trim();
                student.IdentityCard = this.txtIdentityCard.Text.Trim();

                int result =  new StudentManager().AddStudent(student);  //返回受影响行数
                if (result > 0)
                {
                    MessageBox.Show(INSERTSUCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else {
                    MessageBox.Show(INSERTFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONFAILED,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
