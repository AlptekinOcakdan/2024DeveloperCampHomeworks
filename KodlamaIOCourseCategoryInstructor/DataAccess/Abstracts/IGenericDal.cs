using Entity.Abstracts;

namespace DataAccess.Abstracts;

public interface IGenericDal<T> where T : class, IEntity, new()
{
    void Insert(T t);
    void Update(T t);
    void Delete(T t);
    List<T> GetList();
    T GetByID(int id);
}