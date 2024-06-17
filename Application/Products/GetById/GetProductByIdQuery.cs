using Domain.Products;
using MediatR;

namespace Application.Products.GetById
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
