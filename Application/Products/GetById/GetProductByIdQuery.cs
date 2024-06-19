using Application.Products.Common;

namespace Application.Products.GetById
{
    public record GetProductByIdQuery : IRequest<ErrorOr<ProductResponse>>
    {
        public Guid Id { get; set; }
    }
}
