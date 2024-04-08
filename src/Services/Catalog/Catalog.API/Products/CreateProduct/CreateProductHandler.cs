using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    // DTO
    public record CreateProductCommand(string Name, List<string> Categories, string Description, decimal Price, string ImageFile) : IRequest<CreateProductResult> ;
    // Record because it's immutable - DTO
    public record CreateProductResult(Guid Id);
    // Application Layer (Use Cases)
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    { 
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
