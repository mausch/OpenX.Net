namespace OpenXNet {
    public interface IRepository<T> {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T Get(int id);
    }
}