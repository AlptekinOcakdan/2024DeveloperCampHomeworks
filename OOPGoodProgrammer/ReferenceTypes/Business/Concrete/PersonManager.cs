using ReferenceTypes.Entities;

namespace ReferenceTypes.Business.Concrete;

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}