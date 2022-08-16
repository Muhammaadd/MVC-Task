using Microsoft.AspNetCore.Mvc;
using Lab_One.Models;
using Lab_One.ViewModels;
using Lab_One.Services;

namespace Lab_One.Controllers
{
    public class CourseController : Controller
    {
        ICourseService courseService;
        IDepartmentService departmentService;
        public CourseController(ICourseService courseService,IDepartmentService departmentService)
        {
            this.courseService = courseService;
            this.departmentService = departmentService;
        }
        public IActionResult Index()
        {
            List<Course> courses = courseService.GetAll();
            ViewBag.DepartmentsNames = departmentService.GetNames(courses);
            return View(courses);
        }
        public IActionResult CourseForm(int id)         
        {
            ViewBag.departments = DepartmentViewModel.getAllDepartments();
            return View(courseService.GetById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveCourse(Course course)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.departments = DepartmentViewModel.getAllDepartments();
                return View("CourseForm", course);
            }
            else if (course.Id == 0)
            {
                courseService.Insert(course);
            }
            else
            {
                courseService.Update(course);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            try
            {
                courseService.Delete(id);
            }
            catch
            {
            };
            return RedirectToAction("Index");

        }
        public IActionResult getCoursesNamesInParticularDepartment(int Id)
        {
            return Json(courseService.GetByDeptId(Id));
        }
        public IActionResult CheckMinimumDegree(int PassDegree, int Degree)
        {
            if(PassDegree<Degree)
                return Json(true);
            else
                return Json(false);
        }
    }
}
