using Ecom.Shared;
namespace Product.Domain.DomainEvents.Product;

public sealed record class ProductDeletedDomainEvent(Guid ProductId) : IDomainEvent;
