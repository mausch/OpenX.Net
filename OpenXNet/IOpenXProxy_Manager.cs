#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXProxy {
        [XmlRpcMethod("ox.addAgency")]
        int AddManager(string sessionId, Manager manager);

        [XmlRpcMethod("ox.deleteAgency")]
        void DeleteManager(string sessionId, int managerId);

        [XmlRpcMethod("ox.getAgency")]
        Manager GetManager(string sessionId, int managerId);

        [XmlRpcMethod("ox.modifyAgency")]
        void ModifyManager(string sessionId, Manager manager);

        [XmlRpcMethod("ox.agencyAdvertiserStatistics")]
        AdvertiserStats[] GetManagerAdvertiserStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyBannerStatistics")]
        object[] GetManagerBannerStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyCampaignStatistics")]
        object[] GetManagerCampaignStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyDailyStatistics")]
        object[] GetManagerDailyStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyList")]
        Manager[] GetManagers(string sessionId);

        [XmlRpcMethod("ox.getAgencyPublisherStatistics")]
        object[] GetManagerPublisherStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAgencyZoneStatistics")]
        object[] GetManagerZoneStatistics(string sessionId, int managerId, DateTime startDate, DateTime endDate);


    }
}