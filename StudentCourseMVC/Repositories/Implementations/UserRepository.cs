using Microsoft.EntityFrameworkCore;
using StudentCourseMVC.Data;
using StudentCourseMVC.Models;
using StudentCourseMVC.Repositories.Interfaces;
using System;

namespace StudentCourseMVC.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly CourseDbContext _context;

        public UserRepository(CourseDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersByRoleAsync(string role)
        {
            if (string.IsNullOrEmpty(role) || role == "All")
            {
                return await _context.Users.ToListAsync();
            }
            return await _context.Users.Where(u => u.Role == role).ToListAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
