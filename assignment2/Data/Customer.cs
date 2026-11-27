namespace assignment2.Data
{
    public class Customer

    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? Email { get; set; }
        public ICollection<MortgageCase> MortgageCases { get; set; } = new List<MortgageCase>();
    }

}
