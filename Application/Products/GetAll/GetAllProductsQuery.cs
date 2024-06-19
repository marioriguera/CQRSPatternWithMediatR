using Application.Products.Common;

namespace Application.Products.GetAll
{
    public record GetAllProductsQuery() : IRequest<ErrorOr<IReadOnlyList<ProductResponse>>>;
}
