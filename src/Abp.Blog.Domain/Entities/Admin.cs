using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Blog.Entities
{
    public class Admin : AuditedAggregateRoot<int>
    {
        [Column(TypeName = "varchar(100)")]
        public string UserName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NiceName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Password { get; set; }


        /// <summary>
        /// 头像
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 自定义描述
        /// </summary>
        public string CustomDescription { get; set; }
    }
}
