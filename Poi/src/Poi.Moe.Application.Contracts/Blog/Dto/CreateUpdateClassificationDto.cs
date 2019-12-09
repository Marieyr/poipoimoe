using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poi.Moe.Blog.Dto
{
    public class CreateUpdateClassificationDto
    {

        /// <summary>
        /// 分类名称
        /// </summary>
        [Required(ErrorMessage = "分类名不能为空")]
        [StringLength(50,ErrorMessage = "分类名不能超过50个字符")]
        public string Name { get; set; }



    }
}
