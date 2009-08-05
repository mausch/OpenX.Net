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
    public class SessionTests {
        [Test]
        public void AddAdvertiser() {
            using (var session = NewSession()) {
                var advertiser = new Advertiser {AdvertiserName = "Fulano-" + Guid.NewGuid()};
                //session.AddAdvertiser(advertiser);
                Console.WriteLine(advertiser.Id);
            }
        }

        [Test]
        public void AddCampaign() {
            using (var session = NewSession()) {
                //session.AddCampaign(new Campaign());
            }
        }

        private SessionImpl NewSession() {
            return new SessionImpl(Config.Username, Config.Password, Config.Url);
        }
    }
}