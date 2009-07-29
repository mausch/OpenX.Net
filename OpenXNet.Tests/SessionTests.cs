using System;
using MbUnit.Framework;

namespace OpenXNet {
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
        public void AddCampaign() {
            using (var session = NewSession()) {
                session.AddCampaign(new Campaign());
            }
        }

        private SessionImpl NewSession() {
            return new SessionImpl("root", "root", "http://10.0.0.62/openx/api/v2/xmlrpc/");
        }
    }
}