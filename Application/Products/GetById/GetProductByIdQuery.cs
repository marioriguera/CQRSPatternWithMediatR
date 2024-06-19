using Application.Abstractions;
using Application.Products.Common;

namespace Application.Products.GetById
{
    /// <summary>
    /// Represents a query to get a product by its ID.
    /// </summary>
    /// <param name="Id">The unique identifier of the product.</param>
    public sealed record GetProductByIdQuery(Guid Id) : IQuery<ProductResponse>;
}
