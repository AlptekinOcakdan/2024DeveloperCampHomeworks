using Interfaces.Business.Abstracts;

namespace Interfaces.Business.Concrete;

class EmployeeManager : IPersonManger
{
    public void Add()
    {
        // Personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }
    
    public void Update()
    {
        // Personel güncelleme kodları
        Console.WriteLine("Personel güncellendi");
    }
}