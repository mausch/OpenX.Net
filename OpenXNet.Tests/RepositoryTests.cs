using MbUnit.Framework;

namespace OpenXNet.Tests {
    [TestFixture]
    public class RepositoryTests {
        [Test]
        public void BannerRepository() {
            using (var session = new SessionImpl(Config.Username, Config.Password, Config.Url)) {
                var bannerRepo = new BannerRepository(session);
                var banner = bannerRepo.Get(1);
            }
        }
    }
}