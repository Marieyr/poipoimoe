using Microsoft.EntityFrameworkCore;
using Poi.Moe.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Poi.Moe.EntityFrameworkCore
{
    /*这是在运行时使用的实际DbContext。
      *仅包括您的实体。
      *它不包括所用模块的实体，因为每个模块已经
      *它自己的DbContext类。 如果要与使用的模块共享一些数据库表，
      *只需创建一个类似AppUser的结构即可。
      *
      *不要使用此DbContext进行数据库迁移，因为它不包含
      *使用的模块（如上所述）。 有关迁移，请参见MoeMigrationsDbContext。
      */
    [ConnectionStringName("Default")]
    public class MoeDbContext : AbpDbContext<MoeDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* 在此处为您的聚合根/实体添加DbSet属性。
         * 还要在MoeDbContextModelCreatingExtensions.ConfigureMoe中映射它们
         */
        public DbSet<Blog.Article> Articles { get; set; }
        public DbSet<Blog.ArticleDetail> ArticleDetails { get; set; }
        public DbSet<Blog.ArticlePraise> ArticlePraises { get; set; }
        public DbSet<Blog.Classification> Classifications { get; set; }
        public DbSet<Blog.Tag> Tags { get; set; }
        public DbSet<Blog.ArticleTag> ArticleTags { get; set; }

        public MoeDbContext(DbContextOptions<MoeDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* 在此处配置共享表（包括随附的模块） */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //与IdentityUser共享同一表“ AbpUsers”
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                //将自定义方法移至此，以便我们可以与MoeMigrationsDbContext类共享它`
                b.ConfigureCustomUserProperties();
            });

            /* 在ConfigureMoe方法中配置自己的表/实体 */

            builder.ConfigureMoe();
        }
    }
}
