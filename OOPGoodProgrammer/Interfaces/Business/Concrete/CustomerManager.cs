using Interfaces.Business.Abstracts;

namespace Interfaces.Business.Concrete;

class CustomerManager : IPersonManger
{
    public void Add()
    {
        // Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }
    
    public void Update()
    {
        // Müşteri güncelleme kodları
        Console.WriteLine("Müşteri güncellendi");
    }
}