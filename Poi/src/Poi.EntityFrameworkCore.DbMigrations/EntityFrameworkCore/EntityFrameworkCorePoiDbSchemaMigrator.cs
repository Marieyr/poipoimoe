using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Poi.Data;
using Volo.Abp.DependencyInjection;

namespace Poi.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCorePoiDbSchemaMigrator 
        : IPoiDbSchemaMigrator, ITransientDependency
    {
        private readonly PoiMigrationsDbContext _dbContext;

        public EntityFrameworkCorePoiDbSchemaMigrator(PoiMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}