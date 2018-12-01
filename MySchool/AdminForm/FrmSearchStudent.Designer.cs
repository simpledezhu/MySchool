namespace MySchool.AdminForm
{
    partial class FrmSearchStudent
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.dgvStudentNames = new System.Windows.Forms.DataGridView();
            this.StudentNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNames)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 25);
            this.txtName.TabIndex = 1;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(299, 32);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "查找";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // dgvStudentNames
            // 
            this.dgvStudentNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNO,
            this.StudentName});
            this.dgvStudentNames.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvStudentNames.Location = new System.Drawing.Point(42, 82);
            this.dgvStudentNames.Name = "dgvStudentNames";
            this.dgvStudentNames.RowTemplate.Height = 27;
            this.dgvStudentNames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentNames.Size = new System.Drawing.Size(332, 269);
            this.dgvStudentNames.TabIndex = 3;
            // 
            // StudentNO
            // 
            this.StudentNO.DataPropertyName = "StudentNO";
            this.StudentNO.HeaderText = "学生学号";
            this.StudentNO.Name = "StudentNO";
            this.StudentNO.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "学生姓名";
            this.StudentName.Name = "StudentName";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增成绩ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // 新增成绩ToolStripMenuItem
            // 
            this.新增成绩ToolStripMenuItem.Name = "新增成绩ToolStripMenuItem";
            this.新增成绩ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.新增成绩ToolStripMenuItem.Text = "新增成绩";
            this.新增成绩ToolStripMenuItem.Click += new System.EventHandler(this.新增成绩ToolStripMenuItem_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(299, 373);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmSearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 418);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvStudentNames);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询学生";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNames)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.DataGridView dgvStudentNames;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增成绩ToolStripMenuItem;
    }
}