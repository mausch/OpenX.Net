using System;
using System.IO;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public class SessionImpl : ISession {
        private readonly IOpenXService svc;
        private readonly string sessionId;

        public SessionImpl(string username, string password, string url) {
            svc = XmlRpcProxyGen.Create<IOpenXService>();
            svc.ResponseEvent += svc_ResponseEvent;
            svc.RequestEvent += svc_RequestEvent;
            svc.Url = url;
            sessionId = svc.Logon(username, password);
        }

        private void svc_RequestEvent(object sender, XmlRpcRequestEventArgs args) {
            PrintStream(args.RequestStream);
        }

        private void PrintStream(Stream args) {
            using (var ts = new StreamReader(args))
                Console.WriteLine(ts.ReadToEnd());
        }

        private void svc_ResponseEvent(object sender, XmlRpcResponseEventArgs args) {
            PrintStream(args.ResponseStream);
        }

        public void Dispose() {
            svc.Logoff(sessionId);
        }

        public void AddBanner(Banner banner) {
            svc.AddBanner(sessionId, banner);
        }

        public void AddCampaign(Campaign campaign) {
            var id = svc.AddCampaign(sessionId, campaign);
            campaign.Id = id;
        }

        public void AddAdvertiser(Advertiser advertiser) {
            var id = svc.AddAdvertiser(sessionId, advertiser);
            advertiser.Id = id;
        }
    }
}