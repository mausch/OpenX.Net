using CookComputing.XmlRpc;

namespace OpenXNet {
    public class User {
        [XmlRpcMember("userId")]
        public int Id { get; set; }

        [XmlRpcMember("contactName")]
        public string ContactName { get; set; }

        [XmlRpcMember("defaultAccountId")]
        public int DefaultAccountId { get; set; }

        [XmlRpcMember("emailAddress")]
        public string EmailAddress { get; set; }

        [XmlRpcMember("username")]
        public string Username { get; set; }

        [XmlRpcMember("password")]
        public string Password { get; set; }

        [XmlRpcMember("active")]
        public bool Active { get; set; }
    }
}