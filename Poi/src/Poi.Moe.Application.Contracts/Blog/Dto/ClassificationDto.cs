using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poi.Moe.Blog.Dto
{
    public class ClassificationDto:EntityDto<Guid>
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }

    }
}
