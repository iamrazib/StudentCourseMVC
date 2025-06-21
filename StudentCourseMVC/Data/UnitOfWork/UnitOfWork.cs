using StudentCourseMVC.Repositories.Interfaces;

namespace StudentCourseMVC.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CourseDbContext _context;
        public ICourseRepository CourseRepository { get; }

        public UnitOfWork(CourseDbContext context, ICourseRepository courseRepository)
        {
            _context = context;
            CourseRepository = courseRepository;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
