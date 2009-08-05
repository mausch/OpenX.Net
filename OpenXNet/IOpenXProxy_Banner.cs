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
        [XmlRpcMethod("ox.addBanner")]
        int AddBanner(string sessionId, Banner banner);

        [XmlRpcMethod("ox.deleteBanner")]
        void DeleteBanner(string sessionId, int bannerId);

        [XmlRpcMethod("ox.modifyBanner")]
        void ModifyBanner(string sessionId, Banner banner);

        [XmlRpcMethod("ox.getBanner")]
        Banner GetBanner(string sessionId, int bannerId);

        [XmlRpcMethod("ox.getBannerListByCampaignId")]
        Banner[] GetBannersByCampaign(string sessionId, int campaignId);

        [XmlRpcMethod("ox.bannerDailyStatistics")]
        object[] GetBannerDailyStatistics(string sessionId, int bannerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.bannerPublisherStatistics")]
        object[] GetBannerPublisherStatistics(string sessionId, int bannerId, DateTime startDate, DateTime endDate);

        [XmlRpcMethod("ox.bannerZoneStatistics")]
        object[] GetBannerZoneStatistics(string sessionId, int bannerId, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Gets banner targeting information.
        /// See https://developer.openx.org/wiki/display/API/OpenX+API+Targeting
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="bannerId"></param>
        /// <returns></returns>
        [XmlRpcMethod("ox.getBannerTargeting")]
        BannerTargeting[] GetBannerTargeting(string sessionId, int bannerId);

        /// <summary>
        /// Sets banner targeting information
        /// See https://developer.openx.org/wiki/display/API/OpenX+API+Targeting
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="bannerId"></param>
        /// <param name="targeting"></param>
        [XmlRpcMethod("ox.setBannerTargeting")]
        void SetBannerTargeting(string sessionId, int bannerId, BannerTargeting[] targeting);
    }
}