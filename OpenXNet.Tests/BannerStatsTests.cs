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
    [TestFixture]
    public class BannerStatsTests : BaseSessionTests {
        [Test]
        public void BannerDailyStatistics() {
            using (var session = NewSession()) {
                var r = session.GetBannerDailyStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine("got {0} stats", r.Length);
                foreach (var stat in r) {
                    Console.WriteLine("Stats for day {0}:", stat.Day.ToShortDateString());
                    Console.WriteLine("Impressions: {0}", stat.Impressions);
                    Console.WriteLine("Clicks: {0}", stat.Clicks);
                    Console.WriteLine("Requests: {0}", stat.Requests);
                    Console.WriteLine("Revenue: {0}", ((decimal)stat.Revenue).ToString("C"));
                }
            }
        }
    }
}