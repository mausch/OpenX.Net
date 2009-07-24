using MbUnit.Framework;

namespace OpenXNet {
    [TestFixture]
    public class SessionTests {
        [Test]
        public void AddAdvertiser() {
            using (var session = NewSession()) {
                session.AddAdvertiser(new Advertiser {AdvertiserName = "Fulano"});
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