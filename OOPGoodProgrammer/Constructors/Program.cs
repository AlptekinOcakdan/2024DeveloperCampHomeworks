using Constructors.Entities;

Customer customer = new Customer { Id = 1, FirstName = "Alptekin", LastName = "Ocakdan", City = "İstanbul" };
Customer customer2 = new Customer(2, "Derin", "Ocakdan", "İstanbul");

Console.WriteLine(customer2.FirstName);