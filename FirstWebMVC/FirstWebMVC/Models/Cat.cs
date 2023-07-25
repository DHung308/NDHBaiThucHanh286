using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Cat")]
    public class Cat : Animal
    {
        public string Name { get; set; }
    }
}
