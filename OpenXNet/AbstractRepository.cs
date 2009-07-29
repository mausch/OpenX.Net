namespace OpenXNet {
    public abstract class AbstractRepository<T> : IRepository<T> {
        protected readonly ISession session;

        protected AbstractRepository(ISession session) {
            this.session = session;
        }

        public abstract T Add(T entity);
        public abstract T Update(T entity);
        public abstract void Delete(int id);
        public abstract T Get(int id);
    }
}