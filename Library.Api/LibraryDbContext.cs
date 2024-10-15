using Library.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

namespace Library.Api
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) {}

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Address
            modelBuilder.Entity<Address>()
                .Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Address>()
                .Property(a => a.City)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Address>()
                .Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Address>()
                .Property(a => a.HouseNumber)
                .IsRequired()
                .HasMaxLength(5);

            modelBuilder.Entity<Address>()
                .Property(a => a.ApartmentNumber)
                .HasMaxLength(5);

            modelBuilder.Entity<Address>()
                .Property(a => a.PostalCode)
                .IsRequired()
                .HasMaxLength(10);
            
            modelBuilder.Entity<Address>()
                .Property(a => a.ContactNumber)
                .HasMaxLength(10);
            #endregion

            #region Author
            modelBuilder.Entity<Author>()
                .Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Author>()
                .Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(30);
            #endregion

            #region Book
            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Book>()
                .Property(b => b.Subtitle)
                .HasMaxLength(100);

            modelBuilder.Entity<Book>()
                .Property(b => b.Description)
                .HasMaxLength(1000);

            modelBuilder.Entity<Book>()
                .Property(b => b.CopyNumber)
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<Book>()
                .Property(b => b.PublishingHouseId)
                .IsRequired();
            #endregion

            #region Borrow
            modelBuilder.Entity<Borrow>()
                .Property(b => b.StartDate)
                .IsRequired();

            modelBuilder.Entity<Borrow>()
                .Property(b => b.BookId)
                .IsRequired();

            modelBuilder.Entity<Borrow>()
                .Property(b => b.CustomerId)
                .IsRequired();
            #endregion

            #region Customer
            modelBuilder.Entity<Customer>()
                .Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Customer>()
                .Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Customer>()
                .Property(c => c.AddressId)
                .IsRequired();
            #endregion

            #region PublishingHouse
            modelBuilder.Entity<PublishingHouse>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            #endregion
        }
    }
}