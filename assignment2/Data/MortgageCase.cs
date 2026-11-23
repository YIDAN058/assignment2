using System.ComponentModel.DataAnnotations.Schema;
namespace assignment2.Data
{
    public class MortgageCase
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
