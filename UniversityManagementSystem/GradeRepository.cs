using System;
using System.Data;
using System.Data.SqlClient;

namespace UniversityManagementSystem
{
    public class GradeRepository
    {
        public DataTable GetAll()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
                    SELECT
                        g.GradeID,
                        s.FullName + ' ' + s.surname AS StudentName,
                        c.CourseName,
                        g.Score,
                        g.StudentID,
                        g.CourseID
                    FROM Grades g
                    INNER JOIN Students s ON g.StudentID = s.StudentID
                    INNER JOIN Courses c ON g.CourseID = c.CourseID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void Add(int studentId, int courseId, int score)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
                    INSERT INTO Grades (StudentID, CourseID, Score)
                    VALUES (@StudentID, @CourseID, @Score)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.Parameters.AddWithValue("@Score", score);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int gradeId, int studentId, int courseId, int score)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
                    UPDATE Grades
                    SET StudentID = @StudentID,
                        CourseID = @CourseID,
                        Score = @Score
                    WHERE GradeID = @GradeID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@GradeID", gradeId);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.Parameters.AddWithValue("@Score", score);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int gradeId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "DELETE FROM Grades WHERE GradeID = @GradeID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@GradeID", gradeId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public decimal Average()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT AVG(CAST(Score AS DECIMAL(10,2))) FROM Grades";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                object result = cmd.ExecuteScalar();

                return result == DBNull.Value ? 0 : (decimal)result;
            }
        }

        public int Count()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Grades";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                return (int)cmd.ExecuteScalar();
            }
        }
    }
}