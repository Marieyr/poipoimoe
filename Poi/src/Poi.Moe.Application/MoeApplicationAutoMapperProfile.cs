using System.Runtime.InteropServices.ComTypes;
using AutoMapper;
using Poi.Moe.Blog;
using Poi.Moe.Blog.Dto;
using Volo.Abp.AutoMapper;

namespace Poi.Moe
{
    public class MoeApplicationAutoMapperProfile : Profile
    {
        public MoeApplicationAutoMapperProfile()
        {
            /* 您可以在此处配置AutoMapper映射配置。
             * 或者，您可以拆分映射配置
             * 分为多个概要文件类，以实现更好的组织。 */

            CreateMap<Article, ArticleDto>();
            CreateMap<CreateUpdateArticleDto, Article>();

            CreateMap<Classification, ClassificationDto>();
            CreateMap<CreateUpdateClassificationDto, Classification>();

            CreateMap<Tag, TagDto>();
            CreateMap<CreateUpdateTagDto, Tag>();
        }
    }
}
