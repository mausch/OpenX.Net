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