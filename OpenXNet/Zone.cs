using CookComputing.XmlRpc;

namespace OpenXNet {
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class Zone {
        [XmlRpcMember("zoneId")]
        public int Id { get; set; }

        [XmlRpcMember("zoneName")]
        public string ZoneName { get; set; }

        [XmlRpcMember("width")]
        public int Width { get; set; }

        [XmlRpcMember("height")]
        public int Height { get; set; }

        [XmlRpcMember("publisherId")]
        public int PublisherId { get; set; }

        [XmlRpcMember("capping")]
        public int Capping { get; set; }

        [XmlRpcMember("sessionCapping")]
        public int SessionCapping { get; set; }

        [XmlRpcMember("block")]
        public int Block { get; set; }

        [XmlRpcMember("comments")]
        public string Comments { get; set; }

        [XmlRpcMember("type")]
        public ZoneType Type { get; set; }
    }
}