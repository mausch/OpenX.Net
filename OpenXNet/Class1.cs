using System;
using CookComputing.XmlRpc;
using MbUnit.Framework;

namespace OpenXNet {
    [TestFixture]
    public class Class1 {
        [Test]
        public void Login_OK() {
            var svc = XmlRpcProxyGen.Create<IOpenXService>();
            svc.Url = "http://10.0.0.62/openx/api/v2/xmlrpc/";
            var sessionId = svc.Logon("root", "root");
            Console.WriteLine(sessionId);
        } 
        
        [Test]
        [ExpectedException(typeof(XmlRpcFaultException))]
        public void Login_error() {
            var svc = XmlRpcProxyGen.Create<IOpenXService>();
            svc.Url = "http://10.0.0.62/openx/api/v2/xmlrpc/";
            svc.Logon("root", "rootasd");
        }
    }
}