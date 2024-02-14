using Entity.Abstracts;

namespace Entity.Concretes;

public class Course: IEntity
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }
    public Instructor Instructor { get; set; }
}