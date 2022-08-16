namespace Lab_One.ViewModels
{
    public class CourseViewModel
    {
        public int crsId { get; set; }
        public string crsName { get; set; }
        public CourseViewModel(int id ,string name)
        {
            crsId = id;
            crsName = name;
        }
    }
}
