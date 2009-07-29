namespace OpenXNet {
    public interface ICRUDRepository<T> {
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);
        T Get(int id);
    }
}