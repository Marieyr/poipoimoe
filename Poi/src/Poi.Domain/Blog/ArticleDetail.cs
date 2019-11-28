using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Poi.Blog
{
    public class ArticleDetail:Entity<Guid>
    {
        /// <summary>
        /// 文章id
        /// </summary>
        public string ArticleId { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }

        public virtual Article Article { get; set; }
    }
}
