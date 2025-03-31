using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    public class Customer
    {
        [Key]
        [Column(Order =1)]
        public int CustomerID { get; set; }
        [Required]
        [Column(Order = 2)]
        public string CustomerName { get; set; }
        [Required]
        [Column(Order = 3)] 
        public string PhoneNo { get; set; }
    }
}
