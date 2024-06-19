namespace Application.Abstractions
{
    public interface ICommandHandler<TCommand>
            : IRequestHandler<TCommand, Error>
                where TCommand : ICommand // ToDo: Revisar si puede responder un Error.
    {
    }

    public interface ICommandHandler<TCommand, TResponse>
            : IRequestHandler<TCommand, ErrorOr<TResponse>>
                where TCommand : ICommand<TResponse>;
}
