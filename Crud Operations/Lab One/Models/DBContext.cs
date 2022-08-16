namespace Lab_One.Models
{
    public class DBContext
    {
        public List<Student> students { get; set; }
       
        public DBContext()
        {
            students = new List<Student>()
                {
                    new Student(){id = 2, name = "Muhammed A.abdelrazek" , age = 25 , address = "10 abdelmonem street" , profilePic = "6.jpg"} ,
                    new Student(){id = 1, name = "Amira Mustafa" , age = 22 , address = "20 Nasr City" , profilePic = "1.jpg"} ,
                    new Student(){id = 3, name = "Ahmed Ali" , age = 20 , address = "El Maadii Street" , profilePic = "5.jpg"} ,
                    new Student(){id = 4, name = "Malak Ziad" , age = 21 , address = "Cairo , Egypt" , profilePic = "2.jpg"} ,
                    new Student(){id = 5, name = "Sara Ahmed" , age = 19 , address = "Alex , Egypt" , profilePic = "3.jpg"} ,
                    new Student(){id = 6, name = "Mo Salah" , age = 23 , address = "Menofia , Egypt" , profilePic = "4.jpg"} ,
            };
        }
        
        public List<Student> getAllStudents()
        {
            return students;
        }
        public Student getStudentById(int id)
        {
            return students.FirstOrDefault(x=>x.id==id);
        }
    }
}
