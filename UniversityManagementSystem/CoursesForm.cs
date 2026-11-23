using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();

            btnGrades.Click += btnGrades_Click;
            btnStudents.Click += btnStudents_Click;
            btnCourses.Click += btnCourses_Click;

            this.Load += CoursesForm_Load;

            btnAddCourse.Click += btnAddCourse_Click;
            btnUpdateCourse.Click += btnUpdateCourse_Click;
            btnDeleteCourse.Click += btnDeleteCourse_Click;

            dgvCourses.CellClick += dgvCourses_CellContentClick;
        }
        private CourseRepository courseRepository = new CourseRepository();

        private int selectedCourseId = 0;
        private void CoursesForm_Load(object sender, EventArgs e)
        {
            YumruButton(btnAddCourse, 20);
            YumruButton(btnUpdateCourse, 20);
            YumruButton(btnDeleteCourse, 20);

            FennleriGetir();
            FenlerinSayiniGetir();
        }
        private void btnGrades_Click(object sender, EventArgs e)
        {
            FormNavigation.Open(this, new MainForm());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            FormNavigation.Open(this, new StudentsForm());
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
        }
        private void FennleriGetir()
        {
            dgvCourses.DataSource = courseRepository.GetAll();

            dgvCourses.Columns["CourseID"].HeaderText = "ID";
            dgvCourses.Columns["CourseName"].HeaderText = "Fənnin adı";
            dgvCourses.Columns["Credits"].HeaderText = "Kredit";
        }
        private void FenlerinSayiniGetir()
        {
            lblCoursesCount.Text = courseRepository.Count().ToString();
        }
        private void YumruPanel(Panel panel, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            panel.Region?.Dispose();
            panel.Region = new Region(path);
        }
        private void YumruButton(Button btn, int radius)
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius,
                    radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius,
                    radius, radius, 90, 90);

                path.CloseFigure();
                btn.Region = new Region(path);
            }
        }

        private void pnlCourses_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIcon3_Click(object sender, EventArgs e)
        {

        }

        private void CoursesForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            string courseName = txtCourseTitle.Text.Trim();
            int credits;

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Fənnin adını daxil edin!");
                return;
            }

            if (!int.TryParse(txtCredits.Text, out credits) ||
                credits < 1 || credits > 10)
            {
                MessageBox.Show("Kredit sayı 1-10 arasında olmalıdır!");
                return;
            }

            try
            {
                courseRepository.Add(courseName, credits);

                MessageBox.Show("Fənn uğurla əlavə edildi!");

                FennleriGetir();
                FenlerinSayiniGetir();

                txtCourseTitle.Clear();
                txtCredits.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta: " + ex.Message);
            }
        }
        

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Yeniləmək üçün cədvəldən fənn seçin!");
                return;
            }

            string courseName = txtCourseTitle.Text.Trim();
            int credits;

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Fənnin adını daxil edin!");
                return;
            }

            if (!int.TryParse(txtCredits.Text, out credits) ||
                credits < 1 || credits > 10)
            {
                MessageBox.Show("Kredit sayı 1-10 arasında olmalıdır!");
                return;
            }

            try
            {
                courseRepository.Update(selectedCourseId, courseName, credits);

                MessageBox.Show("Fənn uğurla yeniləndi!");

                FennleriGetir();
                FenlerinSayiniGetir();

                selectedCourseId = 0;
                txtCourseTitle.Clear();
                txtCredits.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta: " + ex.Message);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Silmək üçün cədvəldən fənn seçin!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bu fənni silmək istədiyinizə əminsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    courseRepository.Delete(selectedCourseId);

                    MessageBox.Show("Fənn uğurla silindi!");

                    FennleriGetir();
                    FenlerinSayiniGetir();

                    selectedCourseId = 0;
                    txtCourseTitle.Clear();
                    txtCredits.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Bu fənn qiymətlərdə istifadə olunduğu üçün silinə bilməz.\n\n" + ex.Message
                    );
                }
            }
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

            selectedCourseId = Convert.ToInt32(row.Cells["CourseID"].Value);

            txtCourseTitle.Text = row.Cells["CourseName"].Value.ToString();
            txtCredits.Text = row.Cells["Credits"].Value.ToString();
        }

        private void btnStudents_Click_1(object sender, EventArgs e)
        {

        }
    }
}
