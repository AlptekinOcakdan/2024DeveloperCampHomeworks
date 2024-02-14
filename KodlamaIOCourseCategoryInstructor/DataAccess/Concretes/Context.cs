using Entity.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes;

public class Context:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=KodlamaIo Initial Catalog=CourseEducationProjectDB; Integrated Security=true; TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(e => e.Courses)
            .WithOne(e => e.Category)
            .HasForeignKey("CategoryId")
            .IsRequired();

        modelBuilder.Entity<Instructor>()
            .HasMany(e => e.Courses)
            .WithOne(e => e.Instructor)
            .HasForeignKey("InstructorId")
            .IsRequired();
        modelBuilder.Entity<Instructor>()
            .Property(i => i.Salary)
            .HasPrecision(20, 2);
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
}