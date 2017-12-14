﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;



namespace VstsServerTaskHelper
{
    public interface IVstsScheduleHandler<T> 
        where T : VstsMessage
    {
        Task<VstsScheduleResult> Execute(T vstsMessage, IDictionary<string,string> eventProperties, CancellationToken cancellationToken);

        Task<string> Cancel(T vstsMessage, CancellationToken cancellationToken);
    }
}