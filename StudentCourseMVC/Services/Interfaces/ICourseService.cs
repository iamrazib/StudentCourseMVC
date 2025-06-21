using StudentCourseMVC.Data.UnitOfWork;
using StudentCourseMVC.Models;

namespace StudentCourseMVC.Services.Interfaces
{
    public interface ICourseService
    {
        Task CreateAsync(Course model);
        Task<Course?> GetCourseByIdAsync(int id);
    }
}
