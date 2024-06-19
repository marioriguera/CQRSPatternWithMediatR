using Domain.Primitives;

namespace Domain.DomainEvents.Products
{
    public sealed record ProductCreatedDomainEvent(Guid Id) : IDomainEvent;
}
