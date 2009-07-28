using CookComputing.XmlRpc;

namespace OpenXNet {
    public class BannerImage {
        [XmlRpcMember("filename")]
        public string Filename { get; set; }

        [XmlRpcMember("content")]
        public byte[] Content { get; set; }
    }
}