using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Application.Services
{
	public static class ServiceRegistiration
	{
		public static void AddApplicationServices(this IServiceCollection services, IConfiguration configration)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
		}
	}
}
