using UserService.Domain.Entities;

namespace UserService.Application.Interfaces;

public interface IUserService
{
    Task<User> GetUserAsync(string id);
    Task<IEnumerable<User>> GetUsersAsync();
    Task CreateUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(string id);
}