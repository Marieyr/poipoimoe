using System;
using System.Collections.Generic;
using System.Text;
using Poi.Moe.Blog.Dto;
using Volo.Abp.Application.Services;

namespace Poi.Moe.Blog
{
    public interface IClassificationAppService : ICrudAppService<ClassificationDto, Guid, CreateUpdateClassificationDto,
        CreateUpdateClassificationDto>

    {
    }
}
