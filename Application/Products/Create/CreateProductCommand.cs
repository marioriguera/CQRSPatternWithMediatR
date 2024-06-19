using Application.Abstractions;

namespace Application.Products.Create
{
    public sealed record CreateProductCommand(string Name, decimal Price) 
        : ICommand<Guid>;
}
