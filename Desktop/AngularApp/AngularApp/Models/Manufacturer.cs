using System.ComponentModel.DataAnnotations;

namespace AngularApp.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
