using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Poi.Moe.Data;
using Volo.Abp.DependencyInjection;

namespace Poi.Moe.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreMoeDbSchemaMigrator 
        : IMoeDbSchemaMigrator, ITransientDependency
    {
        private readonly MoeMigrationsDbContext _dbContext;

        public EntityFrameworkCoreMoeDbSchemaMigrator(MoeMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}