using System;
using System.IO;
using CookComputing.XmlRpc;
using MbUnit.Framework;

namespace OpenXNet {
    [TestFixture]
    public class OpenXServiceTests {
        [Test]
        public void Login_OK() {
            var svc = GetSvc();
            var sessionId = svc.Logon("root", "root");
            Console.WriteLine(sessionId);
            svc.Logoff(sessionId);
        }

        [Test]
        [ExpectedException(typeof (XmlRpcFaultException))]
        public void Login_error() {
            var svc = GetSvc();
            svc.Logon("root", "rootasd");
        }

        [Test]
        [ExpectedException(typeof (XmlRpcFaultException))]
        public void AddBanner_no_login() {
            var svc = GetSvc();
            svc.AddBanner("", new Banner());
        }

        [Test]
        public void Login_and_add_banner() {
            WithSession((sessionId, svc) => {
                var id = svc.AddBanner(sessionId, new Banner {
                    CampaignId = 1,
                    BannerName = "some banner " + Guid.NewGuid(),
                    Width = 728,
                    Height = 90,
                    Url = "http://www.google.com",
                    StorageType = "sql",
                    Image = new BannerImage(@"..\..\banners\728x90_web_banner_example.gif"),
                });
                Console.WriteLine(id);
            });
        }

        [Test]
        public void AddCampaign() {
            WithSession((sessionId, svc) => { svc.AddCampaign(sessionId, new Campaign()); });
        }

        [Test]
        public void GetCampaignStats() {
            WithSession((sessionId, svc) => {
                var list = svc.GetCampaignBannerStatistics(sessionId, 1, new DateTime(1980, 1, 1), DateTime.Now);
                Console.WriteLine(list.Length);
            });
        }

        [Test]
        public void GetCampaignStatsDaily() {
            WithSession((sessionId, svc) => {
                var list = svc.GetCampaignDailyStatistics(sessionId, 1, new DateTime(1980, 1, 1), DateTime.Now);
                Console.WriteLine(list.Length);
            });
        }

        [Test]
        public void GetCampaignList() {
            WithSession((sessionId, svc) => {
                var list = svc.GetCampaignListByAdvertiser(sessionId, 1);
                foreach (var a in list)
                    Console.WriteLine(a.CampaignName);
            });
        }

        [Test]
        public void GetCampaignPublisherStats() {
            WithSession((sessionId, svc) => {
                var list = svc.GetCampaignPublisherStatistics(sessionId, 1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(list.Length);
            });
        }

        [Test]
        public void ListMethods() {
            var svc = GetSvc();
            foreach (var m in svc.SystemListMethods())
                Console.WriteLine(m);
        }

        public void WithSession(Action<string, IOpenXService> a) {
            var svc = GetSvc();
            var sessionId = svc.Logon("root", "root");
            try {
                a(sessionId, svc);
            } finally {
                svc.Logoff(sessionId);
            }
        }

        private IOpenXService GetSvc() {
            var svc = XmlRpcProxyGen.Create<IOpenXService>();
            svc.Url = "http://10.0.0.62/openx/api/v2/xmlrpc/";
            svc.ResponseEvent += svc_ResponseEvent;
            svc.RequestEvent += svc_RequestEvent;
            return svc;
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
    }
}