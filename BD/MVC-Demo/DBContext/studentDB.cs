using System.Data.SqlClient;
using MVC_Demo.Models;

namespace MVC_Demo.Models.DBContext
{
    public class studentDB
    {
        private string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP.NET\\BD\\MVC-Demo\\App_Data\\StudentDB.mdf;Integrated Security=True";

        // CHECK STUDENT BY NAME
        public bool StudentExists(string studentname)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Student WHERE studentname=@studentname", con);

                cmd.Parameters.AddWithValue("@studentname", studentname);
                con.Open();

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // INSERT
        public void AddStudent(Student s1)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Student (studentname, studentcity) VALUES (@studentname, @studentcity)", con);

                cmd.Parameters.AddWithValue("@studentname", s1.studentname);
                cmd.Parameters.AddWithValue("@studentcity", s1.studentcity);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // UPDATE BY NAME (NO ID)
        public void UpdateStudentByName(Student s1)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Student SET studentcity=@studentcity WHERE studentname=@studentname", con);

                cmd.Parameters.AddWithValue("@studentname", s1.studentname);
                cmd.Parameters.AddWithValue("@studentcity", s1.studentcity);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
