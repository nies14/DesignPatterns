public record GetProductQuery(int Id) : IRequest<Product>;

public class GetProductHandler : IRequestHandler<GetProductQuery, Product>
{
    public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Product { Id = request.Id, Name = "Laptop" });
    }
}


// Usage
var product = await mediator.Send(new GetProductQuery(1));
