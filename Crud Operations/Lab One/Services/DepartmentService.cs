using Lab_One.Models;
namespace Lab_One.Services
{
    public class DepartmentService : IDepartmentService
    {
        DataBaseContext db;
        public DepartmentService(DataBaseContext db)
        {
            this.db = db;
        }
        public List<Department> GetAll()
        {
            return db.Departments.ToList();
        }
        public Department GetById(int id)
        {
            return db.Departments.Where(d => d.Id == id).FirstOrDefault();
        }
        public void Insert(Department newDepartment)
        {
            db.Departments.Add(newDepartment);
            db.SaveChanges();
        }
        public void Update(int id, Department newDepartment)
        {
            Department oldDepartment = GetById(id);
            db.Departments.Update(newDepartment);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            db.Departments.Remove(GetById(id));
            db.SaveChanges();
        }
        public List<string> GetNames(List<Course> courses)
        {
            List<string> departmentsNames = new List<string>();
            foreach (Course course in courses)
            {
                departmentsNames.Add(db.Departments.Where(n => n.Id == course.Dep_id).Select(n => n.Name).FirstOrDefault());
            }
            return departmentsNames;

        }
    }
}
