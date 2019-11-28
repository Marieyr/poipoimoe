using Poi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Poi
{
    [DependsOn(
        typeof(PoiEntityFrameworkCoreTestModule)
        )]
    public class PoiDomainTestModule : AbpModule
    {

    }
}