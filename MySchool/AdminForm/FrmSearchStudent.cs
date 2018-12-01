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

namespace MySchool.AdminForm
{
    public partial class FrmSearchStudent : Form
    {
        #region 常量、变量定义
        private const string OPERATIONFAILED = "操作错误";
        private const string OPERATIONWARN = "操作提示";


        private StudentManager studentManager = new StudentManager(); 
        #endregion


        public FrmSearchStudent()
        {
            InitializeComponent();
            this.dgvStudentNames.AutoGenerateColumns = false;
        }

        //返回按钮绑定事件
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //点击查询按钮 查询指定学生信息
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvStudentNames.DataSource = studentManager.GetStudentDataByName(this.txtName.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,OPERATIONFAILED,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }

        //在查询学生功能上右击给学生添加成绩
        private void 新增成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentNames.SelectedRows.Count>0) {
                FrmAddResult far = new FrmAddResult();
                far.studentNo = this.dgvStudentNames.CurrentRow.Cells[0].Value.ToString();
                far.Show();
                
            }

        }


    }
}
