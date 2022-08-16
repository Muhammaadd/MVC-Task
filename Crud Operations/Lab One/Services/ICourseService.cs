using Lab_One.Models;
namespace Lab_One.Services
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Insert(Course newCourse);
        void Update(Course newCourse);
        void Delete(int id);
        dynamic GetByDeptId(int deptId);
    }
}
