namespace Library.Api.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public bool IsBorrowed { get; set; } = false;
        public bool IsWithdrawn { get; set; } = false;
        public string CopyNumber { get; set; }


        public int PublishingHouseId { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public List<Borrow> Borrows { get; set; } = new List<Borrow>();
    }
}
