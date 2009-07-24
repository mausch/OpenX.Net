using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public class SessionImpl : ISession {
        private readonly IOpenXService svc;
        private readonly string sessionId;

        public SessionImpl(string username, string password, string url) {
            svc = XmlRpcProxyGen.Create<IOpenXService>();
            svc.Url = url;
            sessionId = svc.Logon(username, password);
        }

        public void Dispose() {
            svc.Logoff(sessionId);
        }

        public void AddBanner(Banner banner) {
            svc.AddBanner(sessionId, banner);
        }

        public void AddCampaign(Campaign campaign) {
            svc.AddCampaign(sessionId, campaign);
        }

        public void AddAdvertiser(Advertiser advertiser) {
            svc.AddAdvertiser(sessionId, advertiser);
        }
    }
}