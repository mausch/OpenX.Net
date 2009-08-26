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
using System.Linq;
using MbUnit.Framework;

namespace OpenXNet.Tests {
    [TestFixture]
    public class SessionTests: BaseSessionTests {
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
    }
}