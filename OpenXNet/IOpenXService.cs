using CookComputing.XmlRpc;

namespace OpenXNet {
    public interface IOpenXService : IXmlRpcProxy {
        [XmlRpcMethod("ox.logon")]
        string Logon(string username, string password);

        [XmlRpcMethod("ox.logoff")]
        void Logoff(string sessionId);

        [XmlRpcMethod("ox.addBanner")]
        void AddBanner(string sessionId, Banner banner);
    }
}