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

        [XmlRpcMethod("ox.getCampaignBannerStatistics")]
        void GetCampaignBannerStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getCampaignDailyStatistics")]
        void GetCampaignDailyStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getCampaignListByAdvertiserId")]
        Campaign[] GetCampaignListByAdvertiser(string sessionId, int advertisedId);

        [XmlRpcMethod("ox.getCampaignPublisherStatistics")]
        object[] GetCampaignPublisherStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);
    }
}