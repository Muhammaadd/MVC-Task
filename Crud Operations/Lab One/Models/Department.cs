namespace Lab_One.Models
{
    public class Department
    {
        public Department()
        {
            Instructors = new List<Instructor>();
            Courses = new List<Course>();
            Trainees = new List<Trainee>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public virtual List<Instructor>? Instructors { get; set; }
        public virtual List<Course>? Courses { get; set; }
        public virtual List<Trainee>? Trainees { get; set; }
    }
}
