namespace OpenXNet {
    public interface IRepository<T> {
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);
        T Get(int id);
    }
}