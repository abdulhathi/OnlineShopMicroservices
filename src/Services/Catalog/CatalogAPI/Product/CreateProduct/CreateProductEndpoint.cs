using Carter;

public record CreateProductRequest(string Name, List<string> Categories, string Description, string ImageFile, decimal Price);

public record CreateProductResponse(Guid Id);

public class CreateProductEndpoint : ICarterModule
{
  public void AddRoutes(IEndpointRouteBuilder app)
  {
    throw new NotImplementedException();
  }
}