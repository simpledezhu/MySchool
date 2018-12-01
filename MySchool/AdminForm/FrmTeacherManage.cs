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
    public partial class FrmTeacherManager : Form
    {
        private TeacherManager teacherManager = new TeacherManager();

        public FrmTeacherManager()
        {
            InitializeComponent();
            //消除dgvTeacher的自动补充列
            this.dgvTeacher.AutoGenerateColumns = false;
        }

        //加载窗体
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            LoadTeacher();
        }

        //创建老师信息加载方法
        private void LoadTeacher()
        {
            this.dgvTeacher.DataSource = teacherManager.GetAllTeacher();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除教师信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //如果点击确认按钮，进行删除操作
            if (dr == DialogResult.OK) {
                foreach (DataGridViewRow row in dgvTeacher.Rows)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["ch"];
                    bool flag = Convert.ToBoolean(cell.Value);
                    if (flag == true)
                    {
                        int teacherId = Convert.ToInt32(row.Cells[4].Value);
                        teacherManager.DeleteTeacherById(teacherId);
                    }
                }
                //删除之后重新绑定dgv
                LoadTeacher();
            }    
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            FrmAddTeacher fat = new FrmAddTeacher();
            fat.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeacher();
        }
    }
}
