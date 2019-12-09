using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Poi.Moe.Blog.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Poi.Moe.Blog
{
    public class ArticleAppService :
        CrudAppService<Article, ArticleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateArticleDto,
            CreateUpdateArticleDto>, IArticleAppService
    {
        public ArticleAppService(IRepository<Article, Guid> repository)
            : base(repository)
        {
        }

    }
}
