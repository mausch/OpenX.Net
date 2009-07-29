using System;

namespace OpenXNet {
    public interface IBannerRepository : ICRUDRepository<Banner> {
        Banner[] GetBannersByCampaign(int campaignId);

        object[] GetBannerDailyStatistics(int bannerId, DateTime startDate, DateTime endDate);

        object[] GetBannerPublisherStatistics(int bannerId, DateTime startDate, DateTime endDate);

        object[] GetBannerZoneStatistics(int bannerId, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Gets banner targeting information.
        /// See https://developer.openx.org/wiki/display/API/OpenX+API+Targeting
        /// </summary>
        /// <param name="bannerId"></param>
        /// <returns></returns>
        BannerTargeting[] GetBannerTargeting(int bannerId);

        /// <summary>
        /// Sets banner targeting information
        /// See https://developer.openx.org/wiki/display/API/OpenX+API+Targeting
        /// </summary>
        /// <param name="bannerId"></param>
        /// <param name="targeting"></param>
        void SetBannerTargeting(int bannerId, BannerTargeting[] targeting);        
    }
}