using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, decimal Price, string ImageFile) 
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductHandler 
        : ICommandHandler<CreateProductCommand, CreateProductResult>
    { 
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = command.Name,
                Categories = command.Category,
                Description = command.Description,
                Price = command.Price,
                ImageFile = command.ImageFile
            };

            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
