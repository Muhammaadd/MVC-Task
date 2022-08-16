using Microsoft.AspNetCore.Mvc;
using Lab_One.Models;
using Microsoft.EntityFrameworkCore;
using Lab_One.ViewModels;


namespace Lab_One.Controllers
{
    public class InstructorController : Controller
    {
        Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting;
        InstructorViewModel instructorViewModel = new InstructorViewModel();
        DataBaseContext dataBaseContext = new DataBaseContext();
        public InstructorController(Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting)
        {
                this.hosting = hosting;
        }
        public IActionResult Index()
        {
            List<Instructor> instructors = dataBaseContext.Instructors.Include(n=>n.course).Include(n=>n.department).ToList();
            return View(instructors);
        }
        public IActionResult InsDetails(int id)
        {

            return View(dataBaseContext.Instructors.Include(n=>n.course).Include(n=>n.department).Where(n => n.Id == id).FirstOrDefault());
        }
        public IActionResult EditInstructor(int id)
        {
            Instructor instructor = dataBaseContext.Instructors.Where(n => n.Id == id).FirstOrDefault();
            List<Department> departments = dataBaseContext.Departments.ToList();
            List<Course> courses = dataBaseContext.courses.Where(n=>n.Dep_id==instructor.Dept_id).ToList();
            #region ViewModel
            //instructorViewModel.instructorID = id;
            //instructorViewModel.instructorName = instructor.Name;
            //instructorViewModel.instructorAddress = instructor.Address;
            //instructorViewModel.instructorSalary = instructor.Salary;
            //instructorViewModel.courseID = instructor.Crs_id;
            //instructorViewModel.deptID = instructor.Dept_id;
            //foreach(Department department in departments)
            //{
            //    DepartmentViewModel departmentViewModel = new DepartmentViewModel(department.Id,department.Name);
            //    instructorViewModel.departments.Add(departmentViewModel);
            //}
            //foreach (Course course in courses)
            //{
            //    CourseViewModel courseViewModel = new CourseViewModel(course.Id, course.Name);
            //    instructorViewModel.courses.Add(courseViewModel);
            //}
            #endregion
            ViewBag.departments = departments;
            ViewBag.courses = courses;
            return View(instructor);
        }
        [HttpPost]
        public IActionResult SaveInstructor(int id,Instructor instructor)
        {
            
            if (instructor == null || instructor.Image == null || instructor.Name == null || instructor.Salary == 0 || instructor.Address == null)
            {
                List<Department> departments = dataBaseContext.Departments.ToList();
                List<Course> courses = dataBaseContext.courses.ToList();
                ViewBag.departments = departments;
                ViewBag.courses = courses;
                if (id == 0)
                {
                    return View("addNewInstructor");
                }
                return View("EditInstructor",instructor);
            }
            else if(id!=0)
            {
                Instructor oldInstructor = dataBaseContext.Instructors.Where(n => n.Id == id).FirstOrDefault();
                oldInstructor.Name = instructor.Name;
                oldInstructor.Address = instructor.Address;
                oldInstructor.Salary = instructor.Salary;
                oldInstructor.Crs_id = instructor.Crs_id;
                oldInstructor.Dept_id = instructor.Dept_id;
            }
            if(id==0)
            {
                string wwwwrootImagesFolderPath = Path.Combine(hosting.WebRootPath, "images");
                string imageName = instructor.Image.FileName;
                string fullPath = Path.Combine(wwwwrootImagesFolderPath, imageName);
                instructor.Image.CopyTo(new FileStream(fullPath, FileMode.Create));
                instructor.Img = imageName;
                dataBaseContext.Instructors.Add(instructor);
            }
            dataBaseContext.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult addNewInstructor()
        {
            //    List <Department> departments = dataBaseContext.Departments.ToList();
            //    List<Course> courses = dataBaseContext.courses.ToList();
            //    ViewBag.departments = departments;
            //    ViewBag.courses = courses;
            //    return View();
            return View("index");
        }
        public IActionResult add()
        {
            List<Department> departments = dataBaseContext.Departments.ToList();
            List<Course> courses = dataBaseContext.courses.ToList();
            ViewBag.departments = departments;
            ViewBag.courses = courses;
            return View();
        }
    }
}
