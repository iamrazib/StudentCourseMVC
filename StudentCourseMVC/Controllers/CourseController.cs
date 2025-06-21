using Microsoft.AspNetCore.Mvc;
using StudentCourseMVC.Services.Interfaces;

namespace StudentCourseMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


    }
}
