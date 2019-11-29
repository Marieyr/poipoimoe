using Volo.Abp.Modularity;

namespace Poi.Moe
{
    [DependsOn(
        typeof(MoeApplicationModule),
        typeof(MoeDomainTestModule)
        )]
    public class MoeApplicationTestModule : AbpModule
    {

    }
}