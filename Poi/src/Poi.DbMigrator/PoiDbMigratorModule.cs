using Poi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Poi.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PoiEntityFrameworkCoreDbMigrationsModule),
        typeof(PoiApplicationContractsModule)
        )]
    public class PoiDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
