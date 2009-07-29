using System;

namespace OpenXNet {
    public interface ISession: IDisposable {
        void AddBanner(BannerWithImages banner);
        void AddCampaign(Campaign campaign);
        void AddAdvertiser(Advertiser advertiser);
    }
}