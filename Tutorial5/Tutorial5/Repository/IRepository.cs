namespace Tutorial5.Repository;

public interface IRepository<T>
{
    List<T> GetAll();
    T GetById(int id);
    T Add(T entity);
    T Update(int id, T entity);
    T Delete(int id);
}