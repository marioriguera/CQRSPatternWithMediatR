using Application.Abstractions;
using Application.Products.Common;

namespace Application.Products.GetAll
{
    /// <summary>
    /// Represents a query to get all products.
    /// </summary>
    public sealed record GetAllProductsQuery() : IQuery<IReadOnlyList<ProductResponse>>;
}
