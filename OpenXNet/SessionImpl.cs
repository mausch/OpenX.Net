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

using System;
using System.Net.Sockets;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public partial class SessionImpl : ISession {
        private readonly IOpenXProxy svc;
        private readonly string sessionId;
        private readonly bool ownsSession;

        public SessionImpl(string sessionId, string url) {
            this.sessionId = sessionId;
            svc = XmlRpcProxyGen.Create<IOpenXProxy>();
            svc.Url = url;
            ownsSession = false;
        }

        public SessionImpl(string username, string password, string url) {
            svc = XmlRpcProxyGen.Create<IOpenXProxy>();
            svc.Url = url;
            try {
                sessionId = svc.Logon(username, password);
                ownsSession = true;
            } catch (SocketException e) {
                throw new Exception(string.Format("Unable to connect to OpenX server at {0}", url), e);
            }
        }

        public SessionImpl(IOpenXProxy proxy, string username, string password) {
            svc = proxy;
            try {
                sessionId = svc.Logon(username, password);
                ownsSession = true;
            } catch (SocketException e) {
                throw new Exception("Unable to connect to OpenX server", e);
            }
        }

        public void Dispose() {
            if (ownsSession)
                svc.Logoff(sessionId);
        }
    }
}