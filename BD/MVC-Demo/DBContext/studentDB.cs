using System.Data.SqlClient;
using MVC_Demo.Models;

namespace MVC_Demo.Models.DBContext
{
    public class studentDB
    {
        private string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP.NET\\BD\\MVC-Demo\\App_Data\\StudentDB.mdf;Integrated Security=True";

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

        public void DISPLAY(Student s1)
        {
            // CODE
        }
    }
}
