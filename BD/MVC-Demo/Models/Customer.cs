using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class Customer
    {
        [Key]
        public int cutomerid { get; set; }

        [Required(ErrorMessage = "Name Lakho Pela")]
        public string customer_name { get; set; }

        [Required(ErrorMessage = "Pela customer nu payment nakho")]
        public string customer_payment { get; set; }
    }
}