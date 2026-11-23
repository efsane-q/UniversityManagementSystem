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
    public partial class StudentsForm : Form
    {
        private StudentRepository studentRepository = new StudentRepository();
        private int selectedStudentId = 0;
        public StudentsForm()
        {
            InitializeComponent();
            btnGrades.Click += btnGrades_Click;
            btnStudents.Click += btnStudents_Click;
            btnCourses.Click += btnCourses_Click;

            this.Load += StudentsForm_Load;

            btnAddStudent.Click += btnAddStudent_Click;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            btnDeleteStudent.Click += btnDeleteStudent_Click;

            dgvStudents.CellClick += dgvStudents_CellClick;
        }
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Yeniləmək üçün cədvəldən tələbə seçin!");
                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();

            int age;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Bütün xanaları doldurun!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) || age < 16 || age > 100)
            {
                MessageBox.Show("Yaş düzgün daxil edilməyib!");
                return;
            }

            try
            {
                studentRepository.Update(
                    selectedStudentId,
                    firstName,
                    lastName,
                    age,
                    email
                );

                MessageBox.Show("Tələbə məlumatları yeniləndi!");

                TelebeleriGetir();
                TelebelerinSayiniGetir();

                selectedStudentId = 0;

                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
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
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Silmək üçün cədvəldən tələbə seçin!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bu tələbəni silmək istədiyinizə əminsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    studentRepository.Delete(selectedStudentId);

                    MessageBox.Show("Tələbə uğurla silindi!");

                    TelebeleriGetir();
                    TelebelerinSayiniGetir();

                    selectedStudentId = 0;

                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAge.Clear();
                    txtEmail.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Tələbəni silmək mümkün olmadı. Bu tələbənin qiymətləri mövcud ola bilər.\n\n" + ex.Message
                    );
                }
            }
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);

            txtFirstName.Text = row.Cells["FullName"].Value.ToString();
            txtLastName.Text = row.Cells["surname"].Value.ToString();
            txtAge.Text = row.Cells["Age"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
        }

        private void TelebeleriGetir()
        {
            dgvStudents.DataSource = studentRepository.GetAll();

            dgvStudents.Columns["StudentID"].HeaderText = "ID";
            dgvStudents.Columns["FullName"].HeaderText = "Ad";
            dgvStudents.Columns["surname"].HeaderText = "Soyad";
            dgvStudents.Columns["Age"].HeaderText = "Yaş";
            dgvStudents.Columns["email"].HeaderText = "E-poçt";
        }

        private void TelebelerinSayiniGetir()
        {
            lblStudentsCount.Text = studentRepository.Count().ToString();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            YumruPanel(pnlStudents, 20);
            YumruPanel(pnlCourses, 20);
            YumruPanel(pnlGrades, 20);
            YumruPanel(pnlStudentManagement, 20);

            YumruButton(btnAddStudent, 20);
            YumruButton(btnUpdateStudent, 20);
            YumruButton(btnDeleteStudent, 20);

            TelebeleriGetir();
            TelebelerinSayiniGetir();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();

            int age;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Bütün xanaları doldurun!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) || age < 16 || age > 100)
            {
                MessageBox.Show("Yaş düzgün daxil edilməyib!");
                return;
            }

            try
            {
                MessageBox.Show("1. Tələbə əlavə etməyə başlayırıq.");

                studentRepository.Add(firstName, lastName, age, email);

                MessageBox.Show("2. Tələbə bazaya əlavə edildi.");

                TelebeleriGetir();

                MessageBox.Show("3. Cədvəl yeniləndi.");

                TelebelerinSayiniGetir();

                MessageBox.Show("4. Tələbə sayı yeniləndi.");

                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }
        private void btnGrades_Click(object sender, EventArgs e)
        {
            FormNavigation.Open(this, new MainForm());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            FormNavigation.Open(this, new CoursesForm());
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {

        }
    }
}
