using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Poi.Data
{
    /* This is used if database provider does't define
     * IPoiDbSchemaMigrator implementation.
     */
    public class NullPoiDbSchemaMigrator : IPoiDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}