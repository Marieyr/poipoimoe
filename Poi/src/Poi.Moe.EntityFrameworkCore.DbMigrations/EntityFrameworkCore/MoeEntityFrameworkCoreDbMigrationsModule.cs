using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Poi.Moe.EntityFrameworkCore
{
    [DependsOn(
        typeof(MoeEntityFrameworkCoreModule)
        )]
    public class MoeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MoeMigrationsDbContext>();
        }
    }
}
