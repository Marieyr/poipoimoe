using System.Threading.Tasks;

namespace Poi.Moe.Data
{
    public interface IMoeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
