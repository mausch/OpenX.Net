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
        AdvertiserStats[] GetZoneAdvertiserStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.zoneBannerStatistics")]
        AdvertiserCampaignBannerStats[] GetZoneBannerStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.zoneCampaignStatistics")]
        AdvertiserCampaignStats[] GetZoneCampaignStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.zoneDailyStatistics")]
        DailyStats[] GetZoneDailyStatistics(string sessionId, int zoneId, DateTime startDate, DateTime endDate);

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