// Value Type int, float, double, decimal, char, bool, struct

using ReferenceTypes.Business.Concrete;
using ReferenceTypes.Entities;

int number1 = 10;
int number2 = 20;

number1 = number2;
number2 = 30;

Console.WriteLine("Number 1 :" + number1); // 20

// Reference Type array, class, interface

int[] numbers1 = new int[] { 1, 2, 3 };
int[] numbers2 = new int[] { 10, 20, 30 };

numbers1 = numbers2;
numbers2[0] = 1000;

Console.WriteLine("Numbers 1 :" + numbers1[0]); // 1000

Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Alptekin";

person2 = person1;
person1.FirstName = "Derin";

Console.WriteLine(person2.FirstName); // Derin

// Person, Customer, Employee

Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardNumber = "1234567890";

Employee employee = new Employee();
employee.FirstName = "Veli";

Person person3 = customer;
customer.FirstName = "Ahmet";

Console.WriteLine(person3.FirstName); // Ahmet
Console.WriteLine(((Customer)person3).CreditCardNumber);

PersonManager personManager = new PersonManager();
personManager.Add(employee);