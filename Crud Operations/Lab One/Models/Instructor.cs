using System.ComponentModel.DataAnnotations.Schema;
namespace Lab_One.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public float Salary { get; set; }
        public string? Address { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }

        [ForeignKey("course")]
        public int Crs_id { get; set; }
        [ForeignKey("department")]
        public int Dept_id { get; set; }
        public virtual Department? department { get; set; }
        public virtual Course? course { get; set; }

    }
}
