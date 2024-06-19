namespace Application.Abstractions
{
    public interface IQuery<TResponse>
        : IRequest<ErrorOr<TResponse>>
    {
    }
}
