using StudentCourseMVC.Models;

namespace StudentCourseMVC.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync(string role);

        Task<User> GetUserByIdAsync(int id);
        Task UpdateUserAsync(User user);
    }
}
