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
using System.IO;
using CookComputing.XmlRpc;
using MbUnit.Framework;

namespace OpenXNet.Tests {
    [TestFixture]
    public class OpenXServiceTests {
        [Test]
        public void Login_OK() {
            var svc = GetSvc();
            var sessionId = svc.Logon(Config.Username, Config.Password);
            Console.WriteLine(sessionId);
            svc.Logoff(sessionId);
        }

        [Test]
        [ExpectedException(typeof (XmlRpcFaultException))]
        public void Login_error() {
            var svc = GetSvc();
            svc.Logon(Config.Username, Config.Password + "asd");
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
                var banner = svc.GetBanner(sessionId, id);
                svc.DeleteBanner(sessionId, id);
            });
        }

        [Test]
        public void GetBanners() {
            WithSession((sessionId, svc) => {
                var manager = svc.GetManagers(sessionId)[0];
                var advertiser = svc.GetAdvertisersByManager(sessionId, manager.Id)[0];
                var campaign = svc.GetCampaignsByAdvertiser(sessionId, advertiser.Id)[0];
                var banner = svc.GetBannersByCampaign(sessionId, campaign.Id)[0];
                var stats = svc.GetBannerDailyStatistics(sessionId, banner.Id, DateTime.Now.AddYears(-1), DateTime.Now);
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
                var list = svc.GetCampaignsByAdvertiser(sessionId, 1);
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

        public void WithSession(Action<string, IOpenXProxy> a) {
            var svc = GetSvc();
            var sessionId = svc.Logon(Config.Username, Config.Password);
            try {
                a(sessionId, svc);
            } finally {
                svc.Logoff(sessionId);
            }
        }

        private IOpenXProxy GetSvc() {
            var svc = XmlRpcProxyGen.Create<IOpenXProxy>();
            svc.Url = Config.Url;
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