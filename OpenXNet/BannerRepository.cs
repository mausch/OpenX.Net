using System;

namespace OpenXNet {
    public class BannerRepository : AbstractRepository<Banner> {
        public BannerRepository(ISession session) : base(session) {}

        public override Banner Add(Banner entity) {
            var id = session.Svc.AddBanner(session.SessionId, entity);
            entity.Id = id;
            return entity;
        }

        public override Banner Update(Banner entity) {
            session.Svc.ModifyBanner(session.SessionId, entity);
            return entity;
        }

        public override Banner Delete(Banner entity) {
            session.Svc.DeleteBanner(session.SessionId, entity.Id);
            return entity;
        }

        public override Banner Get(int id) {
            return session.Svc.GetBanner(session.SessionId, id);
        }
    }
}