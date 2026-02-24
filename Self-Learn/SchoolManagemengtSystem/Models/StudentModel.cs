using System.ComponentModel.DataAnnotations;

namespace SchoolManagemengtSystem.Models
{
    public class StudentModel
    {
        [Key]
        public int studentId { get; set; }
        [Required(ErrorMessage = "Bhai Name lakh")]
        public string studentName { get; set; }
        [Required(ErrorMessage = " Bhai Branch To Nakh")]
        public string studentBranch { get; set; }

        [Required(ErrorMessage = "Bhai Email To Nakh")]
        public string studentEmail { get; set; }

        [Required(ErrorMessage = "Bhai Janam tarikh Nakh")]
        public DateOnly studentDob { get; set; }

        [Required(ErrorMessage = "Bhai City Nakhi Have")]
        public string studentCity { get; set; }
    }
}
