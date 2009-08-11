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

namespace OpenXNet {
    public partial interface ISession {
        User AddUser(User user);

        void DeleteUser(int userId);

        User GetUser(int userId);

        void ModifyUser(User user);

        User[] GetUsersByAccount(int accountId);

        void UpdateSsoUserId(int oldSsoUserId, int newSsoUserId);

        void UpdateUserEmailBySsoId(int ssoUserId, string email);
    }
}