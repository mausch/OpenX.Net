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