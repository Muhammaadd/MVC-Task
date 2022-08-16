using Microsoft.AspNetCore.Mvc;
using Lab_One.Models;

namespace Lab_One.Controllers
{
    public class StudentController : Controller
    {
        DBContext db = new DBContext();
        public IActionResult Index()
        {
            return View("StudentsList",db.getAllStudents());
        }
        public IActionResult studentDetails(int id)
        {   
            return View("StudentDetails", db.getStudentById(id));
        }
    }
}
