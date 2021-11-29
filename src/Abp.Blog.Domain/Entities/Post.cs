using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Blog.Posts;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Blog.Entities
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Post : Entity<int>
    {
        /// <summary>
        /// 标题
        /// </summary>
        [Column("varchar(100)")]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [Column("varchar(100)")]
        public string Alias { get; set; }

        /// <summary>
        /// 封面图
        /// </summary>
        [Column("varchar(255)")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 加密密码
        /// </summary>
        [Column("varchar(100)")]
        public string PassWord { get; set; }

        /// <summary>
        /// Seo优化
        /// </summary>
        [Column("varchar(100)")]
        public string SeoSetting { get; set; }

        /// <summary>
        /// 自定义描述
        /// </summary>
        [Column("text")]
        public string CustomDescription { get; set; }

        /// <summary>
        /// 是否顶置
        /// </summary>
        [Column("bit")]
        public bool IsTop { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [Column("varchar(100)")]
        public string Author { get; set; }

        /// <summary>
        /// 转载链接
        /// </summary>
        [Column("varchar(255)")]
        public string Url { get; set; }

        /// <summary>
        /// Markdown
        /// </summary>
        [Column("longtext")]
        public string Markdown { get; set; }

        /// <summary>
        /// 分类Id
        /// </summary>
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        
        /// <summary>
        /// 状态
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }


        public int ReadCount { get; set; }
    }
}
