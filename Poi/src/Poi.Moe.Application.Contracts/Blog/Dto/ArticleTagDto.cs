using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poi.Moe.Blog.Dto
{
    public class ArticleTagDto:EntityDto<Guid>
    {
        /// <summary>
        /// 标签名
        /// </summary>
        public string Name { get; set; }

    }
}
