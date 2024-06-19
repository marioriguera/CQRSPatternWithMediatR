using Application.Abstractions;
using Application.Products.Common;

namespace Application.Products.GetById
{
    public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, ProductResponse>
    {
        // private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(/*IProductRepository productRepository*/)
        {
            // _productRepository = productRepository;
        }

        public async Task<ErrorOr<ProductResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            // return await _productRepository.GetByIdAsync(request.Id,cancellationToken);
            ProductResponse product = new(request.Id, "algo mas", 123);

            return await Task.FromResult(product);
        }
    }
}
