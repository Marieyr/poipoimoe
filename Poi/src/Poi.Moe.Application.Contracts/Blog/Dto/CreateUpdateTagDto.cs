using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poi.Moe.Blog.Dto
{
    public class CreateUpdateTagDto
    {
        /// <summary>
        /// 标签名
        /// </summary>
        [StringLength(50, ErrorMessage = "标签名不能超过50个字符")]
        [Required]
        public string Name { get; set; }
    }
}
