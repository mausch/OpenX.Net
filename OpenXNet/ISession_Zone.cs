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

namespace OpenXNet {
    public partial interface ISession {
        Zone AddZone(Zone zone);

        void DeleteZone(int zoneId);

        void ModifyZone(Zone zone);

        Zone GetZone(int zoneId);

        Zone[] GetZonesByPublisher(int publisherId);

        object[] GenerateTags(int zoneId, int codeType, object[] param);

        AdvertiserStats[] GetZoneAdvertiserStatistics(int zoneId, DateTime startDate, DateTime endDate);

        AdvertiserCampaignBannerStats[] GetZoneBannerStatistics(int zoneId, DateTime startDate, DateTime endDate);

        object[] GetZoneCampaignStatistics(int zoneId, DateTime startDate, DateTime endDate);

        object[] GetZoneDailyStatistics(int zoneId, DateTime startDate, DateTime endDate);

        void LinkBanner(int zoneId, int bannerId);

        void UnlinkBanner(int zoneId, int bannerId);

        void LinkCampaign(int zoneId, int campaignId);

        void UnlinkCampaign(int zoneId, int campaignId);
    }
}