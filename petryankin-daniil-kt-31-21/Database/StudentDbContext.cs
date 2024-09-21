using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21.Database.Configurations;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Применение конфигураций
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
    }
}