﻿using Application.Abstractions;
using Application.Products.Common;

namespace Application.Products.Create
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid>
    {
        //private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(/*IProductRepository productRepository*/)
        {
            //_productRepository = productRepository;
        }

        public async Task<ErrorOr<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new ProductResponse(Guid.NewGuid(), request.Name, request.Price);

            // await _productRepository.AddAsync(product, cancellationToken);
            // await _productRepository.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }
}
