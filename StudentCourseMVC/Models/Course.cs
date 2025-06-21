using System.ComponentModel.DataAnnotations;

namespace StudentCourseMVC.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string CourseTitle { get; set; }

        [Range(0, 100)]
        public int TotalMarks { get; set; }

        public Status Status { get; set; }
    }

    public enum Status
    {
        NeedsImprovement,
        Good,
        Excellent
    }
}
