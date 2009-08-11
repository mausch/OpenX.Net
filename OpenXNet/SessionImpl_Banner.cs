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
        public Banner AddBanner(Banner banner) {
            banner.Id = svc.AddBanner(sessionId, banner);
            return banner;
        }

        public void DeleteBanner(int bannerId) {
            svc.DeleteBanner(sessionId, bannerId);
        }

        public void ModifyBanner(Banner banner) {
            svc.ModifyBanner(sessionId, banner);
        }

        public Banner GetBanner(int bannerId) {
            return svc.GetBanner(sessionId, bannerId);
        }

        public Banner[] GetBannersByCampaign(int campaignId) {
            return svc.GetBannersByCampaign(sessionId, campaignId);
        }

        public object[] GetBannerDailyStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return svc.GetBannerDailyStatistics(sessionId, bannerId, startDate, endDate);
        }

        public object[] GetBannerPublisherStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return svc.GetBannerPublisherStatistics(sessionId, bannerId, startDate, endDate);
        }

        public object[] GetBannerZoneStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return svc.GetBannerZoneStatistics(sessionId, bannerId, startDate, endDate);
        }

        public BannerTargeting[] GetBannerTargeting(int bannerId) {
            return svc.GetBannerTargeting(sessionId, bannerId);
        }

        public void SetBannerTargeting(int bannerId, BannerTargeting[] targeting) {
            svc.SetBannerTargeting(sessionId, bannerId, targeting);
        }
    }
}