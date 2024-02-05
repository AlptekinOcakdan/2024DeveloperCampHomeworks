using Business.Concrete;
using Entities.Concrete;

namespace WorkAround;

internal static class Program
{
    static void Main(string[] args)
    {
        // Variables
        Citizen citizen1 = new Citizen();

        SayHello("Alptekin");
        SayHello("Murat");
        SayHello();
        int result = SumUp(3, 5);

        // Arrays

        string[] students = new string[3];
        students[0] = "Fatma";
        students[1] = "Mahmut";
        students[2] = "Özge";

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }

        string[] countries1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] countries2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
        countries2 = countries1;
        countries1[0] = "Sakarya";
        Console.WriteLine(countries2[0]);


        foreach (string country in countries1)
        {
            Console.WriteLine(country);
        }

        List<string> newCountries1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
        newCountries1.Add("Ordu");

        foreach (string country in newCountries1)
        {
            Console.WriteLine(country);
        }

        Person person1 = new Person();
        person1.FirstName = "Alptekin";
        person1.LastName = "Ocakdan";
        person1.DateofBirthYear = 2000;
        person1.NationalIdentity = 12345678910;


        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }

    static void SayHello(string name = "nameless")
    {
        Console.WriteLine("Hello " + name);
    }

    static int SumUp(int num1, int num2)
    {
        int result = num1 + num2;
        Console.WriteLine("Sum: " + result);
        return result;
    }

    private static void Variables()
    {
        string message = "Hello";
        double amount = 10000.5;
        int number = 100;
        bool isLoggedIn = false;

        string name = "Alptekin";
        string surname = "Ocakdan";
        int birthYear = 2000;
        long nationalityNumber = 12345678910;
        Console.WriteLine(10000 * 1.08);
    }
}

public class Citizen
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int BirthYear { get; set; }
    public long NationalityNumber { get; set; }
}