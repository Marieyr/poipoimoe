using System.Threading.Tasks;

namespace Poi.Data
{
    public interface IPoiDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
