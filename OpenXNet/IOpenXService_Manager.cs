using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXService {
        [XmlRpcMethod("ox.addAgency")]
        void AddManager(string sessionId, Manager manager);

        [XmlRpcMethod("ox.deleteAgency")]
        void DeleteManager(string sessionId, int managerId);

        [XmlRpcMethod("ox.getAgency")]
        Manager GetManager(string sessionId, int managerId);

        [XmlRpcMethod("ox.modifyAgency")]
        void ModifyManager(string sessionId, Manager manager);

        [XmlRpcMethod("ox.getAgencyAdvertiserStatistics")]
        object[] GetManagerAdvertiserStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyBannerStatistics")]
        object[] GetManagerBannerStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyCampaignStatistics")]
        object[] GetManagerCampaignStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyDailyStatistics")]
        object[] GetManagerDailyStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyList")]
        Manager[] GetManagerList(string sessionId);

        [XmlRpcMethod("ox.getAgencyPublisherStatistics")]
        object[] GetManagerPublisherStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyZoneStatistics")]
        object[] GetManagerZoneStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);


    }
}