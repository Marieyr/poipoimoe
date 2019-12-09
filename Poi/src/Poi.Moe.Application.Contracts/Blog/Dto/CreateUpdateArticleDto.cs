using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poi.Moe.Blog.Dto
{

    public class CreateUpdateArticleDto
    {

        /// <summary>
        /// 文章标题
        /// </summary>
        [Required(ErrorMessage = "标题不能为空")]
        [StringLength(500, ErrorMessage = "标题太长，应小于100个字符")]
        public string Title { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        [Required(ErrorMessage = "用户id不能为空")]
        [RegularExpression("^[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}$", ErrorMessage = "用户Id错误")]
        public Guid UserId { get; set; }
        /// <summary>
        /// 文章摘要
        /// </summary>
        [Required(ErrorMessage = "文章摘要不能为空")]
        [StringLength(500, ErrorMessage = "文章摘要过长，应小于500个字符")]
        public string Summary { get; set; }

        /// <summary>
        /// 分类id
        /// </summary>
        [Required(ErrorMessage = "分类Id不能为空")]
        [RegularExpression("^[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}$", ErrorMessage = "分类Id错误")]
        public Guid ClassId { get; set; }

        /// <summary>
        /// 是否精华
        /// </summary>
        public bool IsEssence { get; set; } = false;

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; } = false;
        /// <summary>
        /// 一对一
        /// </summary>
        public virtual ArticleDetailDto ArticleDetail { get; set; }
        /// <summary>
        /// 多对多
        /// </summary>
        public virtual ICollection<ArticleTagDto> ArticleTags { get; set; }
    }
}
