using MediatR;

namespace Application.Products.Create
{
    public class CreateProductCommand : IRequest<ErrorOr<Guid>>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
