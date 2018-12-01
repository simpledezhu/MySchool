using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool.StudentForm
{
    public partial class FrmStudentMain : Form
    {
        #region 变量、常量定义
        public const string ISEXIT = "确定要退出吗？";
        public const string EXITAPPLICATION = "退出系统"; 
        #endregion

        public FrmStudentMain()
        {
            InitializeComponent();
        }

        //单击退出事件
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show(ISEXIT, EXITAPPLICATION, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr==System.Windows.Forms.DialogResult.OK) {     //弹窗的OK键   DialogResult:枚举类型
                Application.Exit();
            }

        }

        //单击查询成绩事件
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //显示成绩窗体
            FrmStudentResult fsr = new FrmStudentResult();
            fsr.MdiParent = this;
            fsr.Show();


        }




    }
}
