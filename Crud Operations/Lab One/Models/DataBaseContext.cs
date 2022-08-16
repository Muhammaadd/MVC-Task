using Microsoft.EntityFrameworkCore;

namespace Lab_One.Models
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext() : base()
        {

        }

        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Course>? courses { get; set; }
        public virtual DbSet<Department>? Departments { get; set; }
        public virtual DbSet<Instructor>? Instructors { get; set; }
        public virtual DbSet<Trainee>? Trainees { get; set; }
        public virtual DbSet<CrsResult>? CrsResults { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MonofiaDotNetQ3;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
