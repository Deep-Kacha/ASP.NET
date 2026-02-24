//add this for using the Entity Framework Core
using Microsoft.EntityFrameworkCore;
using SchoolManagemengtSystem.Models;
namespace SchoolManagemengtSystem.DBFolder
{
    public class StudentDB : DbContext
    {
        public StudentDB(DbContextOptions options) : base(options)
        {
        }
        //Creating a table in database
        public DbSet<StudentModel> students { get; set; }
    }
}
