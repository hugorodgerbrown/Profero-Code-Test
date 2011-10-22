﻿namespace Profero.Interview.Business.Core
{
    public interface IWorkflow<TRequest, TResponse>
    {
        TResponse Invoke(TRequest request);
    }
}