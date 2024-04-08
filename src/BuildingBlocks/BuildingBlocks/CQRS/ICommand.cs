using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface IComand : ICommand<Unit> // Basially an empty interface - Does not return anything
    {
    }
    public interface ICommand<out TResponse> : IRequest<TResponse> // It returns a response of type TResponse. Its specified in the part "out TResponse"
    {
    }
}
