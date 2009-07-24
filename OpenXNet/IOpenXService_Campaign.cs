using System;
using System.Collections;
using System.Collections.Generic;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXService {
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

        [XmlRpcMethod("ox.campaignListByAdvertiserId")]
        Campaign[] GetCampaignListByAdvertiser(string sessionId, int advertisedId);

        [XmlRpcMethod("ox.campaignPublisherStatistics")]
        object[] GetCampaignPublisherStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);
    }
}