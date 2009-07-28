using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXService {
        [XmlRpcMethod("ox.addBanner")]
        void AddBanner(string sessionId, Banner banner);

        [XmlRpcMethod("ox.deleteBanner")]
        void DeleteBanner(string sessionId, int bannerId);

        [XmlRpcMethod("ox.modifyBanner")]
        void ModifyBanner(string sessionId, Banner banner);

        [XmlRpcMethod("ox.getBanner")]
        Banner GetBanner(string sessionId, int bannerId);

        [XmlRpcMethod("ox.getBannerListByCampaignId")]
        Banner[] GetBannersByCampaign(string sessionId, int campaignId);

        [XmlRpcMethod("ox.getBannerDailyStatistics")]
        object[] GetBannerDailyStatistics(string sessionId, int bannerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getBannerPublisherStatistics")]
        object[] GetBannerPublisherStatistics(string sessionId, int bannerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getBannerZoneStatistics")]
        object[] GetBannerZoneStatistics(string sessionId, int bannerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getBannerTargeting")]
        object[] GetBannerTargeting(string sessionId, int bannerId);

        [XmlRpcMethod("ox.setBannerTargeting")]
        void SetBannerTargeting(string sessionId, int bannerId, object[] targeting);
    }
}