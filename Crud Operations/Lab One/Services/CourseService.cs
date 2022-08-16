using Lab_One.Models;
namespace Lab_One.Services
{
    public class CourseService:ICourseService
    {
        DataBaseContext db;
        public CourseService(DataBaseContext db)
        {
            this.db = db;
        }
        public List<Course> GetAll()
        {
            return db.courses.ToList();
        }
        public Course GetById(int id)
        {
            return db.courses.Where(d => d.Id == id).FirstOrDefault();
        }
        public void Insert(Course newCourse)
        {
            db.courses.Add(newCourse);
            db.SaveChanges();
        }
        public void Update(Course newCourse)
        {
            db.courses.Update(newCourse);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            db.courses.Remove(GetById(id));
            db.SaveChanges();
        }
        public dynamic GetByDeptId(int deptId)
        {
            return db.courses.Where(n => n.Dep_id == deptId).Select(n => new { n.Id, n.Name }).ToList();
        }
    }
}
