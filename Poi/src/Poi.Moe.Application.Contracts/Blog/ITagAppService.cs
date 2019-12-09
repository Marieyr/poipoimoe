using System;
using Poi.Moe.Blog.Dto;
using Volo.Abp.Application.Services;

namespace Poi.Moe.Blog
{
    public interface ITagAppService : ICrudAppService<TagDto, Guid, CreateUpdateTagDto, CreateUpdateTagDto>
    {

    }
}