using Lab_One.Models;

namespace Lab_One.Services
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        Department GetById(int id);
        void Insert(Department newDepartment);
        void Update(int id, Department newDepartment);
        void Delete(int id);
        List<string> GetNames(List<Course> courses);

    }
}
