using StudentCourseMVC.Repositories.Interfaces;

namespace StudentCourseMVC.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ICourseRepository CourseRepository { get; }
        Task<int> SaveChangesAsync();
        void Dispose();
    }
}
