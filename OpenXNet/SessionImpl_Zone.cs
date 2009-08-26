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
    public partial class SessionImpl {
        public Zone AddZone(Zone zone) {
            zone.Id = svc.AddZone(sessionId, zone);
            return zone;
        }

        public void DeleteZone(int zoneId) {
            svc.DeleteZone(sessionId, zoneId);
        }

        public void ModifyZone(Zone zone) {
            svc.ModifyZone(sessionId, zone);
        }

        public Zone GetZone(int zoneId) {
            return svc.GetZone(sessionId, zoneId);
        }

        public Zone[] GetZonesByPublisher(int publisherId) {
            return svc.GetZonesByPublisher(sessionId, publisherId);
        }

        public object[] GenerateTags(int zoneId, int codeType, object[] param) {
            return svc.GenerateTags(sessionId, zoneId, codeType, param);
        }

        public AdvertiserStats[] GetZoneAdvertiserStatistics(int zoneId, DateTime startDate, DateTime endDate) {
            return svc.GetZoneAdvertiserStatistics(sessionId, zoneId, startDate, endDate);
        }

        public AdvertiserCampaignBannerStats[] GetZoneBannerStatistics(int zoneId, DateTime startDate, DateTime endDate) {
            return svc.GetZoneBannerStatistics(sessionId, zoneId, startDate, endDate);
        }

        public AdvertiserCampaignStats[] GetZoneCampaignStatistics(int zoneId, DateTime startDate, DateTime endDate) {
            return svc.GetZoneCampaignStatistics(sessionId, zoneId, startDate, endDate);
        }

        public DailyStats[] GetZoneDailyStatistics(int zoneId, DateTime startDate, DateTime endDate) {
            return svc.GetZoneDailyStatistics(sessionId, zoneId, startDate, endDate);
        }

        public void LinkBanner(int zoneId, int bannerId) {
            svc.LinkBanner(sessionId, zoneId, bannerId);
        }

        public void UnlinkBanner(int zoneId, int bannerId) {
            svc.UnlinkBanner(sessionId, zoneId, bannerId);
        }

        public void LinkCampaign(int zoneId, int campaignId) {
            svc.LinkCampaign(sessionId, zoneId, campaignId);
        }

        public void UnlinkCampaign(int zoneId, int campaignId) {
            svc.UnlinkCampaign(sessionId, zoneId, campaignId);
        }
    }
}