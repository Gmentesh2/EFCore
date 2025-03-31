
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    class CustomerAddress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)] 
        public int Id { get; set; }
        [Column(Order = 2)]
        public int CustomerID { get; set; }
        [Required]
        [Column(Order = 3)]
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [Column(Order = 4)]
        public string City { get; set; }
        [Required]
        [Column(Order = 5)]
        [MaxLength(50)]
        public string State { get; set; }
        public Customer Customer { get; set; }
    }
}
