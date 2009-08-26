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
using System.Linq;
using CookComputing.XmlRpc;
using MbUnit.Framework;

namespace OpenXNet.Tests {
    [TestFixture]
    public class SessionTests {
        [Test]
        public void AddAdvertiser() {
            using (var session = NewSession()) {
                var advertiser = new Advertiser {AdvertiserName = "Fulano-" + Guid.NewGuid()};
                session.AddAdvertiser(advertiser);
                Console.WriteLine(advertiser.Id);
            }
        }

        [Test]
        public void GetCampaign() {
            using (var session = NewSession()) {
                var adv = (from manager in session.GetManagers()
                           from advertiser in session.GetAdvertisersByManager(manager.Id)
                           from campaign in session.GetCampaignsByAdvertiser(advertiser.Id)
                           select campaign).First();
                if (adv != null)
                    Console.WriteLine(adv.CampaignName);
            }
        }

        [Test]
        public void AddCampaign() {
            using (var session = NewSession()) {
                var a = (from manager in session.GetManagers()
                         from advertiser in session.GetAdvertisersByManager(manager.Id)
                         select advertiser).First();
                var c = session.AddCampaign(new Campaign {
                    AdvertiserId = a.Id,
                    CampaignName = "campaign-" + Guid.NewGuid(),
                });
            }
        }

        [Test]
        public void AdvertiserDailyStats() {
            using (var session = NewSession()) {
                var r = session.GetAdvertiserDailyStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine("got {0} stats", r.Length);
                foreach (var stat in r) {
                    Console.WriteLine("Stats for day {0}:", stat.Day.ToShortDateString());
                    Console.WriteLine("Impressions: {0}", stat.Impressions);
                    Console.WriteLine("Clicks: {0}", stat.Impressions);
                    Console.WriteLine("Requests: {0}", stat.Requests);
                    Console.WriteLine("Revenue: {0}", ((decimal)stat.Revenue).ToString("C"));
                }
            }
        }

        [Test]
        public void AdvertiserBannerStatistics() {
            using (var session = NewSession()) {
                var r = session.GetAdvertiserBannerStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine("got {0} stats", r.Length);
                foreach (var stat in r) {
                    Console.WriteLine("Campaign {0}: {1}", stat.CampaignId, stat.CampaignName);
                    Console.WriteLine("Banner {0}: {1}", stat.BannerId, stat.BannerName);
                    Console.WriteLine("Impressions: {0}", stat.Impressions);
                    Console.WriteLine("Clicks: {0}", stat.Impressions);
                    Console.WriteLine("Requests: {0}", stat.Requests);
                    Console.WriteLine("Revenue: {0}", ((decimal)stat.Revenue).ToString("C"));
                }
            }
        }

        private SessionImpl NewSession() {
            var proxy = XmlRpcProxyGen.Create<IOpenXProxy>();
            proxy.Url = Config.Url;
            proxy.ResponseEvent += proxy_ResponseEvent;
            proxy.RequestEvent += proxy_RequestEvent;
            return new SessionImpl(proxy, Config.Username, Config.Password);
        }

        private void PrintStream(Stream s) {
            using (var sw = new StreamReader(s))
                Console.WriteLine(sw.ReadToEnd());
        }

        private void proxy_RequestEvent(object sender, XmlRpcRequestEventArgs args) {
            PrintStream(args.RequestStream);
        }

        private void proxy_ResponseEvent(object sender, XmlRpcResponseEventArgs args) {
            PrintStream(args.ResponseStream);
        }
    }
}