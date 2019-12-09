using System;
using System.Collections.Generic;
using System.Text;

namespace Poi.Moe.Blog.Dto
{
    public class ArticleDetailDto
    {

        /// <summary>
        /// 文章id
        /// </summary>
        public Guid ArticleId { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }

    }
}
