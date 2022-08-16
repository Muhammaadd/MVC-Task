using System.ComponentModel.DataAnnotations;
using Lab_One.Models;
namespace Lab_One.Custom_Attributes
{
    public class UniqueAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Course name is requires");
            else
            {
                DataBaseContext context = new DataBaseContext();
                Course courseData = validationContext.ObjectInstance as Course;
                Course course = context.courses.Where(n=>n.Name == value.ToString()&&n.Dep_id ==courseData.Dep_id).FirstOrDefault();
                if(course==null||(courseData.Id == course.Id))
                    return ValidationResult.Success;
                return new ValidationResult("This department already has this Course");
            }
        }
         
    }
}
