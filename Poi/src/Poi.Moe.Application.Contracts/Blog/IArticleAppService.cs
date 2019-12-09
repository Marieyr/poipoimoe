using System;
using Poi.Moe.Blog.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Poi.Moe.Blog
{
    public interface IArticleAppService :
        ICrudAppService<
            ArticleDto, //用来展示
            Guid,//实体主键
            PagedAndSortedResultRequestDto, //分页和排序获取
            CreateUpdateArticleDto,//创建
            CreateUpdateArticleDto>//更新
    {
    }
}