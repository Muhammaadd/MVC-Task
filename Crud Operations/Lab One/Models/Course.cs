using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Lab_One.Custom_Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Lab_One.Models
{
    public class Course
    {
        public Course()
        {
            Instructors = new List<Instructor>();
        }
        public int Id { get; set; }
        [Unique]
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        [Display(Name="Course Name")]
        public string Name { get; set; }
        [Required]
        [Range(50,100)]
        [Display(Name = "Course Degree")]
        public int Degree { get; set; }
        [Required]
        [Remote("CheckMinimumDegree","Course",AdditionalFields = "Degree", ErrorMessage ="The minimum degree should be smaller than course degree")]
        [Display(Name = "Minimum Degree")]
        public int PassDegree { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        [ForeignKey("department")]
        public int Dep_id { get; set; }
        public virtual Department? department { get; set; }
        public virtual List<Instructor>? Instructors { get; set; }
    }
}
