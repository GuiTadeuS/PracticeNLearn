using MediatR;

namespace BuildingBlocks.CQRS
{
    // If it doesn't return anything, it will return Unit (void)
    public interface ICommandHandler<in TCommand>
        : ICommandHandler<TCommand, Unit> 
        where TCommand : ICommand<Unit> 
    { 
    }

    // If it returns something, it will return TResponse
    public interface ICommandHandler<in TCommand, TResponse> 
        : IRequestHandler<TCommand, TResponse> 
        where TCommand : ICommand<TResponse>
        where TResponse : notnull
        // This all means that ICommandHandler is a generic interface that takes in a TCommand and TResponse. The where clause specifies that TCommand must be of type ICommand<TResponse> and TResponse must be of type notnull
    {
    }
}
