using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if(ModelState.IsValid){
                Repository.AddStudent(student);
                return View("Thanks", student);
            }else{
                return View(student);
            }
        }

        public IActionResult List(){
            var students = Repository.Students.Where(i => i.Confirm == true);

            return View(students);
        }        

        public IActionResult Details(){
                
            Course course = new Course();
            course.Name = "Core MVC Kursu";
            course.Description = "Faydalı bir kurs";
            course.IsPublish = true;

            return View(course);
        }
    }
}