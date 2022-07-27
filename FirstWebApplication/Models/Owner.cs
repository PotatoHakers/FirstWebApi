using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApplication.Models
{
    [Table("Owners")]
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Car>? Cars { get; set; }
    }
}