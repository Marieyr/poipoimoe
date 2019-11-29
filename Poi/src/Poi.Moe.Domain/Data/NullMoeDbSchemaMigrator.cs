using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Poi.Moe.Data
{
    /* This is used if database provider does't define
     * IMoeDbSchemaMigrator implementation.
     */
    public class NullMoeDbSchemaMigrator : IMoeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}