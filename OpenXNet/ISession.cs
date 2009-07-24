using System;

namespace OpenXNet {
    public interface ISession: IDisposable {
        void AddBanner(Banner banner);
        void AddCampaign(Campaign campaign);
        void AddAdvertiser(Advertiser advertiser);
    }
}