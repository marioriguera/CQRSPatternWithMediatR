namespace Application.Abstractions
{
    public interface ICommand: IRequest<Error> // ToDo: Revisar si puede responder un Error.
    {
    }

    public interface ICommand<TResponse>
        : IRequest<ErrorOr<TResponse>>
    {
    }
}
