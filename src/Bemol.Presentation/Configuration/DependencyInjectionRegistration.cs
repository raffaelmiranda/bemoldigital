using Bemol.Application.AppServices;
using Bemol.Application.Interfaces;
using Bemol.Domain.Interfaces.Repositories;
using Bemol.Infrastructure.Repositories;

namespace Bemol.Api.Configuration
{
    public static class DependencyInjectionRegistration
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IClienteAppService, ClienteAppService>();
            services.AddTransient(typeof(IBaseAppService<>), typeof(BaseAppService<>));

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
