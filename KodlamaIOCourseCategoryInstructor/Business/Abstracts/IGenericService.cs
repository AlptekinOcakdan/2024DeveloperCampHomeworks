using Entity.Abstracts;

namespace Business.Abstracts;

public interface IGenericService<T> where T : class, IEntity, new()
{
    void TInsert(T t);
    void TUpdate(T t);
    void TDelete(T t);
    List<T> TGetList();
    T TGetByID(int id);
}