using UserService.Domain.Entities;
namespace UserService.Application.Interfaces;

public interface IUserWriteRepository
{
    Task CreateUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(string id);
    //check User here
}