using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Poi.Moe.Blog
{
    /// <summary>
    /// 文章信息表
    /// </summary>
    public class Article : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public Users.AppUser UserId { get; set; }
        /// <summary>
        /// 文章摘要
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        public int PraiseCount { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// 阅读数
        /// </summary>
        public int ReadCount { get; set; }
        /// <summary>
        /// 分类id
        /// </summary>
        public Guid ClassId { get; set; }

        /// <summary>
        /// 是否精华
        /// </summary>
        public bool IsEssence { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; }

        /// <summary>
        /// 一对一
        /// </summary>
        public virtual ArticleDetail ArticleDetail { get; set; }
        /// <summary>
        /// 多对多
        /// </summary>
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }
}
