using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace Abp.Blog.Blog
{
    public class CategoryDto: AuditedEntityDto<int>, Volo.Abp.Application.Dtos.IEntityDto<int>

    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 上级目录
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 加密密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 自定义描述
        /// </summary>
        public string CustomDescription { get; set; }
    }
}
