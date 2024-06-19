using Application.Abstractions;
using Application.Products.Common;
using Domain.Repositories;

namespace Application.Products.GetAll
{
    public class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, IReadOnlyList<ProductResponse>>
    {
        private readonly IProductRepository _productsRepository;
        public GetAllProductsQueryHandler(IProductRepository productRepository) => _productsRepository = productRepository;

        public async Task<ErrorOr<IReadOnlyList<ProductResponse>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var allProductsResult = await _productsRepository.GetAllAsync(cancellationToken);

            List<ProductResponse> responses = new();
            foreach (var item in allProductsResult)
            {
                responses.Add(new ProductResponse(item.Id, item.Name, item.Price));
            }

            return responses;
        }
    }
}
