using System;
using Poi.Moe.Blog.Dto;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Poi.Moe.Blog
{
    public class TagAppService : CrudAppService<Tag, TagDto, Guid, CreateUpdateTagDto, CreateUpdateTagDto>,
        ITagAppService
    {
        public TagAppService(IRepository<Tag, Guid> repository) : base(repository)
        {
        }
    }
}