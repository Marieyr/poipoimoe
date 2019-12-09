using System;
using Poi.Moe.Blog.Dto;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Poi.Moe.Blog
{
    public class ClassificationAppService : CrudAppService<Classification, ClassificationDto, Guid,
        CreateUpdateClassificationDto, CreateUpdateClassificationDto>, IClassificationAppService
    {
        public ClassificationAppService(IRepository<Classification, Guid> repository)
            : base(repository)
        {
        }
    }
}