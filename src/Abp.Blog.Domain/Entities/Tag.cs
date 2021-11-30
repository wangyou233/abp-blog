using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Abp.Blog.Entities
{
    public class Tag : Entity<int>
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string TagName { get; set; }
        /// <summary>
        /// 展示名称
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string DisplayName { get; set; }

    }
}
