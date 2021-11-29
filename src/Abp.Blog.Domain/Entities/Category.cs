﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Blog.Entities
{
    public class Category : AuditedAggregateRoot<int>
    {
        /// <summary>
        /// 标题
        /// </summary>
        [Column("varchar(100)")]
        public string Title { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [Column("varchar(100)")]
        public string Alias { get; set; }

        /// <summary>
        /// 上级目录
        /// </summary>
        public int ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Category Parent { get; set; }
        /// <summary>
        /// 加密密码
        /// </summary>
        [Column("varchar(100)")]
        public string PassWord { get; set; }
        /// <summary>
        /// 自定义描述
        /// </summary>
        [Column("text")]
        public string CustomDescription { get; set; }


        public int PostCount { get; set; }
    }
}
