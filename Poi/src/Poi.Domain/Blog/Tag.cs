using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Poi.Blog
{
    /// <summary>
    /// 标签表
    /// </summary>
    public class Tag:Entity<Guid>
    {
        /// <summary>
        /// 标签名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 多对多
        /// </summary>
        public Article Articles { get; set; }
    }
}
