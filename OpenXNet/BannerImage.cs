using System.IO;
using CookComputing.XmlRpc;

namespace OpenXNet {
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class BannerImage {
        [XmlRpcMember("filename")]
        public string Filename { get; set; }

        [XmlRpcMember("content")]
        public byte[] Content { get; set; }

        public BannerImage() {}

        public BannerImage(string filename) {
            Filename = Path.GetFileName(filename);
            Content = File.ReadAllBytes(filename);
        }
    }
}