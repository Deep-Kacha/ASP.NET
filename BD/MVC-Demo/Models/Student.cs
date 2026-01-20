using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class Student
    {
        [Key]
        public int studentid { get; set; }

        [Required(ErrorMessage = "Name Lakho Pela")]
        public string studentname { get; set; }

        [Required(ErrorMessage = "City Lakho Pela")]
        public string studentcity { get; set; }
    }
}
