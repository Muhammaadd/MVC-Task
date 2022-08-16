namespace Lab_One.ViewModels
{
    public class TraineeCourseDataViewModel
    {
        public string traineeName { get; set; }
        public string traineeLevel { get; set; }
        public string traineeAddress { get; set; }
        public string traineeProfile { get; set; }
        public string colorStatus { get; set; }
        public List<string> coursesNames { get; set; }
        public List<int> coursesIDs { get; set; }
        public List<int> coursesDegrees { get; set; }
        public List<int> coursesPassDegrees { get; set; }
        public List<float> traineeDegrees { get; set; }

        public TraineeCourseDataViewModel()
        {
            coursesDegrees = new List<int>();
            coursesNames = new List<string>();
            coursesIDs = new List<int>();
            coursesPassDegrees = new List<int>();
            traineeDegrees  = new List<float>();
        }
    }
}
