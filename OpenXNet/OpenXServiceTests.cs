using System;
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
                svc.AddBanner(sessionId, new Banner());
            });
        }

        [Test]
        public void AddCampaign() {
            WithSession((sessionId, svc) => {
                svc.AddCampaign(sessionId, new Campaign());
            });
        }

        [Test]
        public void GetCampaignStats() {
            WithSession((sessionId, svc) => {
                svc.GetCampaignBannerStatistics(sessionId, 1, new DateTime(1980, 1, 1), DateTime.Now);
            });
        }

        [Test]
        public void GetCampaignStatsDaily() {
            WithSession((sessionId, svc) => {
                svc.GetCampaignDailyStatistics(sessionId, 1, new DateTime(1980, 1, 1), DateTime.Now);
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
            return svc;
        }
    }
}