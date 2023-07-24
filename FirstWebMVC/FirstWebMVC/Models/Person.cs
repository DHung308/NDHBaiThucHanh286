using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string DiaChi { get; set; }
        public DateTime SinhNhat { get; set; }    
    }
}
