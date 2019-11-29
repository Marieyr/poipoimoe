using Poi.Moe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Poi.Moe
{
    [DependsOn(
        typeof(MoeEntityFrameworkCoreTestModule)
        )]
    public class MoeDomainTestModule : AbpModule
    {

    }
}