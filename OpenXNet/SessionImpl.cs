using System;
using System.IO;
using CookComputing.XmlRpc;

namespace OpenXNet {
    public class SessionImpl : ISession {
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
            svc.ResponseEvent += svc_ResponseEvent;
            svc.RequestEvent += svc_RequestEvent;
            svc.Url = url;
            sessionId = svc.Logon(username, password);
            ownsSession = true;
        }

        private void svc_RequestEvent(object sender, XmlRpcRequestEventArgs args) {
            PrintStream(args.RequestStream);
        }

        private void PrintStream(Stream args) {
            using (var ts = new StreamReader(args))
                Console.WriteLine(ts.ReadToEnd());
        }

        private void svc_ResponseEvent(object sender, XmlRpcResponseEventArgs args) {
            PrintStream(args.ResponseStream);
        }

        public void Dispose() {
            if (ownsSession)
                svc.Logoff(sessionId);
        }

        public IOpenXProxy Svc {
            get { return svc; }
        }

        public string SessionId {
            get { return sessionId; }
        }
    }
}