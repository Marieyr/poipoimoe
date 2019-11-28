using Volo.Abp.Modularity;

namespace Poi
{
    [DependsOn(
        typeof(PoiApplicationModule),
        typeof(PoiDomainTestModule)
        )]
    public class PoiApplicationTestModule : AbpModule
    {

    }
}