using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models.DBContext
{
    public class STUDENTDB
    {
        public void AddStudent(Student S)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP.NET\\BD\\MVC-Demo\\App_Data\\StudentDB.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Student values(@studentname,@studentcity)", con);

            cmd.Parameters.AddWithValue("@studentid", S.studentname);
            cmd.Parameters.AddWithValue("@studentcity", S.studentcity);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}