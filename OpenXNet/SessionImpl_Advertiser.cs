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
        public Advertiser AddAdvertiser(Advertiser advertiser) {
            advertiser.Id = svc.AddAdvertiser(sessionId, advertiser);
            return advertiser;
        }

        public void DeleteAdvertiser(int advertiserId) {
            svc.DeleteAdvertiser(sessionId, advertiserId);
        }

        public Advertiser GetAdvertiser(int advertiserId) {
            return svc.GetAdvertiser(sessionId, advertiserId);
        }

        public object[] GetAdvertiserBannerStatistics(int advertiserId, DateTime startDate, DateTime endDate) {
            return svc.GetAdvertiserBannerStatistics(sessionId, advertiserId, startDate, endDate);
        }

        public object[] GetAdvertiserCampaignStatistics(int advertiserId, DateTime startDate, DateTime endDate) {
            return svc.GetAdvertiserCampaignStatistics(sessionId, advertiserId, startDate, endDate);
        }

        public Stats[] GetAdvertiserDailyStatistics(int advertiserId, DateTime startDate, DateTime endDate) {
            return svc.GetAdvertiserDailyStatistics(sessionId, advertiserId, startDate, endDate);
        }

        public Advertiser[] GetAdvertisersByManager(int managerId) {
            return svc.GetAdvertisersByManager(sessionId, managerId);
        }

        public object[] GetAdvertiserPublisherStatistics(int advertiserId, DateTime startDate, DateTime endDate) {
            return svc.GetAdvertiserPublisherStatistics(sessionId, advertiserId, startDate, endDate);
        }

        public object[] GetAdvertiserZoneStatistics(int advertiserId, DateTime startDate, DateTime endDate) {
            return svc.GetAdvertiserZoneStatistics(sessionId, advertiserId, startDate, endDate);
        }

        public void ModifyAdvertiser(Advertiser advertiser) {
            svc.ModifyAdvertiser(sessionId, advertiser);
        }
    }
}