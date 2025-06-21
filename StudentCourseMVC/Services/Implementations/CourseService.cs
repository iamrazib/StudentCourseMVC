using StudentCourseMVC.Data.UnitOfWork;
using StudentCourseMVC.Models;
using StudentCourseMVC.Services.Interfaces;

namespace StudentCourseMVC.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Course model)
        {
            _unitOfWork.CourseRepository.Add(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Course?> GetCourseByIdAsync(int id)
        {
            return await _unitOfWork.CourseRepository.GetByIdAsync(id);
        }
    }
}
