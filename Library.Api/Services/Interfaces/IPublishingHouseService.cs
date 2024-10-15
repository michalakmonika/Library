using Library.Api.Models;

namespace Library.Api.Services.Interfaces
{
    public interface IPublishingHouseService
    {
        List<PublishingHouseDto> GetAll();
        PublishingHouseDto GetById(int id);
        int Create(CreateAndUpdatePublishingHouseDto dto);
        void Update(int id, CreateAndUpdatePublishingHouseDto dto);
    }
}
