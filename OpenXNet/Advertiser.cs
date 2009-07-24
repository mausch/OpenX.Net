using CookComputing.XmlRpc;

namespace OpenXNet {
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class Advertiser {
        [XmlRpcMember("advertiserName")]
        public string AdvertiserName { get; set; }

        [XmlRpcMember("agencyId")]
        public int AgencyId { get; set; }

        [XmlRpcMember("contactName")]
        public string ContactName { get; set; }

        [XmlRpcMember("emailAddress")]
        public string Email { get; set; }

        [XmlRpcMember("username")]
        public string Username { get; set; }

        [XmlRpcMember("password")]
        public string Password { get; set; }
    }
}