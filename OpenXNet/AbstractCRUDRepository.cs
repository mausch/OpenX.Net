namespace OpenXNet {
    public abstract class AbstractCRUDRepository<T> : ICRUDRepository<T> {
        protected readonly ISession session;

        protected AbstractCRUDRepository(ISession session) {
            this.session = session;
        }

        public abstract T Add(T entity);
        public abstract T Update(T entity);
        public abstract void Delete(int id);
        public abstract T Get(int id);
    }
}