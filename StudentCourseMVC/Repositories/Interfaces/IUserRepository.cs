using StudentCourseMVC.Models;

namespace StudentCourseMVC.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersByRoleAsync(string role);
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<User> GetUserByIdAsync(int id);
        Task UpdateUserAsync(User user);
    }
}
