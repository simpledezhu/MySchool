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
    public partial class FrmAdminMain : Form
    {
        public FrmAdminMain()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr==System.Windows.Forms.DialogResult.OK) {
                Application.Exit();
            }

        }

        //新建用户事件
        private void tslAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent fas = new FrmAddStudent();
            fas.MdiParent = this;
            fas.Show();
        }
        
        //显示学生信息界面
        private void tslSearchStudentInfo_Click(object sender, EventArgs e)
        {
            FrmStudentInfo fsi = new FrmStudentInfo();
            fsi.MdiParent = this;
            fsi.Show();

        }

        //添加学习成绩
        private void tslSearchResult_Click(object sender, EventArgs e)
        {
            FrmSearchStudent fss = new FrmSearchStudent();
            fss.MdiParent = this;
            fss.Show();
        }

        private void tslReviewResult_Click(object sender, EventArgs e)
        {
            FrmReviewResult frr = new FrmReviewResult();
            frr.MdiParent = this;
            frr.Show();
        }

        private void tslTeacherManager_Click(object sender, EventArgs e)
        {
            FrmTeacherManager ftm = new FrmTeacherManager();
            ftm.MdiParent = this;
            ftm.Show();
        }
    }
}
