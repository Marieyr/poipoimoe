using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Poi.Moe.Blog
{
    /// <summary>
    /// 文章和标签中间表
    /// </summary>
    public class ArticleTag:Entity<Guid>
    {
        public Article Article { get; set; }
        public Tag Tag { get; set; }
    }
}
