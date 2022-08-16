using System.ComponentModel.DataAnnotations.Schema;
namespace Lab_One.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public float degree { get; set; }
        [ForeignKey("Course")]
        public int Crs_id { get; set; }
        [ForeignKey("trainee")]

        public int Trainee_id { get; set; }
        public virtual Course? Course { get; set; }
        public virtual Trainee? trainee { get; set; }

    }
}
