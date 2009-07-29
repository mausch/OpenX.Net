using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXProxy {
        [XmlRpcMethod("ox.addCampaign")]
        int AddCampaign(string sessionId, Campaign campaign);

        [XmlRpcMethod("ox.getCampaign")]
        Campaign GetCampaign(string sessionId, int campaignId);

        [XmlRpcMethod("ox.deleteCampaign")]
        void DeleteCampaign(string sessionId, int campaignId);

        [XmlRpcMethod("ox.modifyCampaign")]
        void ModifyCampaign(string sessionId, Campaign campaign);

        [XmlRpcMethod("ox.campaignBannerStatistics")]
        object[] GetCampaignBannerStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.campaignDailyStatistics")]
        object[] GetCampaignDailyStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getCampaignListByAdvertiserId")]
        Campaign[] GetCampaignsByAdvertiser(string sessionId, int advertiserId);

        [XmlRpcMethod("ox.campaignPublisherStatistics")]
        object[] GetCampaignPublisherStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);
    }
}