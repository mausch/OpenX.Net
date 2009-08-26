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
        [XmlRpcMethod("ox.addCampaign")]
        int AddCampaign(string sessionId, Campaign campaign);

        [XmlRpcMethod("ox.getCampaign")]
        Campaign GetCampaign(string sessionId, int campaignId);

        [XmlRpcMethod("ox.deleteCampaign")]
        void DeleteCampaign(string sessionId, int campaignId);

        [XmlRpcMethod("ox.modifyCampaign")]
        void ModifyCampaign(string sessionId, Campaign campaign);

        [XmlRpcMethod("ox.campaignBannerStatistics")]
        CampaignBannerStats[] GetCampaignBannerStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.campaignDailyStatistics")]
        DailyStats[] GetCampaignDailyStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.getCampaignListByAdvertiserId")]
        Campaign[] GetCampaignsByAdvertiser(string sessionId, int advertiserId);

        [XmlRpcMethod("ox.campaignPublisherStatistics")]
        PublisherStats[] GetCampaignPublisherStatistics(string sessionId, int campaignId, DateTime startDate, DateTime endDate);
    }
}