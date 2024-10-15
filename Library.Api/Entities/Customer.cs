namespace Library.Api.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<Borrow> Borrows { get; set; } = new List<Borrow>();
    }
}
