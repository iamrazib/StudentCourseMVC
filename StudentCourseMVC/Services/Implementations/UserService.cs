using StudentCourseMVC.Models;
using StudentCourseMVC.Repositories.Interfaces;
using StudentCourseMVC.Services.Interfaces;

namespace StudentCourseMVC.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersAsync(string role)
        {
            return await _userRepository.GetUsersByRoleAsync(role);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateUserAsync(user);
        }
    }
}
