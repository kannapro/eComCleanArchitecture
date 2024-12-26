using Product.Domain.Repositories;
using Product.Domain.UOM;
using Product.Persistence.Data;

namespace Product.Persistence;

public class UnitOfWork(
  ApplicationDbContext dbContext,
  IBrandRepository brandRepository,
  ICategoryRepository categoryRepository,
  IProductAttributeRepository productAttributeRepository,
  IProductImageRepository productImageRepository,
  IProductRepository productRepository
  ) : IUnitOfWork
{
  public IBrandRepository Brands => brandRepository;

  public ICategoryRepository Categories => categoryRepository;

  public IProductAttributeRepository ProductAttributes => productAttributeRepository;

  public IProductImageRepository ProductImages => productImageRepository;

  public IProductRepository Products => productRepository;
  public void Dispose()
  {
    dbContext.Dispose();
  }

  public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
  {
    return await dbContext.SaveChangesAsync();
  }
}