using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class MydbContext : DbContext
    {
        public MydbContext() { }
        public MydbContext(DbContextOptions<MydbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(a => a.idAlumno);

        }

    }
}
