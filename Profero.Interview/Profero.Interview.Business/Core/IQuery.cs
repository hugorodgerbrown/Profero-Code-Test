namespace Profero.Interview.Business.Core
{
    public interface IQuery<TRequest, TResponse> : IWorkflow<TRequest, TResponse>
    {
    }
}