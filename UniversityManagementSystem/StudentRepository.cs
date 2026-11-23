
using System;
using System.Data;
using System.Data.SqlClient;

namespace UniversityManagementSystem
{
    public class StudentRepository
    {
        public DataTable GetAll()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
                    SELECT StudentID, FullName, surname, Age, email
                    FROM Students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void Add(string firstName, string lastName, int age, string email)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
            INSERT INTO Students (StudentID, FullName, surname, Age, email)
            SELECT
                ISNULL(MAX(StudentID), 0) + 1,
                @FullName,
                @surname,
                @Age,
                @email
            FROM Students";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", firstName);
                cmd.Parameters.AddWithValue("@surname", lastName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@email", email);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int studentId, string firstName, string lastName, int age, string email)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
                    UPDATE Students
                    SET FullName = @FullName,
                        surname = @surname,
                        Age = @Age,
                        email = @email
                    WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@FullName", firstName);
                cmd.Parameters.AddWithValue("@surname", lastName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@email", email);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int studentId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int Count()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Students";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
