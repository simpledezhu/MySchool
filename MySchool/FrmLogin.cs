using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchoolModels;
using MySchoolBll;
using MySchool.StudentForm;
using MySchool.AdminForm;

namespace MySchool
{
    public partial class FrmLogin : Form
    {

        #region 常量、变量的定义
        public const string INPUTUSERNAME= "请输入用户名";
        public const string INPUTWARN = "输入提示";
        public const string INPUTPWD = "请输入密码";
        public const string LOGINFAILED = "登录失败";
        public const string INPUTNOEXIST = "用户名或密码不存在";
        AdminManager adminManager = new AdminManager();
        StudentManager studentManager = new StudentManager();
        #endregion

        //构造函数
        public FrmLogin()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndex = 0;
        }

        //单机取消事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region 输入验证
        //
        public bool CheckInput()
        {
            if (this.txtName.Text == "")
            {   
                //没输如用户名弹出提示：（提示内容，标题，OK按钮，图标显示：提示）
                MessageBox.Show(INPUTUSERNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return false;
            }
            if (this.txtPwd.Text == "")
            {
                //没输如用户名弹出提示：（提示内容，标题，OK按钮，图标显示：提示）
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
                return false;
            }
            return true;
        }
        #endregion

        //单击登录事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput())
                {
                    return;
                }
                if (this.cboType.SelectedIndex == 0)
                {  //管理员
                    if (adminManager.CheckAdminLogin(txtName.Text.Trim(), txtPwd.Text.Trim()))
                    {
                        //MessageBox.Show("管理员登录成功");
                        UserInfo.loginId = this.txtName.Text.Trim();
                        UserInfo.loginPwd = this.txtPwd.Text.Trim();
                        UserInfo.loginType = this.cboType.Text.Trim();

                        FrmAdminMain fam = new FrmAdminMain();
                        fam.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(INPUTNOEXIST, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {                                  //学生
                    if (studentManager.CheckStudentLogin(Convert.ToInt32(txtName.Text.Trim()), txtPwd.Text.Trim()))
                    {
                        //MessageBox.Show("学生登录成功");
                        UserInfo.loginId = this.txtName.Text.Trim();
                        UserInfo.loginPwd = this.txtPwd.Text.Trim();
                        UserInfo.loginType = this.cboType.Text.Trim();
                        FrmStudentMain frm = new FrmStudentMain();
                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(INPUTNOEXIST, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,LOGINFAILED,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }






    }
}
