using Poi.Moe.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Poi.Moe.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MoeEntityFrameworkCoreDbMigrationsModule),
        typeof(MoeApplicationContractsModule)
        )]
    public class MoeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
