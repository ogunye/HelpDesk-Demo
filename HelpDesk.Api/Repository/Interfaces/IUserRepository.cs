using Domain.Entities;

namespace HelpDesk.Api.Repository.Interfaces
{
    public interface IUserRepository
    {
        void CreateNewUser(User user);
        void UpdateUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
