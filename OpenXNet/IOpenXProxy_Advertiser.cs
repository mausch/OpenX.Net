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
        [XmlRpcMethod("ox.addAdvertiser")]
        int AddAdvertiser(string sessionId, Advertiser advertiser);

        [XmlRpcMethod("ox.deleteAdvertiser")]
        void DeleteAdvertiser(string sessionId, int advertiserId);

        [XmlRpcMethod("ox.getAdvertiser")]
        Advertiser GetAdvertiser(string sessionId, int advertiserId);

        [XmlRpcMethod("ox.advertiserBannerStatistics")]
        CampaignBannerStats[] GetAdvertiserBannerStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.advertiserCampaignStatistics")]
        CampaignStats[] GetAdvertiserCampaignStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.advertiserDailyStatistics")]
        DailyStats[] GetAdvertiserDailyStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getAdvertiserListByAgencyId")]
        Advertiser[] GetAdvertisersByManager(string sessionId, int managerId);

        [XmlRpcMethod("ox.advertiserPublisherStatistics")]
        PublisherStats[] GetAdvertiserPublisherStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.advertiserZoneStatistics")]
        object[] GetAdvertiserZoneStatistics(string sessionId, int advertiserId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.modifyAdvertiser")]
        void ModifyAdvertiser(string sessionId, Advertiser advertiser);

    }
}