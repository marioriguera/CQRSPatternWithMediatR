using Application.Products.Common;

namespace Application.Products.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ErrorOr<ProductResponse>>
    {
        // private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(/*IProductRepository productRepository*/)
        {
            // _productRepository = productRepository;
        }

        public async Task<ErrorOr<ProductResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            // return await _productRepository.GetByIdAsync(request.Id,cancellationToken);
            ProductResponse product = new()
            {
                Id = request.Id,
                Name = "algo name",
                Price = 125
            };

            return await Task.FromResult(product);
        }
    }
}
