using StudentCourseMVC.Repositories.Interfaces;

namespace StudentCourseMVC.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CourseDbContext _context;
        public ICourseRepository CourseRepository { get; }
        public IUserRepository UserRepository { get; }

        public UnitOfWork(CourseDbContext context, ICourseRepository courseRepository, IUserRepository userRepository)
        {
            _context = context;
            CourseRepository = courseRepository;
            UserRepository = userRepository;
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
