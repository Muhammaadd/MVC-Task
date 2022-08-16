using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab_One.Models;
using Lab_One.ViewModels;

namespace Lab_One.Controllers
{
    public class TraineeController : Controller
    {
        DataBaseContext dataBaseContext = new DataBaseContext();
        public IActionResult Index()
        {
            ViewBag.departments = DepartmentViewModel.getNamesOfAllDepartments();
            return View(dataBaseContext.Trainees.ToList());
        }
        public IActionResult Details(int id)
        {
            List<CrsResult> crsResults = dataBaseContext.CrsResults.Where(n=>n.Trainee_id==id).ToList();
            Trainee trainee = dataBaseContext.Trainees.Where(n=>n.Id == id).FirstOrDefault();
            if (crsResults.Count == 0)
            {
                return Content("No there any trainee with this ID");
            }
            TraineeCourseDataViewModel viewModel = new TraineeCourseDataViewModel();
            viewModel.traineeName = trainee.Name;
            viewModel.traineeAddress = trainee.Address;
            viewModel.traineeLevel = trainee.Level;
            viewModel.traineeProfile = trainee.Profile;

            foreach (var crsResult in crsResults)
            {
                viewModel.traineeDegrees.Add(crsResult.degree);
                viewModel.coursesIDs.Add(crsResult.Crs_id);
            }
            foreach(var crsID in viewModel.coursesIDs)
            {
                Course course = dataBaseContext.courses.Where(c => c.Id == crsID).FirstOrDefault();
                viewModel.coursesNames.Add(course.Name);
                viewModel.coursesDegrees.Add(course.Degree);
                viewModel.coursesPassDegrees.Add(course.PassDegree);
            }
            return View(viewModel);
            
        }
    }
}
