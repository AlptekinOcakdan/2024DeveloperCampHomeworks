using Entity.Abstracts;

namespace Entity.Concretes;

public class Category:IEntity
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; } = new List<Course>();
}