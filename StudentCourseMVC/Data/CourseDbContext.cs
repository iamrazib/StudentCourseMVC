using Microsoft.EntityFrameworkCore;
using StudentCourseMVC.Models;

namespace StudentCourseMVC.Data
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Course>().ToTable("Courses");
            base.OnModelCreating(modelBuilder);
        }
    }
}
