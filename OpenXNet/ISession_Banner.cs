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
        Banner AddBanner(Banner banner);
        void DeleteBanner(int bannerId);
        void ModifyBanner(Banner banner);
        Banner GetBanner(int bannerId);
        Banner[] GetBannersByCampaign(int campaignId);
        DailyStats[] GetBannerDailyStatistics(int bannerId, DateTime startDate, DateTime endDate);
        PublisherStats[] GetBannerPublisherStatistics(int bannerId, DateTime startDate, DateTime endDate);
        object[] GetBannerZoneStatistics(int bannerId, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Gets banner targeting information.
        /// See https://developer.openx.org/wiki/display/API/OpenX+API+Targeting
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="bannerId"></param>
        /// <returns></returns>
        BannerTargeting[] GetBannerTargeting(int bannerId);

        /// <summary>
        /// Sets banner targeting information
        /// See https://developer.openx.org/wiki/display/API/OpenX+API+Targeting
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="bannerId"></param>
        /// <param name="targeting"></param>
        void SetBannerTargeting(int bannerId, BannerTargeting[] targeting);        
    }
}