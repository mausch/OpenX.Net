using MbUnit.Framework;

namespace OpenXNet.Tests {
    [TestFixture]
    public class RepositoryTests {
        [Test]
        public void BannerRepository() {
            using (var session = new SessionImpl("root", "root", "http://10.0.0.62/openx/api/v2/xmlrpc/")) {
                var bannerRepo = new BannerRepository(session);
                var banner = bannerRepo.Get(1);
            }
        }
    }
}