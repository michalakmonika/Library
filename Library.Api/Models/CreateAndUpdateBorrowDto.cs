using Library.Api.Entities;

namespace Library.Api.Models
{
    public class CreateAndUpdateBorrowDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
    }
}
