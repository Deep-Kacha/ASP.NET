using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Demo.DBContext
{
    public class customerDB
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP.NET\\BD\\MVC-Demo\\App_Data\\CustomerDB.mdf;Integrated Security=True";
    
        public void AddCustomer(Customer C1)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Customer (cutomer_name, customer_payment) VALUES (@cutomer_name, @customer_payment)", con);

                cmd.Parameters.AddWithValue("@cutomer_name", C1.customer_name);
                cmd.Parameters.AddWithValue("@customer_payment", C1.customer_payment);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}