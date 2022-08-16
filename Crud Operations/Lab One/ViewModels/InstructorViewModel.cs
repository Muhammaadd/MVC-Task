namespace Lab_One.ViewModels
{
    public class InstructorViewModel
    {
        public int instructorID { get; set; }
        public string instructorName { get; set; }
        public float instructorSalary { get; set; }
        public string instructorAddress { get; set; }
        public int courseID { get; set; }
        public int deptID { get; set; }
        public List<CourseViewModel> courses { get; set; }
        public List<DepartmentViewModel> departments { get; set; }
        public InstructorViewModel()
        {
            courses = new List<CourseViewModel>();
            departments = new List<DepartmentViewModel>();
        }


    }
}
