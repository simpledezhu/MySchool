namespace MySchool.StudentForm
{
    partial class FrmStudentResult
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGradeName = new System.Windows.Forms.Label();
            this.chooseSubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNo,
            this.StudentName,
            this.SubjectName,
            this.StudentResult,
            this.ExamDate,
            this.SubjectNo});
            this.dataGridView1.Location = new System.Drawing.Point(48, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(654, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "学生学号";
            this.StudentNo.Name = "StudentNo";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "学生姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.Visible = false;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "科目名称";
            this.SubjectName.Name = "SubjectName";
            // 
            // StudentResult
            // 
            this.StudentResult.DataPropertyName = "StudentResult";
            this.StudentResult.HeaderText = "学生成绩";
            this.StudentResult.Name = "StudentResult";
            // 
            // ExamDate
            // 
            this.ExamDate.DataPropertyName = "ExamDate";
            this.ExamDate.HeaderText = "考试时间";
            this.ExamDate.Name = "ExamDate";
            // 
            // SubjectNo
            // 
            this.SubjectNo.DataPropertyName = "SubjectNo";
            this.SubjectNo.HeaderText = "科目编号";
            this.SubjectNo.Name = "SubjectNo";
            this.SubjectNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "年  级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "科  目";
            // 
            // labelGradeName
            // 
            this.labelGradeName.Location = new System.Drawing.Point(188, 66);
            this.labelGradeName.Name = "labelGradeName";
            this.labelGradeName.Size = new System.Drawing.Size(191, 15);
            this.labelGradeName.TabIndex = 4;
            this.labelGradeName.Text = "GradeName";
            // 
            // chooseSubject
            // 
            this.chooseSubject.FormattingEnabled = true;
            this.chooseSubject.Location = new System.Drawing.Point(191, 126);
            this.chooseSubject.Name = "chooseSubject";
            this.chooseSubject.Size = new System.Drawing.Size(157, 23);
            this.chooseSubject.TabIndex = 5;
            this.chooseSubject.DropDownClosed += new System.EventHandler(this.chooseSubject_DropDownClosed);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "查询条件：";
            // 
            // FrmStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chooseSubject);
            this.Controls.Add(this.labelGradeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FrmStudentResult";
            this.Text = "FrmStudentResult";
            this.Load += new System.EventHandler(this.FrmStudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGradeName;
        private System.Windows.Forms.ComboBox chooseSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNo;
    }
}