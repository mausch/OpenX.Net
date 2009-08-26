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
using MbUnit.Framework;

namespace OpenXNet.Tests {
    public class AdvertiserStatsTests : BaseSessionTests {
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
                    Console.WriteLine("Revenue: {0}", ((decimal) stat.Revenue).ToString("C"));
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
                    Console.WriteLine("Revenue: {0}", ((decimal) stat.Revenue).ToString("C"));
                }
            }
        }

        [Test]
        public void AdvertiserCampaignStatistics() {
            using (var session = NewSession()) {
                var r = session.GetAdvertiserCampaignStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine("got {0} stats", r.Length);
                foreach (var stat in r) {
                    Console.WriteLine("Campaign {0}: {1}", stat.CampaignId, stat.CampaignName);
                    Console.WriteLine("Impressions: {0}", stat.Impressions);
                    Console.WriteLine("Clicks: {0}", stat.Impressions);
                    Console.WriteLine("Requests: {0}", stat.Requests);
                    Console.WriteLine("Revenue: {0}", ((decimal) stat.Revenue).ToString("C"));
                }
            }
        }

        [Test]
        public void AdvertiserPublisherStatistics() {
            using (var session = NewSession()) {
                var r = session.GetAdvertiserPublisherStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine("got {0} stats", r.Length);
                foreach (var stat in r) {
                    Console.WriteLine("Publisher {0}: {1}", stat.PublisherId, stat.PublisherName);
                    Console.WriteLine("Impressions: {0}", stat.Impressions);
                    Console.WriteLine("Clicks: {0}", stat.Impressions);
                    Console.WriteLine("Requests: {0}", stat.Requests);
                    Console.WriteLine("Revenue: {0}", ((decimal) stat.Revenue).ToString("C"));
                }
            }
        }

        [Test]
        public void AdvertiserZoneStatistics() {
            using (var session = NewSession()) {
                var r = session.GetAdvertiserZoneStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine("got {0} stats", r.Length);
                foreach (var stat in r) {
                    Console.WriteLine("Publisher {0}: {1}", stat.PublisherId, stat.PublisherName);
                    Console.WriteLine("Zone {0}: {1}", stat.ZoneId, stat.ZoneName);
                    Console.WriteLine("Impressions: {0}", stat.Impressions);
                    Console.WriteLine("Clicks: {0}", stat.Impressions);
                    Console.WriteLine("Requests: {0}", stat.Requests);
                    Console.WriteLine("Revenue: {0}", ((decimal) stat.Revenue).ToString("C"));
                }
            }
        }
    }
}