using Application.Products.Common;

namespace Application.Products.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ErrorOr<Guid>>
    {
        //private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(/*IProductRepository productRepository*/)
        {
            //_productRepository = productRepository;
        }

        public async Task<ErrorOr<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new ProductResponse
            {
                Name = request.Name,
                Price = request.Price,
                Id = Guid.NewGuid(),
            };

            // await _productRepository.AddAsync(product, cancellationToken);
            // await _productRepository.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }
}
