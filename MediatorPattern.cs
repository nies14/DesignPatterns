public record CreateOrderCommand(string ProductName) : IRequest<bool>;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, bool>
{
    public Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Order created for {request.ProductName}");
        return Task.FromResult(true);
    }
}


// Usage
var mediator = new Mediator(...);
await mediator.Send(new CreateOrderCommand("Laptop"));
