using System.ComponentModel.DataAnnotations;

namespace StudentCourseMVC.Models.ViewModel
{
    public class CourseCreateViewModel
    {
        [Required]
        public string StudentName { get; set; }

        [Required]
        public string CourseTitle { get; set; }

        [Range(0, 100)]
        public int TotalMarks { get; set; }
    }
}
