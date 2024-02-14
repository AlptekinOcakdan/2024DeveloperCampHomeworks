using Interfaces.Business.Abstracts;

namespace Interfaces.Business.Concrete;

internal class ProjectManager
{
    public void Add(IPersonManger personManger)
    {
        personManger.Add();
    }
}