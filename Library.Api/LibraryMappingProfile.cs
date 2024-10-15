using AutoMapper;
using Library.Api.Entities;
using Library.Api.Models;

namespace Library.Api
{
    public class LibraryMappingProfile : Profile
    {
        public LibraryMappingProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<CreateAndUpdateAuthorDto, Author>();

            CreateMap<Book, BookDto>();
            CreateMap<CreateAndUpdateBookDto, Book>();

            CreateMap<Borrow, BorrowDto>();
            CreateMap<CreateAndUpdateBorrowDto, Borrow>();

            CreateMap<PublishingHouse, PublishingHouseDto>();
            CreateMap<CreateAndUpdatePublishingHouseDto, PublishingHouse>();

            CreateMap<Customer, CustomerDto>()
                .ForMember(a => a.Country, b => b.MapFrom(c => c.Address.Country))
                .ForMember(a => a.City, b => b.MapFrom(c => c.Address.City))
                .ForMember(a => a.Street, b => b.MapFrom(c => c.Address.Street))
                .ForMember(a => a.HouseNumber, b => b.MapFrom(c => c.Address.HouseNumber))
                .ForMember(a => a.ApartmentNumber, b => b.MapFrom(c => c.Address.ApartmentNumber))
                .ForMember(a => a.PostalCode, b => b.MapFrom(c => c.Address.PostalCode))
                .ForMember(a => a.ContactNumber, b => b.MapFrom(c => c.Address.ContactNumber));

            CreateMap<CreateAndUpdateCustomerDto, Customer>()
                .ForMember(a => a.Address,
                    b => b.MapFrom(c => new Address()
                    {
                        Country = c.Country,
                        City = c.City,
                        Street = c.Street,
                        HouseNumber = c.HouseNumber,
                        ApartmentNumber = c.ApartmentNumber,
                        PostalCode = c.PostalCode,
                        ContactNumber = c.ContactNumber
                    })
                );
        }
    }
}