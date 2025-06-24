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
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Models.Course>().ToTable("Courses");
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "John", LastName = "Doe", Role = "Admin" },
                new User { Id = 2, FirstName = "Jane", LastName = "Smith", Role = "Manager" },
                new User { Id = 3, FirstName = "Sam", LastName = "Brown", Role = "Salesman" },
                new User { Id = 4, FirstName = "Peter", LastName = "Johnson", Role = "Admin" },
                new User { Id = 5, FirstName = "Emily", LastName = "Davis", Role = "Manager" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
