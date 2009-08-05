#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

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