using Ecom.Shared;

namespace Product.Domain.DomainEvents.Brand;

public sealed record class BrandDeletedDomainEvent(Guid BrandId) : IDomainEvent;