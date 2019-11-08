using Poi.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Poi.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}