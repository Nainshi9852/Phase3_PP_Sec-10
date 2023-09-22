using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "Simran", Class = "8A", Age = 21, Address = "S.P Road"},
            new Student { Id = 2, Name = "Sonali", Class = "8B", Age = 22, Address = "XYZABC Street"},
            new Student { Id = 3, Name = "Kundan", Class = "8C", Age = 20, Address = "ZXY Street"},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
