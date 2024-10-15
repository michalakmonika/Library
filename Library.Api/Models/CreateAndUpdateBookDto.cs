using Library.Api.Entities;

namespace Library.Api.Models
{
    public class CreateAndUpdateBookDto
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public bool IsBorrowed { get; set; }
        public bool IsWithdrawn { get; set; }
        public string CopyNumber { get; set; }
        public int PublishingHouseId { get; set; }
        public List<Author> Authors { get; set; }
    }
}
