using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Dog")]
    public class Dog : Animal
    {
        public string Name { get; set; }
    }
}
