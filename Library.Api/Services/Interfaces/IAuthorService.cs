using Library.Api.Models;

namespace Library.Api.Services.Interfaces
{
    public interface IAuthorService
    {
        int Create(CreateAndUpdateAuthorDto dto);
        void Update(int id, CreateAndUpdateAuthorDto dto);
        AuthorDto GetById(int id);
        List<AuthorDto> GetAll();
    }
}
