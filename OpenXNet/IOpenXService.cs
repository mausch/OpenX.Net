using CookComputing.XmlRpc;

namespace OpenXNet {
    public interface IOpenXService : IXmlRpcProxy {
        [XmlRpcMethod("ox.logon")]
        string Logon(string username, string password);
    }
}