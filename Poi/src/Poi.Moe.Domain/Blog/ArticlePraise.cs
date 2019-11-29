using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Poi.Moe.Blog
{
    /// <summary>
    /// 点赞表
    /// </summary>
   public class ArticlePraise : Entity<Guid>
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        public string ArticleId { get; set; }

        /// <summary>
        /// 点赞or踩
        /// </summary>
        public bool IsPositive { get; set; }

        /// <summary>
        /// 点赞时间
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 点赞人id
        /// </summary>
        public Users.AppUser UserId { get; set; }
    }
}
