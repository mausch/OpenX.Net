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
using System.IO;
using CookComputing.XmlRpc;

namespace OpenXNet.Tests {
    public class BaseSessionTests {
        protected SessionImpl NewSession() {
            var proxy = XmlRpcProxyGen.Create<IOpenXProxy>();
            proxy.Url = Config.Url;
            proxy.ResponseEvent += proxy_ResponseEvent;
            proxy.RequestEvent += proxy_RequestEvent;
            return new SessionImpl(proxy, Config.Username, Config.Password);
        }

        private void PrintStream(Stream s) {
            using (var sw = new StreamReader(s))
                Console.WriteLine(sw.ReadToEnd());
        }

        private void proxy_RequestEvent(object sender, XmlRpcRequestEventArgs args) {
            PrintStream(args.RequestStream);
        }

        private void proxy_ResponseEvent(object sender, XmlRpcResponseEventArgs args) {
            PrintStream(args.ResponseStream);
        }
    }
}