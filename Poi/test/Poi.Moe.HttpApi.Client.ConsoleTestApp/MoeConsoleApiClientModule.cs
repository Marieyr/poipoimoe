using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Poi.Moe.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MoeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MoeConsoleApiClientModule : AbpModule
    {
        
    }
}
