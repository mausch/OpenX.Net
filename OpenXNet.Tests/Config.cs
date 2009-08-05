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
using System.Configuration;

namespace OpenXNet.Tests {
    public class Config {
        private static string GetFromConfigOrThrow(string key) {
            var v = ConfigurationManager.AppSettings[key];
            if (v == null)
                throw new Exception(string.Format("Please define the key '{0}' in your app.config's appSettings", key));
            return v;
        }

        public static string Username {
            get { return GetFromConfigOrThrow("openx.username"); }
        }

        public static string Password {
            get { return GetFromConfigOrThrow("openx.password"); }
        }

        public static string Url {
            get { return GetFromConfigOrThrow("openx.url"); }
        }
    }
}