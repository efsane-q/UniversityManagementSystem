namespace UniversityManagementSystem
{
    partial class CoursesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrades = new System.Windows.Forms.Panel();
            this.lblIcon3 = new System.Windows.Forms.Label();
            this.lblGradesCount = new System.Windows.Forms.Label();
            this.lblGradesTitle = new System.Windows.Forms.Label();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.lblIcon2 = new System.Windows.Forms.Label();
            this.lblCoursesCount = new System.Windows.Forms.Label();
            this.lblCoursesTitle = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.lblStudentsIcon = new System.Windows.Forms.Label();
            this.lblStudentsCount = new System.Windows.Forms.Label();
            this.lblStudentsTitle = new System.Windows.Forms.Label();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblIcon1 = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlCourseManagement = new System.Windows.Forms.Panel();
            this.lblCourseManagement = new System.Windows.Forms.Label();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.pnlGrades.SuspendLayout();
            this.pnlCourses.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.pnlCourseManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrades
            // 
            this.pnlGrades.BackColor = System.Drawing.Color.White;
            this.pnlGrades.Controls.Add(this.lblIcon3);
            this.pnlGrades.Controls.Add(this.lblGradesCount);
            this.pnlGrades.Controls.Add(this.lblGradesTitle);
            this.pnlGrades.Location = new System.Drawing.Point(992, 245);
            this.pnlGrades.Name = "pnlGrades";
            this.pnlGrades.Size = new System.Drawing.Size(470, 130);
            this.pnlGrades.TabIndex = 7;
            // 
            // lblIcon3
            // 
            this.lblIcon3.BackColor = System.Drawing.Color.Lavender;
            this.lblIcon3.Font = new System.Drawing.Font("Segoe UI Emoji", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIcon3.Location = new System.Drawing.Point(45, 40);
            this.lblIcon3.Name = "lblIcon3";
            this.lblIcon3.Size = new System.Drawing.Size(65, 65);
            this.lblIcon3.TabIndex = 2;
            this.lblIcon3.Text = "⭐";
            this.lblIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIcon3.Click += new System.EventHandler(this.lblIcon3_Click);
            // 
            // lblGradesCount
            // 
            this.lblGradesCount.AutoSize = true;
            this.lblGradesCount.BackColor = System.Drawing.Color.Transparent;
            this.lblGradesCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGradesCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGradesCount.Location = new System.Drawing.Point(279, 19);
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
            // pnlCourses
            // 
            this.pnlCourses.BackColor = System.Drawing.Color.White;
            this.pnlCourses.Controls.Add(this.lblIcon2);
            this.pnlCourses.Controls.Add(this.lblCoursesCount);
            this.pnlCourses.Controls.Add(this.lblCoursesTitle);
            this.pnlCourses.Location = new System.Drawing.Point(506, 245);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(470, 130);
            this.pnlCourses.TabIndex = 6;
            this.pnlCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCourses_Paint);
            // 
            // lblIcon2
            // 
            this.lblIcon2.BackColor = System.Drawing.Color.Lavender;
            this.lblIcon2.Font = new System.Drawing.Font("Segoe UI Emoji", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon2.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.lblCoursesCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCoursesCount.Location = new System.Drawing.Point(244, 19);
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
            // pnlStudents
            // 
            this.pnlStudents.BackColor = System.Drawing.Color.White;
            this.pnlStudents.Controls.Add(this.lblStudentsIcon);
            this.pnlStudents.Controls.Add(this.lblStudentsCount);
            this.pnlStudents.Controls.Add(this.lblStudentsTitle);
            this.pnlStudents.Location = new System.Drawing.Point(20, 245);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(470, 130);
            this.pnlStudents.TabIndex = 5;
            // 
            // lblStudentsIcon
            // 
            this.lblStudentsIcon.BackColor = System.Drawing.Color.Lavender;
            this.lblStudentsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentsIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStudentsIcon.Location = new System.Drawing.Point(37, 40);
            this.lblStudentsIcon.Name = "lblStudentsIcon";
            this.lblStudentsIcon.Size = new System.Drawing.Size(65, 65);
            this.lblStudentsIcon.TabIndex = 2;
            this.lblStudentsIcon.Text = "👥";
            this.lblStudentsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentsCount
            // 
            this.lblStudentsCount.AutoSize = true;
            this.lblStudentsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentsCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentsCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStudentsCount.Location = new System.Drawing.Point(214, 19);
            this.lblStudentsCount.Name = "lblStudentsCount";
            this.lblStudentsCount.Size = new System.Drawing.Size(50, 60);
            this.lblStudentsCount.TabIndex = 1;
            this.lblStudentsCount.Text = "0";
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
            this.pnlWelcome.Size = new System.Drawing.Size(1491, 200);
            this.pnlWelcome.TabIndex = 4;
            // 
            // lblIcon1
            // 
            this.lblIcon1.AutoSize = true;
            this.lblIcon1.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon1.Font = new System.Drawing.Font("Segoe UI Emoji", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIcon1.Location = new System.Drawing.Point(1085, 35);
            this.lblIcon1.Name = "lblIcon1";
            this.lblIcon1.Size = new System.Drawing.Size(212, 145);
            this.lblIcon1.TabIndex = 1;
            this.lblIcon1.Text = "🎓";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(723, 105);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(0, 23);
            this.lblIcon.TabIndex = 3;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(117, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(640, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Universitet İdarəetmə Sistemi";
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
            // pnlCourseManagement
            // 
            this.pnlCourseManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCourseManagement.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlCourseManagement.Controls.Add(this.panel1);
            this.pnlCourseManagement.Controls.Add(this.dgvCourses);
            this.pnlCourseManagement.Controls.Add(this.btnDeleteCourse);
            this.pnlCourseManagement.Controls.Add(this.btnUpdateCourse);
            this.pnlCourseManagement.Controls.Add(this.btnAddCourse);
            this.pnlCourseManagement.Controls.Add(this.txtCredits);
            this.pnlCourseManagement.Controls.Add(this.lblCredits);
            this.pnlCourseManagement.Controls.Add(this.txtCourseTitle);
            this.pnlCourseManagement.Controls.Add(this.lblCourseTitle);
            this.pnlCourseManagement.Controls.Add(this.lblCourseManagement);
            this.pnlCourseManagement.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlCourseManagement.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlCourseManagement.Location = new System.Drawing.Point(20, 430);
            this.pnlCourseManagement.Name = "pnlCourseManagement";
            this.pnlCourseManagement.Size = new System.Drawing.Size(1491, 485);
            this.pnlCourseManagement.TabIndex = 8;
            // 
            // lblCourseManagement
            // 
            this.lblCourseManagement.AutoSize = true;
            this.lblCourseManagement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCourseManagement.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCourseManagement.Location = new System.Drawing.Point(3, 3);
            this.lblCourseManagement.Name = "lblCourseManagement";
            this.lblCourseManagement.Size = new System.Drawing.Size(356, 41);
            this.lblCourseManagement.TabIndex = 0;
            this.lblCourseManagement.Text = "Fənlərin idarə olunması:";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.BackColor = System.Drawing.Color.GhostWhite;
            this.lblCourseTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCourseTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCourseTitle.Location = new System.Drawing.Point(9, 62);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(93, 23);
            this.lblCourseTitle.TabIndex = 1;
            this.lblCourseTitle.Text = "Fənnin adı";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(10, 88);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(274, 31);
            this.txtCourseTitle.TabIndex = 2;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(365, 88);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(274, 31);
            this.txtCredits.TabIndex = 4;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.GhostWhite;
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCredits.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCredits.Location = new System.Drawing.Point(365, 62);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(151, 23);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "Kredit sayı (1–10)";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Location = new System.Drawing.Point(1193, 74);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(190, 45);
            this.btnDeleteCourse.TabIndex = 12;
            this.btnDeleteCourse.Text = "🗑️ Sil";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdateCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateCourse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCourse.Location = new System.Drawing.Point(992, 74);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(190, 45);
            this.btnUpdateCourse.TabIndex = 11;
            this.btnUpdateCourse.Text = " 🔄 Yenilə";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(784, 74);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(190, 45);
            this.btnAddCourse.TabIndex = 10;
            this.btnAddCourse.Text = "+Əlavə et";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCourses.Location = new System.Drawing.Point(10, 158);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 40;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(1190, 305);
            this.dgvCourses.TabIndex = 13;
            this.dgvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1261, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 274);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 177);
            this.label1.TabIndex = 0;
            this.label1.Text = "⛄";
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(20, 397);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(91, 33);
            this.btnCourses.TabIndex = 11;
            this.btnCourses.Text = "Fənlər";
            this.btnCourses.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(225, 397);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(94, 33);
            this.btnStudents.TabIndex = 10;
            this.btnStudents.Text = "Tələbələr";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click_1);
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrades.FlatAppearance.BorderSize = 0;
            this.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrades.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGrades.ForeColor = System.Drawing.Color.White;
            this.btnGrades.Location = new System.Drawing.Point(117, 397);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(102, 33);
            this.btnGrades.TabIndex = 9;
            this.btnGrades.Text = "Qiymətlər";
            this.btnGrades.UseVisualStyleBackColor = false;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1551, 753);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.pnlCourseManagement);
            this.Controls.Add(this.pnlGrades);
            this.Controls.Add(this.pnlCourses);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlWelcome);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fənlərin idarə olunması";
            this.Load += new System.EventHandler(this.CoursesForm_Load_1);
            this.pnlGrades.ResumeLayout(false);
            this.pnlGrades.PerformLayout();
            this.pnlCourses.ResumeLayout(false);
            this.pnlCourses.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlCourseManagement.ResumeLayout(false);
            this.pnlCourseManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrades;
        private System.Windows.Forms.Label lblIcon3;
        private System.Windows.Forms.Label lblGradesCount;
        private System.Windows.Forms.Label lblGradesTitle;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.Label lblIcon2;
        private System.Windows.Forms.Label lblCoursesCount;
        private System.Windows.Forms.Label lblCoursesTitle;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lblStudentsIcon;
        private System.Windows.Forms.Label lblStudentsCount;
        private System.Windows.Forms.Label lblStudentsTitle;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblIcon1;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCourseManagement;
        private System.Windows.Forms.Label lblCourseManagement;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnGrades;
    }
}