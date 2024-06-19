using Application.Abstractions;
using Domain.DomainEvents.Products;

namespace Application.Products.Create.Events
{
    internal sealed class CreateProductDomainEventHandler
        : IDomainEventHandler<ProductCreatedDomainEvent>
    {
        public async Task Handle(ProductCreatedDomainEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
