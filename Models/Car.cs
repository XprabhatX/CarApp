using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarApp
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id {get; set;}
        public string Brand {get; set;}
        public string Model {get; set;}
        public double Price {get; set;}
    }
}