using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        public string GiongLoai { get; set; }
        public string XuatXu { get; set; }
        public string TuoiTho { get; set; }
    }
}
