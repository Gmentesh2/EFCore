
using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    class CustomerAddress
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Customer Customer { get; set; }
    }
}
