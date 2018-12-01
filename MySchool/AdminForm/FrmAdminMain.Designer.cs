namespace MySchool.AdminForm
{
    partial class FrmAdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslAddStudent = new System.Windows.Forms.ToolStripButton();
            this.tslSearchStudentInfo = new System.Windows.Forms.ToolStripButton();
            this.tslSearchResult = new System.Windows.Forms.ToolStripButton();
            this.tslReviewResult = new System.Windows.Forms.ToolStripButton();
            this.tslTeacherManager = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(51, 24);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAddStudent,
            this.tslSearchStudentInfo,
            this.tslSearchResult,
            this.tslReviewResult,
            this.tslTeacherManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslAddStudent
            // 
            this.tslAddStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tslAddStudent.Image")));
            this.tslAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslAddStudent.Name = "tslAddStudent";
            this.tslAddStudent.Size = new System.Drawing.Size(103, 24);
            this.tslAddStudent.Text = "新建学生用户";
            this.tslAddStudent.Click += new System.EventHandler(this.tslAddStudent_Click);
            // 
            // tslSearchStudentInfo
            // 
            this.tslSearchStudentInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslSearchStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("tslSearchStudentInfo.Image")));
            this.tslSearchStudentInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslSearchStudentInfo.Name = "tslSearchStudentInfo";
            this.tslSearchStudentInfo.Size = new System.Drawing.Size(103, 24);
            this.tslSearchStudentInfo.Text = "学生信息管理";
            this.tslSearchStudentInfo.Click += new System.EventHandler(this.tslSearchStudentInfo_Click);
            // 
            // tslSearchResult
            // 
            this.tslSearchResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslSearchResult.Image = ((System.Drawing.Image)(resources.GetObject("tslSearchResult.Image")));
            this.tslSearchResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslSearchResult.Name = "tslSearchResult";
            this.tslSearchResult.Size = new System.Drawing.Size(73, 24);
            this.tslSearchResult.Text = "查询学生";
            this.tslSearchResult.Click += new System.EventHandler(this.tslSearchResult_Click);
            // 
            // tslReviewResult
            // 
            this.tslReviewResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslReviewResult.Image = ((System.Drawing.Image)(resources.GetObject("tslReviewResult.Image")));
            this.tslReviewResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslReviewResult.Name = "tslReviewResult";
            this.tslReviewResult.Size = new System.Drawing.Size(103, 24);
            this.tslReviewResult.Text = "查询学生成绩";
            this.tslReviewResult.Click += new System.EventHandler(this.tslReviewResult_Click);
            // 
            // tslTeacherManager
            // 
            this.tslTeacherManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslTeacherManager.Image = ((System.Drawing.Image)(resources.GetObject("tslTeacherManager.Image")));
            this.tslTeacherManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslTeacherManager.Name = "tslTeacherManager";
            this.tslTeacherManager.Size = new System.Drawing.Size(103, 24);
            this.tslTeacherManager.Text = "教师信息管理";
            this.tslTeacherManager.Click += new System.EventHandler(this.tslTeacherManager_Click);
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 507);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchool-管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tslAddStudent;
        private System.Windows.Forms.ToolStripButton tslSearchStudentInfo;
        private System.Windows.Forms.ToolStripButton tslSearchResult;
        private System.Windows.Forms.ToolStripButton tslReviewResult;
        private System.Windows.Forms.ToolStripButton tslTeacherManager;
    }
}