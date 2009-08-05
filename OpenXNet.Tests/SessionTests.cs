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