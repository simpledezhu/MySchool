namespace MySchool.AdminForm
{
    partial class FrmStudentInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStuPwd = new System.Windows.Forms.TextBox();
            this.lbStuNo = new System.Windows.Forms.Label();
            this.cboStudentGrade = new System.Windows.Forms.ComboBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.txtStuIdentityCard = new System.Windows.Forms.TextBox();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.txtStuAddress = new System.Windows.Forms.TextBox();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbStuBoy = new System.Windows.Forms.RadioButton();
            this.rbStuGirl = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvStuInfor = new System.Windows.Forms.DataGridView();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuInfor)).BeginInit();
            this.cmsDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(588, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 25);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(356, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 25);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(91, 29);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 23);
            this.cboGrade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "年级";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStuPwd);
            this.groupBox2.Controls.Add(this.lbStuNo);
            this.groupBox2.Controls.Add(this.cboStudentGrade);
            this.groupBox2.Controls.Add(this.dtpBornDate);
            this.groupBox2.Controls.Add(this.txtStuIdentityCard);
            this.groupBox2.Controls.Add(this.txtStuEmail);
            this.groupBox2.Controls.Add(this.txtStuAddress);
            this.groupBox2.Controls.Add(this.txtStuPhone);
            this.groupBox2.Controls.Add(this.txtStuName);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(22, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // txtStuPwd
            // 
            this.txtStuPwd.Location = new System.Drawing.Point(238, 29);
            this.txtStuPwd.Name = "txtStuPwd";
            this.txtStuPwd.Size = new System.Drawing.Size(121, 25);
            this.txtStuPwd.TabIndex = 24;
            // 
            // lbStuNo
            // 
            this.lbStuNo.Location = new System.Drawing.Point(76, 27);
            this.lbStuNo.Name = "lbStuNo";
            this.lbStuNo.Size = new System.Drawing.Size(96, 25);
            this.lbStuNo.TabIndex = 23;
            this.lbStuNo.Text = "123";
            this.lbStuNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboStudentGrade
            // 
            this.cboStudentGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentGrade.FormattingEnabled = true;
            this.cboStudentGrade.Location = new System.Drawing.Point(703, 29);
            this.cboStudentGrade.Name = "cboStudentGrade";
            this.cboStudentGrade.Size = new System.Drawing.Size(121, 23);
            this.cboStudentGrade.TabIndex = 22;
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Location = new System.Drawing.Point(450, 64);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(182, 25);
            this.dtpBornDate.TabIndex = 21;
            // 
            // txtStuIdentityCard
            // 
            this.txtStuIdentityCard.Location = new System.Drawing.Point(79, 110);
            this.txtStuIdentityCard.Name = "txtStuIdentityCard";
            this.txtStuIdentityCard.Size = new System.Drawing.Size(242, 25);
            this.txtStuIdentityCard.TabIndex = 20;
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(707, 69);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(118, 25);
            this.txtStuEmail.TabIndex = 19;
            // 
            // txtStuAddress
            // 
            this.txtStuAddress.Location = new System.Drawing.Point(238, 69);
            this.txtStuAddress.Name = "txtStuAddress";
            this.txtStuAddress.Size = new System.Drawing.Size(121, 25);
            this.txtStuAddress.TabIndex = 18;
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(79, 68);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(110, 25);
            this.txtStuPhone.TabIndex = 17;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(408, 29);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(105, 25);
            this.txtStuName.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbStuBoy);
            this.panel1.Controls.Add(this.rbStuGirl);
            this.panel1.Location = new System.Drawing.Point(539, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 23);
            this.panel1.TabIndex = 14;
            // 
            // rbStuBoy
            // 
            this.rbStuBoy.AutoSize = true;
            this.rbStuBoy.Location = new System.Drawing.Point(62, 4);
            this.rbStuBoy.Name = "rbStuBoy";
            this.rbStuBoy.Size = new System.Drawing.Size(40, 19);
            this.rbStuBoy.TabIndex = 1;
            this.rbStuBoy.TabStop = true;
            this.rbStuBoy.Text = "男";
            this.rbStuBoy.UseVisualStyleBackColor = true;
            // 
            // rbStuGirl
            // 
            this.rbStuGirl.AutoSize = true;
            this.rbStuGirl.Location = new System.Drawing.Point(16, 4);
            this.rbStuGirl.Name = "rbStuGirl";
            this.rbStuGirl.Size = new System.Drawing.Size(40, 19);
            this.rbStuGirl.TabIndex = 0;
            this.rbStuGirl.TabStop = true;
            this.rbStuGirl.Text = "女";
            this.rbStuGirl.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "身份证";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(656, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "出生年月";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "年级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "学号";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(738, 115);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvStuInfor
            // 
            this.dgvStuInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNo,
            this.LoginPwd,
            this.StudentName,
            this.Gender,
            this.GradeId,
            this.Phone,
            this.Address,
            this.BornDate,
            this.Email,
            this.IdentityCard});
            this.dgvStuInfor.ContextMenuStrip = this.cmsDelete;
            this.dgvStuInfor.Location = new System.Drawing.Point(22, 116);
            this.dgvStuInfor.Name = "dgvStuInfor";
            this.dgvStuInfor.RowTemplate.Height = 27;
            this.dgvStuInfor.Size = new System.Drawing.Size(857, 249);
            this.dgvStuInfor.TabIndex = 2;
            this.dgvStuInfor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuInfor_CellClick);
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "学号";
            this.StudentNo.Name = "StudentNo";
            // 
            // LoginPwd
            // 
            this.LoginPwd.DataPropertyName = "LoginPwd";
            this.LoginPwd.HeaderText = "密码";
            this.LoginPwd.Name = "LoginPwd";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            // 
            // GradeId
            // 
            this.GradeId.DataPropertyName = "GradeId";
            this.GradeId.HeaderText = "年级";
            this.GradeId.Name = "GradeId";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            // 
            // BornDate
            // 
            this.BornDate.DataPropertyName = "BornDate";
            this.BornDate.HeaderText = "出生年月日";
            this.BornDate.Name = "BornDate";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮箱";
            this.Email.Name = "Email";
            // 
            // IdentityCard
            // 
            this.IdentityCard.DataPropertyName = "IdentityCard";
            this.IdentityCard.HeaderText = "身份证号";
            this.IdentityCard.Name = "IdentityCard";
            // 
            // cmsDelete
            // 
            this.cmsDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.xToolStripMenuItem});
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(210, 79);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(138, 24);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.xToolStripMenuItem.Text = "新增成绩";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(760, 554);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 604);
            this.ContextMenuStrip = this.cmsDelete;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvStuInfor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.FrmStudentInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuInfor)).EndInit();
            this.cmsDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvStuInfor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbStuBoy;
        private System.Windows.Forms.RadioButton rbStuGirl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStuIdentityCard;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.TextBox txtStuAddress;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.ContextMenuStrip cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboStudentGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewComboBoxColumn GradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BornDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityCard;
        private System.Windows.Forms.Label lbStuNo;
        private System.Windows.Forms.TextBox txtStuPwd;
    }
}