using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXService : IXmlRpcProxy {
        [XmlRpcMethod("ox.logon")]
        string Logon(string username, string password);

        [XmlRpcMethod("ox.logoff")]
        void Logoff(string sessionId);

    }
}