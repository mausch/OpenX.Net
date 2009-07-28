using CookComputing.XmlRpc;

namespace OpenXNet {
    public class Manager {
        [XmlRpcMember("agencyId")]
        public int Id { get; set; }

        [XmlRpcMember("accountId")]
        public int AccountId { get; set; }

        [XmlRpcMember("contactName")]
        public string ContactName { get; set; }

        [XmlRpcMember("emailAddress")]
        public string EmailAddress { get; set; }

        [XmlRpcMember("password")]
        public string Password { get; set; }
    }
}