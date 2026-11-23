
using System.Data;
using System.Data.SqlClient;

namespace UniversityManagementSystem
{
    public class CourseRepository
    {
        public DataTable GetAll()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT CourseID, CourseName, Credits FROM Courses";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void Add(string courseName, int credits)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
            INSERT INTO Courses (CourseID, CourseName, Credits)
            SELECT
                ISNULL(MAX(CourseID), 0) + 1,
                @CourseName,
                @Credits
            FROM Courses";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CourseName", courseName);
                cmd.Parameters.AddWithValue("@Credits", credits);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int courseId, string courseName, int credits)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"UPDATE Courses
                                 SET CourseName = @CourseName,
                                     Credits = @Credits
                                 WHERE CourseID = @CourseID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.Parameters.AddWithValue("@CourseName", courseName);
                cmd.Parameters.AddWithValue("@Credits", credits);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int courseId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "DELETE FROM Courses WHERE CourseID = @CourseID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CourseID", courseId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int Count()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Courses";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
