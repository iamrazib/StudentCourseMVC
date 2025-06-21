using StudentCourseMVC.Data;
using StudentCourseMVC.Models;
using StudentCourseMVC.Repositories.Interfaces;

namespace StudentCourseMVC.Repositories.Implementations
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(CourseDbContext context) : base(context)
        {
        }

    }
}
