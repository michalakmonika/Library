using Library.Api.Entities;

namespace Library.Api.Models
{
    public class BorrowDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
    }
}
