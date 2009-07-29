using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial interface IOpenXProxy {
        [XmlRpcMethod("ox.addUser")]
        int AddUser(string sessionId, User user);

        [XmlRpcMethod("ox.deleteUser")]
        void DeleteUser(string sessionId, int userId);

        [XmlRpcMethod("ox.getUser")]
        User GetUser(string sessionId, int userId);

        [XmlRpcMethod("ox.modifyUser")]
        void ModifyUser(string sessionId, User user);

        [XmlRpcMethod("ox.getUserListByAccountId")]
        User[] GetUsersByAccount(string sessionId, int accountId);

        [XmlRpcMethod("ox.updateSsoUserId")]
        void UpdateSsoUserId(string sessionId, int oldSsoUserId, int newSsoUserId);

        [XmlRpcMethod("ox.updateUserEmailBySsoId")]
        void UpdateUserEmailBySsoId(string sessionId, int ssoUserId, string email);
    }
}