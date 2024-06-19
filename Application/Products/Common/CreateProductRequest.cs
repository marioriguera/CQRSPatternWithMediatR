namespace Application.Products.Common
{
    public sealed record class CreateProductRequest(
        string Name,
        decimal Price
    );
}
