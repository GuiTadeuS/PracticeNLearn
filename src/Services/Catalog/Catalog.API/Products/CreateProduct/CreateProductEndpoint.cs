namespace Catalog.API.Products.CreateProduct 
{
    public record CreateProductRequest(string Name, List<string> Category, string Description, decimal Price, string ImageFile);
    public record CreateProductResponse(Guid Id);
    public class CreateProductEndpoint : ICarterModule // Presentation Layer (Endpoints)
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/products",
                async (CreateProductRequest request, ISender sender) =>
            {
                var command = request.Adapt<CreateProductCommand>(); // Convert from request to command

                var result = await sender.Send(command);

                var response = result.Adapt<CreateProductResponse>(); // Convert from result to response

                return Results.Created($"/products/{response.Id}", response);
            })
            .WithName("CreateProduct")
            .Produces<CreateProductResponse>(201)
            .ProducesProblem(400)
            .WithSummary("Create a new product")
            .WithDescription("Create a new product");
        }
    }
}
