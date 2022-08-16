using System.ComponentModel.DataAnnotations.Schema;
namespace Lab_One.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address  { get; set; }
        public string Level { get; set; }
        public string? Profile { get; set; }
        [ForeignKey("department")]
        public int Dept_id { get; set; }
        public virtual Department? department { get; set; }
    }
}
