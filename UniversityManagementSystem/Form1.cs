using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnGrades.Click += btnGrades_Click;
            btnStudents.Click += btnStudents_Click;
            btnCourses.Click += btnCourses_Click;
            this.Load += MainForm_Load;
            btnAddGrade.Click += btnAddGrade_Click;
            btnUpdateGrade.Click += btnUpdateGrade_Click;
            btnDeleteGrade.Click += btnDeleteGrade_Click;
            dgvGrades.CellClick += dgvGrades_CellClick;
        }
        private GradeRepository gradeRepository = new GradeRepository();

        private int selectedGradeId = 0;
        private void MainForm_Load(object sender, EventArgs e)
        {
            YumruPanel(pnlStudents, 20);
            YumruPanel(pnlCourses, 20);
            YumruPanel(pnlGrades, 20);
            YumruPanel(pnlGradeManagement, 20);
            YumruButton(btnAddGrade, 20);
            YumruPanel(pnlAverageCard, 20);
            YumruPanel(pnlAverageValue, 15);
            YumruButton(btnUpdateGrade, 20);
            YumruButton(btnDeleteGrade, 20);
            FennleriComboBoxaGetir();
            TelebeleriComboBoxaGetir();
            QiymetleriGetir();
            OrtaBaliGetir();
            QiymetSayiniGetir();
        }
        private void dgvGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvGrades.Rows[e.RowIndex];

            selectedGradeId = Convert.ToInt32(row.Cells["GradeID"].Value);

            cmbStudents.SelectedValue = row.Cells["StudentID"].Value;
            cmbCourses.SelectedValue = row.Cells["CourseID"].Value;

            txtScore.Text = row.Cells["Score"].Value.ToString();
        }
        private void QiymetleriGetir()
        {
            dgvGrades.DataSource = gradeRepository.GetAll();

            dgvGrades.Columns["GradeID"].HeaderText = "ID";
            dgvGrades.Columns["StudentName"].HeaderText = "Tələbə";
            dgvGrades.Columns["CourseName"].HeaderText = "Fənn";
            dgvGrades.Columns["Score"].HeaderText = "Qiymət";

            dgvGrades.Columns["StudentID"].Visible = false;
            dgvGrades.Columns["CourseID"].Visible = false;
        }
        private void OrtaBaliGetir()
        {
            lblAverage.Text = gradeRepository.Average().ToString("0.00");
        }
        private void QiymetSayiniGetir()
        {
            lblGradesCount.Text = gradeRepository.Count().ToString();
        }
        private void TelebeleriComboBoxaGetir()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT StudentID, FullName, surname FROM Students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                table.Columns.Add("StudentDisplay", typeof(string),
                    "FullName + ' ' + surname");

                cmbStudents.DataSource = table;
                cmbStudents.DisplayMember = "StudentDisplay";
                cmbStudents.ValueMember = "StudentID";
                cmbStudents.SelectedIndex = -1;
            }
        }
        private void FennleriComboBoxaGetir()
        {
            CourseRepository repository = new CourseRepository();

            cmbCourses.DataSource = repository.GetAll();
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseID";
            cmbCourses.SelectedIndex = -1;
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
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);

                path.CloseFigure();
                btn.Region = new Region(path);
            }
        }
        private void btnGrades_Click(object sender, EventArgs e)
        {
            pnlGradeManagement.Visible = true;
            pnlGradeManagement.BringToFront();
        }
        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Tələbə seçin!");
                return;
            }

            if (cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Fənn seçin!");
                return;
            }

            int score;

            if (!int.TryParse(txtScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Qiymət 0-100 arasında olmalıdır!");
                return;
            }

            try
            {
                int studentId = Convert.ToInt32(cmbStudents.SelectedValue);
                int courseId = Convert.ToInt32(cmbCourses.SelectedValue);

                gradeRepository.Add(studentId, courseId, score);

                MessageBox.Show("Qiymət uğurla əlavə edildi!");

                QiymetleriGetir();
                OrtaBaliGetir();
                QiymetSayiniGetir();

                cmbStudents.SelectedIndex = -1;
                cmbCourses.SelectedIndex = -1;
                txtScore.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            FormNavigation.Open(this, new StudentsForm());
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            FormNavigation.Open(this, new CoursesForm());
        }

        private void pnlWelcome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGradeManagement_Click(object sender, EventArgs e)
        {

        }

        private void lblCourse_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            if (selectedGradeId == 0)
            {
                MessageBox.Show("Yeniləmək üçün cədvəldən qiymət seçin!");
                return;
            }

            if (cmbStudents.SelectedIndex == -1 || cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Tələbə və fənn seçin!");
                return;
            }

            int score;

            if (!int.TryParse(txtScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Qiymət 0-100 arasında olmalıdır!");
                return;
            }

            try
            {
                int studentId = Convert.ToInt32(cmbStudents.SelectedValue);
                int courseId = Convert.ToInt32(cmbCourses.SelectedValue);

                gradeRepository.Update(selectedGradeId, studentId, courseId, score);

                MessageBox.Show("Qiymət uğurla yeniləndi!");

                QiymetleriGetir();
                OrtaBaliGetir();
                QiymetSayiniGetir();

                selectedGradeId = 0;
                cmbStudents.SelectedIndex = -1;
                cmbCourses.SelectedIndex = -1;
                txtScore.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }
        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            if (selectedGradeId == 0)
            {
                MessageBox.Show("Silmək üçün cədvəldən qiymət seçin!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bu qiyməti silmək istədiyinizə əminsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    gradeRepository.Delete(selectedGradeId);

                    MessageBox.Show("Qiymət uğurla silindi!");

                    QiymetleriGetir();
                    OrtaBaliGetir();
                    QiymetSayiniGetir();

                    selectedGradeId = 0;
                    cmbStudents.SelectedIndex = -1;
                    cmbCourses.SelectedIndex = -1;
                    txtScore.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xəta baş verdi: " + ex.Message);
                }
            }
        }
    }
}
