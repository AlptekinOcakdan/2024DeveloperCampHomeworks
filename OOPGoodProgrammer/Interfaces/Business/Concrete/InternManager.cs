using Interfaces.Business.Abstracts;

namespace Interfaces.Business.Concrete;

internal class InternManager : IPersonManger
{
    public void Add()
    {
        // Stajyer ekleme kodları
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        // Stajyer güncelleme kodları
        Console.WriteLine("Stajyer güncellendi");
    }
}