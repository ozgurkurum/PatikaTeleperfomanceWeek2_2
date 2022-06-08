using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        //Teacher ve lesson arasındaki birebir ilişkiyi fluent api ile onmodelcreatingde verdim.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasOne(a => a.Lesson)
                .WithOne(b => b.Teacher)
                .HasForeignKey<Lesson>(b => b.TeacherId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
