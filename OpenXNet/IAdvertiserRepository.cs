using System;

namespace OpenXNet {
    public interface IAdvertiserRepository : ICRUDRepository<Advertiser> {
        object[] GetAdvertiserBannerStatistics(int advertiserId, DateTime startDate, DateTime endDate);
        object[] GetAdvertiserCampaignStatistics(int advertiserId, DateTime startDate, DateTime endDate);
        object[] GetAdvertiserDailyStatistics(int advertiserId, DateTime startDate, DateTime endDate);
        Advertiser[] GetAdvertisersByManager(int managerId);
        object[] GetAdvertiserPublisherStatistics(int advertiserId, DateTime startDate, DateTime endDate);
        object[] GetAdvertiserZoneStatistics(int advertiserId, DateTime startDate, DateTime endDate);
    }
}