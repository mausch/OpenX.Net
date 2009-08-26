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
    public partial interface ISession : IDisposable {
        Advertiser AddAdvertiser(Advertiser advertiser);

        void DeleteAdvertiser(int advertiserId);

        Advertiser GetAdvertiser(int advertiserId);

        CampaignBannerStats[] GetAdvertiserBannerStatistics(int advertiserId, DateTime startDate, DateTime endDate);

        CampaignStats[] GetAdvertiserCampaignStatistics(int advertiserId, DateTime startDate, DateTime endDate);

        DailyStats[] GetAdvertiserDailyStatistics(int advertiserId, DateTime startDate, DateTime endDate);

        Advertiser[] GetAdvertisersByManager(int managerId);

        PublisherStats[] GetAdvertiserPublisherStatistics(int advertiserId, DateTime startDate, DateTime endDate);

        object[] GetAdvertiserZoneStatistics(int advertiserId, DateTime startDate, DateTime endDate);

        void ModifyAdvertiser(Advertiser advertiser);
    }
}