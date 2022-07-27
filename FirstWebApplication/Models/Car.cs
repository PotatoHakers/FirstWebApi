using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApplication.Models
{
    [Table("Сars")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public int OwnerId { get; set; }
        public Owner? Owner { get; set; }
    }
}