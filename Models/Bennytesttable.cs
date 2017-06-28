using System.ComponentModel.DataAnnotations;

namespace ASPCoreSample.Models
{
    public class Bennytesttable : BaseEntity
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
