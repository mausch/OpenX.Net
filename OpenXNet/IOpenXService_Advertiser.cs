using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXService {
        [XmlRpcMethod("ox.addAdvertiser")]
        int AddAdvertiser(string sessionId, Advertiser advertiser);

        [XmlRpcMethod("ox.deleteAdvertiser")]
        void DeleteAdvertiser(string sessionId, int advertiserId);

        [XmlRpcMethod("ox.getAdvertiser")]
        Advertiser GetAdvertiser(string sessionId, int advertiserId);

        [XmlRpcMethod("ox.getAdvertiserBannerStatistics")]
        object[] GetAdvertiserBannerStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAdvertiserCampaignStatistics")]
        object[] GetAdvertiserCampaignStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAdvertiserDailyStatistics")]
        object[] GetAdvertiserDailyStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAdvertiserListByAgencyId")]
        Advertiser[] GetAdvertisersByManager(string sessionId, int managerId);

        [XmlRpcMethod("ox.getAdvertiserPublisherStatistics")]
        object[] GetAdvertiserPublisherStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAdvertiserZoneStatistics")]
        object[] GetAdvertiserZoneStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.modifyAdvertiser")]
        void ModifyAdvertiser(string sessionId, Advertiser advertiser);

    }
}