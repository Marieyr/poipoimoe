using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Poi.Blog.Data;
using Volo.Abp.DependencyInjection;

namespace Poi.Blog.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreBlogDbSchemaMigrator 
        : IBlogDbSchemaMigrator, ITransientDependency
    {
        private readonly BlogMigrationsDbContext _dbContext;

        public EntityFrameworkCoreBlogDbSchemaMigrator(BlogMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}