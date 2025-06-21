using StudentCourseMVC.Repositories.Interfaces;

namespace StudentCourseMVC.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICourseRepository CourseRepository { get; }
        Task<int> SaveChangesAsync();
        void Dispose();
    }
}
