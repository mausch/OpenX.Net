using System;

namespace OpenXNet {
    public interface ISession: IDisposable {
        IOpenXProxy Svc { get; }
        string SessionId { get; }
    }
}