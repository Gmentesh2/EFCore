using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
    }
}
