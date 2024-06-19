namespace Application.Products.Create
{
    public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(3);

            RuleFor(r => r.Price)
                .NotEmpty()
                .GreaterThan(1);
        }
    }
}
