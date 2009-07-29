using System;

namespace OpenXNet {
    public class BannerRepository : AbstractRepository<Banner>, IBannerRepository {
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

        public override void Delete(int id) {
            session.Svc.DeleteBanner(session.SessionId, id);
        }

        public override Banner Get(int id) {
            return session.Svc.GetBanner(session.SessionId, id);
        }

        public Banner[] GetBannersByCampaign(int campaignId) {
            return session.Svc.GetBannersByCampaign(session.SessionId, campaignId);
        }

        public object[] GetBannerDailyStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            throw new NotImplementedException();
        }

        public object[] GetBannerPublisherStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            throw new NotImplementedException();
        }

        public object[] GetBannerZoneStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            throw new NotImplementedException();
        }

        public BannerTargeting[] GetBannerTargeting(int bannerId) {
            throw new NotImplementedException();
        }

        public void SetBannerTargeting(int bannerId, BannerTargeting[] targeting) {
            throw new NotImplementedException();
        }
    }
}