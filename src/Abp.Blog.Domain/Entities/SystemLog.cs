using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Abp.Blog.Entities
{
    public class SystemLog : Entity<int>
    {
        /// <summary>
        /// 关联Id
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string EventId { get; set; }

        /// <summary>
        /// 事件
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        [Required]
        public string EventTitle { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
