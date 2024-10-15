using AutoMapper;
using Library.Api.Entities;
using Library.Api.Models;
using Library.Api.Services.Interfaces;

namespace Library.Api.Services
{
    public class PublishingHouseService : IPublishingHouseService
    {
        private readonly LibraryDbContext _dbContext;
        private readonly IMapper _mapper;

        public PublishingHouseService(LibraryDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public List<PublishingHouseDto> GetAll()
        {
            var publishingHouses = _dbContext
                .PublishingHouses
                .ToList();

            var publishingHousesDto = _mapper.Map<List<PublishingHouseDto>>(publishingHouses);

            return publishingHousesDto;
        }

        public PublishingHouseDto GetById(int id)
        {
            var publishingHouse = _dbContext
                .PublishingHouses
                .FirstOrDefault(p => p.Id == id);

            var publishingHouseDto = _mapper.Map<PublishingHouseDto>(publishingHouse);

            return publishingHouseDto;
        }

        public int Create(CreateAndUpdatePublishingHouseDto dto)
        {
            var publishingHouse = _mapper.Map<PublishingHouse>(dto);

            _dbContext.PublishingHouses.Add(publishingHouse);
            _dbContext.SaveChanges();

            return publishingHouse.Id;
        }

        public void Update(int id, CreateAndUpdatePublishingHouseDto dto)
        {
            var publishingHouse = _dbContext
                .PublishingHouses
                .FirstOrDefault(p => p.Id == id);

            publishingHouse.Name = dto.Name;

            _dbContext.SaveChanges();
        }
    }
}
