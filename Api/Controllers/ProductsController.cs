using Application.Products.Common;
using Application.Products.Create;
using Application.Products.GetAll;
using Application.Products.GetById;

namespace Api.Controllers
{
    [Route("api/products")]
    public class ProductsController : ApiController
    {
        public ProductsController(ISender mediator)
            : base(mediator)
        {
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));

            return product.Match(
                product => Ok(product),
                errors => Problem(errors));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var productsResult = await _mediator.Send(new GetAllProductsQuery());

            return productsResult.Match(
                products => Ok(products),
                errors => Problem(errors));
        }

        [HttpPost("create-product")]
        public async Task<IActionResult> CreateProduct(CreateProductRequest request)
        {
            var createProductResult = await _mediator.Send(new CreateProductCommand(request.Name, request.Price));
            return createProductResult.Match(
                    productId => Ok(productId),
                    errors => Problem(errors)
                );
        }
    }
}
