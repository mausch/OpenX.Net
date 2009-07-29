using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXProxy {
        [XmlRpcMethod("ox.addZone")]
        int AddZone(string sessionId, Zone zone);

        [XmlRpcMethod("ox.deleteZone")]
        void DeleteZone(string sessionId, int zoneId);

        [XmlRpcMethod("ox.modifyZone")]
        void ModifyZone(string sessionId, Zone zone);

        [XmlRpcMethod("ox.getZone")]
        Zone GetZone(string sessionId, int zoneId);

        [XmlRpcMethod("ox.getZoneListByPublisherId")]
        Zone[] GetZonesByPublisher(string sessionId, int publisherId);

        [XmlRpcMethod("ox.generateTags")]
        object[] GenerateTags(string sessionId, int zoneId, int codeType, object[] param);

        [XmlRpcMethod("ox.zoneAdvertiserStatistics")]
        object[] GetZoneAdvertiserStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.zoneBannerStatistics")]
        object[] GetZoneBannerStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.zoneCampaignStatistics")]
        object[] GetZoneCampaignStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.zoneDailyStatistics")]
        object[] GetZoneDailyStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.linkBanner")]
        void LinkBanner(string sessionId, int zoneId, int bannerId);

        [XmlRpcMethod("ox.unlinkBanner")]
        void UnlinkBanner(string sessionId, int zoneId, int bannerId);

        [XmlRpcMethod("ox.linkCampaign")]
        void LinkCampaign(string sessionId, int zoneId, int campaignId);

        [XmlRpcMethod("ox.unlinkCampaign")]
        void UnlinkCampaign(string sessionId, int zoneId, int campaignId);
    }
}