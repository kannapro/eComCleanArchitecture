namespace Notification.Service.Endpoints;

public interface IEndpoint
{
  void MapEndpoint(IEndpointRouteBuilder app);
}