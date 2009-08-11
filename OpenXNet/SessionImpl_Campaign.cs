﻿#region license
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
        public int AddCampaign(Campaign campaign) {
            var id = svc.AddCampaign(sessionId, campaign);
            campaign.Id = id;
            return id;
        }

        public Campaign GetCampaign(int campaignId) {
            return svc.GetCampaign(sessionId, campaignId);
        }

        public void DeleteCampaign(int campaignId) {
            svc.DeleteCampaign(sessionId, campaignId);
        }

        public void ModifyCampaign(Campaign campaign) {
            svc.ModifyCampaign(sessionId, campaign);
        }

        public object[] GetCampaignBannerStatistics(int campaignId, DateTime startDate, DateTime endDate) {
            return svc.GetCampaignBannerStatistics(sessionId, campaignId, startDate, endDate);
        }

        public object[] GetCampaignDailyStatistics(int campaignId, DateTime startDate, DateTime endDate) {
            return svc.GetCampaignDailyStatistics(sessionId, campaignId, startDate, endDate);
        }

        public Campaign[] GetCampaignsByAdvertiser(int advertiserId) {
            return svc.GetCampaignsByAdvertiser(sessionId, advertiserId);
        }

        public object[] GetCampaignPublisherStatistics(int campaignId, DateTime startDate, DateTime endDate) {
            return svc.GetCampaignPublisherStatistics(sessionId, campaignId, startDate, endDate);
        }
    }
}