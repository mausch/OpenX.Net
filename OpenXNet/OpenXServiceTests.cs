using System;
using CookComputing.XmlRpc;
using MbUnit.Framework;

namespace OpenXNet {
    [TestFixture]
    public class OpenXServiceTests {
        [Test]
        public void Login_OK() {
            var svc = GetSvc();
            var sessionId = svc.Logon("root", "root");
            Console.WriteLine(sessionId);
            svc.Logoff(sessionId);
        }

        [Test]
        [ExpectedException(typeof (XmlRpcFaultException))]
        public void Login_error() {
            var svc = GetSvc();
            svc.Logon("root", "rootasd");
        }

        [Test]
        [ExpectedException(typeof(XmlRpcFaultException))]
        public void AddBanner_no_login() {
            var svc = GetSvc();
            svc.AddBanner("", new Banner());
        }

        [Test]
        public void Login_and_add_banner() {
            var svc = GetSvc();
            var sessionId = svc.Logon("root", "root");
            try {
                svc.AddBanner(sessionId, new Banner());                
            } finally {
                svc.Logoff(sessionId);
            }
        }

        [Test]
        public void AddCampaign() {
            var svc = GetSvc();
            var sessionId = svc.Logon("root", "root");
            try {
                svc.AddBanner(sessionId, new Banner());
            } finally {
                svc.Logoff(sessionId);
            }            
        }

        private IOpenXService GetSvc() {
            var svc = XmlRpcProxyGen.Create<IOpenXService>();
            svc.Url = "http://10.0.0.62/openx/api/v2/xmlrpc/";
            return svc;
        }
    }
}