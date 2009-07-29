using CookComputing.XmlRpc;

namespace OpenXNet {
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class BannerWithImages : Banner {
        [XmlRpcMember("aImage")]
        public BannerImage Image { get; set; }
    }
}