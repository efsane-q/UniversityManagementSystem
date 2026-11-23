namespace UniversityManagementSystem
{
    partial class MainForm
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
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblIcon1 = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.lblStudentsTitle = new System.Windows.Forms.Label();
            this.lblStudentsCount = new System.Windows.Forms.Label();
            this.lblStudentsIcon = new System.Windows.Forms.Label();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.lblIcon2 = new System.Windows.Forms.Label();
            this.lblCoursesCount = new System.Windows.Forms.Label();
            this.lblCoursesTitle = new System.Windows.Forms.Label();
            this.pnlGrades = new System.Windows.Forms.Panel();
            this.lblIcon3 = new System.Windows.Forms.Label();
            this.lblGradesCount = new System.Windows.Forms.Label();
            this.lblGradesTitle = new System.Windows.Forms.Label();
            this.pnlGradeManagement = new System.Windows.Forms.Panel();
            this.lblGradeManagement = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.btnDeleteGrade = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.lblAverageTitle = new System.Windows.Forms.Label();
            this.pnlAverageCard = new System.Windows.Forms.Panel();
            this.lblAverage = new System.Windows.Forms.Label();
            this.pnlAverageValue = new System.Windows.Forms.Panel();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.pnlWelcome.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.pnlCourses.SuspendLayout();
            this.pnlGrades.SuspendLayout();
            this.pnlGradeManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.pnlAverageCard.SuspendLayout();
            this.pnlAverageValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWelcome.BackColor = System.Drawing.Color.Lavender;
            this.pnlWelcome.Controls.Add(this.lblIcon1);
            this.pnlWelcome.Controls.Add(this.lblIcon);
            this.pnlWelcome.Controls.Add(this.lblSubtitle);
            this.pnlWelcome.Controls.Add(this.lblTitle);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Location = new System.Drawing.Point(20, 20);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(1500, 200);
            this.pnlWelcome.TabIndex = 0;
            this.pnlWelcome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWelcome_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblWelcome.Location = new System.Drawing.Point(54, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(230, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Xoş gəlmisiniz!";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(117, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(640, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Universitet İdarəetmə Sistemi";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSubtitle.Location = new System.Drawing.Point(181, 155);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(456, 25);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Tələbələri, fənləri və qiymətləri vahid sistemdə idarə edin";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(723, 105);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(0, 23);
            this.lblIcon.TabIndex = 3;
            // 
            // lblIcon1
            // 
            this.lblIcon1.AutoSize = true;
            this.lblIcon1.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon1.Font = new System.Drawing.Font("Segoe UI Emoji", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon1.Location = new System.Drawing.Point(1085, 35);
            this.lblIcon1.Name = "lblIcon1";
            this.lblIcon1.Size = new System.Drawing.Size(212, 145);
            this.lblIcon1.TabIndex = 1;
            this.lblIcon1.Text = "🎓";
            // 
            // pnlStudents
            // 
            this.pnlStudents.BackColor = System.Drawing.Color.White;
            this.pnlStudents.Controls.Add(this.lblStudentsIcon);
            this.pnlStudents.Controls.Add(this.lblStudentsCount);
            this.pnlStudents.Controls.Add(this.lblStudentsTitle);
            this.pnlStudents.Location = new System.Drawing.Point(20, 245);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(470, 130);
            this.pnlStudents.TabIndex = 1;
            // 
            // lblStudentsTitle
            // 
            this.lblStudentsTitle.AutoSize = true;
            this.lblStudentsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentsTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblStudentsTitle.Location = new System.Drawing.Point(192, 79);
            this.lblStudentsTitle.Name = "lblStudentsTitle";
            this.lblStudentsTitle.Size = new System.Drawing.Size(101, 38);
            this.lblStudentsTitle.TabIndex = 0;
            this.lblStudentsTitle.Text = "Tələbə";
            // 
            // lblStudentsCount
            // 
            this.lblStudentsCount.AutoSize = true;
            this.lblStudentsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentsCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentsCount.Location = new System.Drawing.Point(207, 19);
            this.lblStudentsCount.Name = "lblStudentsCount";
            this.lblStudentsCount.Size = new System.Drawing.Size(50, 60);
            this.lblStudentsCount.TabIndex = 1;
            this.lblStudentsCount.Text = "0";
            // 
            // lblStudentsIcon
            // 
            this.lblStudentsIcon.BackColor = System.Drawing.Color.Lavender;
            this.lblStudentsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentsIcon.Location = new System.Drawing.Point(51, 30);
            this.lblStudentsIcon.Name = "lblStudentsIcon";
            this.lblStudentsIcon.Size = new System.Drawing.Size(65, 65);
            this.lblStudentsIcon.TabIndex = 2;
            this.lblStudentsIcon.Text = "👥";
            this.lblStudentsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCourses
            // 
            this.pnlCourses.BackColor = System.Drawing.Color.White;
            this.pnlCourses.Controls.Add(this.lblIcon2);
            this.pnlCourses.Controls.Add(this.lblCoursesCount);
            this.pnlCourses.Controls.Add(this.lblCoursesTitle);
            this.pnlCourses.Location = new System.Drawing.Point(510, 245);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(470, 130);
            this.pnlCourses.TabIndex = 2;
            // 
            // lblIcon2
            // 
            this.lblIcon2.BackColor = System.Drawing.Color.Lavender;
            this.lblIcon2.Font = new System.Drawing.Font("Segoe UI Emoji", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon2.Location = new System.Drawing.Point(44, 40);
            this.lblIcon2.Name = "lblIcon2";
            this.lblIcon2.Size = new System.Drawing.Size(65, 65);
            this.lblIcon2.TabIndex = 2;
            this.lblIcon2.Text = "📚";
            this.lblIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoursesCount
            // 
            this.lblCoursesCount.AutoSize = true;
            this.lblCoursesCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCoursesCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoursesCount.Location = new System.Drawing.Point(207, 19);
            this.lblCoursesCount.Name = "lblCoursesCount";
            this.lblCoursesCount.Size = new System.Drawing.Size(50, 60);
            this.lblCoursesCount.TabIndex = 1;
            this.lblCoursesCount.Text = "0";
            // 
            // lblCoursesTitle
            // 
            this.lblCoursesTitle.AutoSize = true;
            this.lblCoursesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCoursesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoursesTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCoursesTitle.Location = new System.Drawing.Point(191, 79);
            this.lblCoursesTitle.Name = "lblCoursesTitle";
            this.lblCoursesTitle.Size = new System.Drawing.Size(173, 38);
            this.lblCoursesTitle.TabIndex = 0;
            this.lblCoursesTitle.Text = "Fənlərin sayı";
            // 
            // pnlGrades
            // 
            this.pnlGrades.BackColor = System.Drawing.Color.White;
            this.pnlGrades.Controls.Add(this.lblIcon3);
            this.pnlGrades.Controls.Add(this.lblGradesCount);
            this.pnlGrades.Controls.Add(this.lblGradesTitle);
            this.pnlGrades.Location = new System.Drawing.Point(1000, 245);
            this.pnlGrades.Name = "pnlGrades";
            this.pnlGrades.Size = new System.Drawing.Size(470, 130);
            this.pnlGrades.TabIndex = 3;
            // 
            // lblIcon3
            // 
            this.lblIcon3.BackColor = System.Drawing.Color.Lavender;
            this.lblIcon3.Font = new System.Drawing.Font("Segoe UI Emoji", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon3.Location = new System.Drawing.Point(44, 40);
            this.lblIcon3.Name = "lblIcon3";
            this.lblIcon3.Size = new System.Drawing.Size(65, 65);
            this.lblIcon3.TabIndex = 2;
            this.lblIcon3.Text = "⭐";
            this.lblIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGradesCount
            // 
            this.lblGradesCount.AutoSize = true;
            this.lblGradesCount.BackColor = System.Drawing.Color.Transparent;
            this.lblGradesCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGradesCount.Location = new System.Drawing.Point(207, 19);
            this.lblGradesCount.Name = "lblGradesCount";
            this.lblGradesCount.Size = new System.Drawing.Size(50, 60);
            this.lblGradesCount.TabIndex = 1;
            this.lblGradesCount.Text = "0";
            // 
            // lblGradesTitle
            // 
            this.lblGradesTitle.AutoSize = true;
            this.lblGradesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGradesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGradesTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblGradesTitle.Location = new System.Drawing.Point(135, 79);
            this.lblGradesTitle.Name = "lblGradesTitle";
            this.lblGradesTitle.Size = new System.Drawing.Size(317, 38);
            this.lblGradesTitle.TabIndex = 0;
            this.lblGradesTitle.Text = "Ümumi qiymətlərin sayı";
            // 
            // pnlGradeManagement
            // 
            this.pnlGradeManagement.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlGradeManagement.Controls.Add(this.pnlAverageCard);
            this.pnlGradeManagement.Controls.Add(this.dgvGrades);
            this.pnlGradeManagement.Controls.Add(this.btnDeleteGrade);
            this.pnlGradeManagement.Controls.Add(this.btnUpdateGrade);
            this.pnlGradeManagement.Controls.Add(this.btnAddGrade);
            this.pnlGradeManagement.Controls.Add(this.txtScore);
            this.pnlGradeManagement.Controls.Add(this.lblScore);
            this.pnlGradeManagement.Controls.Add(this.lblCourse);
            this.pnlGradeManagement.Controls.Add(this.cmbCourses);
            this.pnlGradeManagement.Controls.Add(this.cmbStudents);
            this.pnlGradeManagement.Controls.Add(this.lblStudent);
            this.pnlGradeManagement.Controls.Add(this.lblGradeManagement);
            this.pnlGradeManagement.Location = new System.Drawing.Point(20, 430);
            this.pnlGradeManagement.Name = "pnlGradeManagement";
            this.pnlGradeManagement.Size = new System.Drawing.Size(1500, 485);
            this.pnlGradeManagement.TabIndex = 4;
            // 
            // lblGradeManagement
            // 
            this.lblGradeManagement.AutoSize = true;
            this.lblGradeManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblGradeManagement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGradeManagement.Location = new System.Drawing.Point(3, 3);
            this.lblGradeManagement.Name = "lblGradeManagement";
            this.lblGradeManagement.Size = new System.Drawing.Size(401, 41);
            this.lblGradeManagement.TabIndex = 0;
            this.lblGradeManagement.Text = "Qiymətlərin idarə olunması\r\n";
            this.lblGradeManagement.Click += new System.EventHandler(this.lblGradeManagement_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudent.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblStudent.Location = new System.Drawing.Point(9, 62);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(112, 23);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Tələbə seçin:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(10, 88);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(274, 33);
            this.cmbStudents.TabIndex = 2;
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(337, 88);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(300, 33);
            this.cmbCourses.TabIndex = 3;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCourse.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCourse.Location = new System.Drawing.Point(339, 62);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(97, 23);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Fənn seçin:";
            this.lblCourse.Click += new System.EventHandler(this.lblCourse_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblScore.Location = new System.Drawing.Point(691, 62);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(158, 23);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Qiymət daxil edin:";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(688, 90);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(180, 31);
            this.txtScore.TabIndex = 6;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddGrade.ForeColor = System.Drawing.Color.White;
            this.btnAddGrade.Location = new System.Drawing.Point(899, 82);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(190, 45);
            this.btnAddGrade.TabIndex = 7;
            this.btnAddGrade.Text = "+Əlavə et";
            this.btnAddGrade.UseVisualStyleBackColor = false;
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdateGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGrade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateGrade.ForeColor = System.Drawing.Color.White;
            this.btnUpdateGrade.Location = new System.Drawing.Point(1102, 82);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(190, 45);
            this.btnUpdateGrade.TabIndex = 8;
            this.btnUpdateGrade.Text = " 🔄 Yenilə";
            this.btnUpdateGrade.UseVisualStyleBackColor = false;
            this.btnUpdateGrade.Click += new System.EventHandler(this.btnUpdateGrade_Click);
            // 
            // btnDeleteGrade
            // 
            this.btnDeleteGrade.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGrade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteGrade.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGrade.Location = new System.Drawing.Point(1298, 82);
            this.btnDeleteGrade.Name = "btnDeleteGrade";
            this.btnDeleteGrade.Size = new System.Drawing.Size(190, 45);
            this.btnDeleteGrade.TabIndex = 9;
            this.btnDeleteGrade.Text = "🗑️ Sil";
            this.btnDeleteGrade.UseVisualStyleBackColor = false;
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(13, 147);
            this.dgvGrades.MultiSelect = false;
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.RowTemplate.Height = 24;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(1105, 315);
            this.dgvGrades.TabIndex = 10;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblAverageTitle
            // 
            this.lblAverageTitle.AutoSize = true;
            this.lblAverageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAverageTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverageTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAverageTitle.Location = new System.Drawing.Point(12, 22);
            this.lblAverageTitle.Name = "lblAverageTitle";
            this.lblAverageTitle.Size = new System.Drawing.Size(272, 38);
            this.lblAverageTitle.TabIndex = 11;
            this.lblAverageTitle.Text = "Tələbənin orta balı:";
            // 
            // pnlAverageCard
            // 
            this.pnlAverageCard.BackColor = System.Drawing.Color.Lavender;
            this.pnlAverageCard.Controls.Add(this.pnlAverageValue);
            this.pnlAverageCard.Controls.Add(this.lblAverageTitle);
            this.pnlAverageCard.Location = new System.Drawing.Point(1149, 165);
            this.pnlAverageCard.Name = "pnlAverageCard";
            this.pnlAverageCard.Size = new System.Drawing.Size(301, 218);
            this.pnlAverageCard.TabIndex = 12;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BackColor = System.Drawing.Color.Transparent;
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverage.ForeColor = System.Drawing.Color.Lavender;
            this.lblAverage.Location = new System.Drawing.Point(58, 30);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(77, 41);
            this.lblAverage.TabIndex = 12;
            this.lblAverage.Text = "0.00";
            this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            // 
            // pnlAverageValue
            // 
            this.pnlAverageValue.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlAverageValue.Controls.Add(this.lblAverage);
            this.pnlAverageValue.Location = new System.Drawing.Point(48, 85);
            this.pnlAverageValue.Name = "pnlAverageValue";
            this.pnlAverageValue.Size = new System.Drawing.Size(200, 100);
            this.pnlAverageValue.TabIndex = 12;
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrades.FlatAppearance.BorderSize = 0;
            this.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrades.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGrades.ForeColor = System.Drawing.Color.White;
            this.btnGrades.Location = new System.Drawing.Point(20, 397);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(99, 33);
            this.btnGrades.TabIndex = 5;
            this.btnGrades.Text = "Qiymətlər";
            this.btnGrades.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(125, 397);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(100, 33);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "Tələbələr";
            this.btnStudents.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(231, 397);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(91, 33);
            this.btnCourses.TabIndex = 7;
            this.btnCourses.Text = "Fənlər";
            this.btnCourses.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1578, 753);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.pnlGradeManagement);
            this.Controls.Add(this.pnlGrades);
            this.Controls.Add(this.pnlCourses);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlWelcome);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universitet İdarəetmə Sistemi";
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.pnlCourses.ResumeLayout(false);
            this.pnlCourses.PerformLayout();
            this.pnlGrades.ResumeLayout(false);
            this.pnlGrades.PerformLayout();
            this.pnlGradeManagement.ResumeLayout(false);
            this.pnlGradeManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.pnlAverageCard.ResumeLayout(false);
            this.pnlAverageCard.PerformLayout();
            this.pnlAverageValue.ResumeLayout(false);
            this.pnlAverageValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblIcon1;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lblStudentsCount;
        private System.Windows.Forms.Label lblStudentsTitle;
        private System.Windows.Forms.Label lblStudentsIcon;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.Label lblIcon2;
        private System.Windows.Forms.Label lblCoursesCount;
        private System.Windows.Forms.Label lblCoursesTitle;
        private System.Windows.Forms.Panel pnlGrades;
        private System.Windows.Forms.Label lblIcon3;
        private System.Windows.Forms.Label lblGradesCount;
        private System.Windows.Forms.Label lblGradesTitle;
        private System.Windows.Forms.Panel pnlGradeManagement;
        private System.Windows.Forms.Label lblGradeManagement;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnDeleteGrade;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label lblAverageTitle;
        private System.Windows.Forms.Panel pnlAverageCard;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Panel pnlAverageValue;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
    }
}

