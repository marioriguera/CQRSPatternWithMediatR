using Domain.Products;
using MediatR;

namespace Application.Products.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        // private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(/*IProductRepository productRepository*/)
        {
            // _productRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            // return await _productRepository.GetByIdAsync(request.Id,cancellationToken);
            Product product = new()
            {
                Id = request.Id,
                Name = "algo name",
                Price = 125
            };
            return await Task.FromResult(product);
        }
    }
}
