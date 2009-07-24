using CookComputing.XmlRpc;

namespace OpenXNet {
    public class Campaign {
        [XmlRpcMember("advertiserId")]
        public int AdvertiserId { get; set; }
    }
}