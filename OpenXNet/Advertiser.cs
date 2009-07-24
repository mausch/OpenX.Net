using CookComputing.XmlRpc;

namespace OpenXNet {
    public class Advertiser {
        [XmlRpcMember("advertiserName")]
        public string Name { get; set; }
    }
}