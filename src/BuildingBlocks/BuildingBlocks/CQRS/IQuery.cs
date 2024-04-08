using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull // This means that TResponse cannot be null. TResponse being in the "out" position means that it can only be returned from the method, not passed in.
    {
    }
}
