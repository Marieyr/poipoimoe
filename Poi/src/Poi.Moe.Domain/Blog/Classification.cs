using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Poi.Moe.Blog
{
    /// <summary>
    /// 分类表
    /// </summary>
    public class Classification : Entity<Guid>
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 多对一
        /// </summary>
        public virtual ICollection<Article> Articles { get; set; }  

    }
}
