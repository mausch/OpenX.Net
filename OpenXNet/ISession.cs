using System;

namespace OpenXNet {
    public interface ISession: IDisposable {
        IOpenXService Svc { get; }
        string SessionId { get; }
    }
}