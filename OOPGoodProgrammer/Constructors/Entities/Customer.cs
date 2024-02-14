namespace Constructors.Entities;

class Customer
{
    // Constructor
    public Customer()
    {
        Console.WriteLine("Customer Constructor");
    }

    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}