using Entity.Abstracts;

namespace Entity.Concretes;

public class Instructor: IEntity
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public decimal Salary { get; set; }
    public List<Course> Courses { get; } = new List<Course>();
}