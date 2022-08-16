using Lab_One.Models;

namespace Lab_One.ViewModels
{
    public class DepartmentViewModel
    {
        public int deptId { get; set; }
        public string deptName { get; set; }

        public DepartmentViewModel(int id , string name)
        {
            this.deptId = id;
            this.deptName = name;
        }
        public static List<string> getDepartmentsNames(List<Course> courses)
        {
            DataBaseContext context = new DataBaseContext();
            List<string> departmentsNames = new List<string>();
            foreach (Course course in courses)
            {
                departmentsNames.Add(context.Departments.Where(n => n.Id == course.Dep_id).Select(n => n.Name).FirstOrDefault());
            }
            return departmentsNames;

        }
        public static List<DepartmentViewModel> getAllDepartments()
        {
            DataBaseContext context = new DataBaseContext();
            List<DepartmentViewModel> departments = new List<DepartmentViewModel>();
            var deps = context.Departments.Select(n=>new {n.Id,n.Name}).ToList();
            foreach (var department in deps)
            {
                departments.Add(new DepartmentViewModel(department.Id, department.Name));
            }
            return departments;
        }
        public static List<string> getNamesOfAllDepartments()
        {
            DataBaseContext context = new DataBaseContext();
            return context.Departments.Select(n => n.Name).ToList();
        }
    }
}
