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
            return session.Svc.GetBannerDailyStatistics(session.SessionId, bannerId, startDate, endDate);
        }

        public object[] GetBannerPublisherStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return session.Svc.GetBannerPublisherStatistics(session.SessionId, bannerId, startDate, endDate);
        }

        public object[] GetBannerZoneStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return session.Svc.GetBannerZoneStatistics(session.SessionId, bannerId, startDate, endDate);
        }

        public BannerTargeting[] GetBannerTargeting(int bannerId) {
            return session.Svc.GetBannerTargeting(session.SessionId, bannerId);
        }

        public void SetBannerTargeting(int bannerId, BannerTargeting[] targeting) {
            session.Svc.SetBannerTargeting(session.SessionId, bannerId, targeting);
        }
    }
}