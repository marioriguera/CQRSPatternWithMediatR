using Domain.Products;
using MediatR;

namespace Application.Products.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        //private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(/*IProductRepository productRepository*/)
        {
            //_productRepository = productRepository;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Id = 1
            };

            // await _productRepository.AddAsync(product, cancellationToken);
            // await _productRepository.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }
}
