using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class Student
    {
        [Key]

        [Required(ErrorMessage = "ID Lakho Pela")]
        public int studentid { get; set; }

        [Required(ErrorMessage = "Name Lakho Pela")]
        public string studentname { get; set; }
        public string studentcity { get; set; }
    }
}