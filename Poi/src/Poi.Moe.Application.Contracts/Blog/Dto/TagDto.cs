

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Poi.Moe.Blog.Dto
{
    public class TagDto:EntityDto<Guid>
    {
        public string Name { get; set; }

    }
}
