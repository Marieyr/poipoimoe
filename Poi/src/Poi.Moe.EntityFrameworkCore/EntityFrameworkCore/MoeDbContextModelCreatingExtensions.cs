using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace Poi.Moe.EntityFrameworkCore
{
    public static class MoeDbContextModelCreatingExtensions
    {
        public static void ConfigureMoe(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* 在此处配置您自己的表/实体 */

            builder.Entity<Blog.Article>(b =>
            {
                b.ToTable("BlogArticle");
                b.Property(x => x.IsEssence).HasDefaultValue(false);
                b.Property(x => x.IsTop).HasDefaultValue(false);
                b.Property(x => x.CommentCount).HasDefaultValue(0);
                b.Property(x => x.PraiseCount).HasDefaultValue(0);
                b.Property(x => x.ReadCount).HasDefaultValue(0);
                b.Property(x => x.Title).HasMaxLength(100).IsRequired();
                b.Property(x => x.Summary).HasMaxLength(500);
                b.ConfigureAuditedAggregateRoot();
            });

            builder.Entity<Blog.ArticleDetail>(b =>
            {
                b.ToTable("BlogArticleDetail");
                b.Property(x => x.Content).HasMaxLength(5000);
            });

            builder.Entity<Blog.ArticlePraise>(b =>
            {
                b.ToTable("BlogArticlePraise");
                b.Property(x => x.Time).HasDefaultValueSql("GetDate()").IsRequired();
                b.Property(x => x.IsPositive).IsRequired();
            });

            builder.Entity<Blog.Classification>(b =>
            {
                b.ToTable("BlogClassification");
                b.Property(x => x.Name).HasMaxLength(50).IsRequired();

            });

            builder.Entity<Blog.Tag>(b =>
            {
                b.ToTable("BlogTag");
                b.Property(x => x.Name).HasMaxLength(50).IsRequired();
            });

            builder.Entity<Blog.ArticleTag>(b =>
            {
                b.ToTable("BlogArticleTag");
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}