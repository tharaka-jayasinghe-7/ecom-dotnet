using UserService.Domain.Entities;

namespace UserService.Application.Interfaces;

public interface IUserReadRepository
{
    Task<User> GetUserByIdAsync(string id);
    Task<IEnumerable<User>> GetAllUsersAsync();
}