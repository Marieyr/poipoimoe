using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Poi.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(PoiHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class PoiConsoleApiClientModule : AbpModule
    {
        
    }
}
