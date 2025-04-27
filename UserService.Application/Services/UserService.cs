using UserService.Application.Interfaces;
using UserService.Domain.Entities;

namespace UserService.Application.Services;

public class UserService: IUserService
{
    private readonly IUserReadRepository _readRepository;
    private readonly IUserWriteRepository _writeRepository;
    private readonly IBlobStorageService _blobStorageService;

    public UserService(IUserReadRepository readRepository, IUserWriteRepository writeRepository,
        IBlobStorageService blobStorageService)
    {
        _readRepository = readRepository;
        _writeRepository = writeRepository;
        _blobStorageService = blobStorageService;
    }

    public async Task<User> GetUserAsync(string id) => await _readRepository.GetUserByIdAsync(id);
    public async Task<IEnumerable<User>> GetUsersAsync() => await _readRepository.GetAllUsersAsync();
    public async Task CreateUserAsync(User user) => await _writeRepository.CreateUserAsync(user);
    public async Task UpdateUserAsync(User user) => await _writeRepository.UpdateUserAsync(user);
    public async Task DeleteUserAsync(string id) => await _writeRepository.DeleteUserAsync(id);
}