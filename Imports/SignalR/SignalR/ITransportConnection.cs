﻿using System.Threading;
using System.Threading.Tasks;

namespace Raven.Imports.SignalR
{
    public interface ITransportConnection
    {
        Task<PersistentResponse> ReceiveAsync(CancellationToken timeoutToken);
        Task<PersistentResponse> ReceiveAsync(string messageId, CancellationToken timeoutToken);

        Task SendCommand(SignalCommand command);
    }
}