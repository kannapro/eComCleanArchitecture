using System;
using Product.Service.Infrastructure;

namespace Product.Service;

public static class DependencyInjection
{
  public static IServiceCollection AddPresentation(this IServiceCollection services)
  {
    services.AddEndpointsApiExplorer();
    // services.AddSwaggerGen();

    // REMARK: If you want to use Controllers, you'll need this.
    services.AddControllers();

    // services.AddExceptionHandler<GlobalExceptionHandler>();
    services.AddProblemDetails();

    return services;
  }
}
