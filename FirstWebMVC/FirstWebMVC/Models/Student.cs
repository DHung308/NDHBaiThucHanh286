using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }
    }
}
