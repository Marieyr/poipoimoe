using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Poi.EntityFrameworkCore
{
    [DependsOn(
        typeof(PoiEntityFrameworkCoreModule)
        )]
    public class PoiEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PoiMigrationsDbContext>();
        }
    }
}
