using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Abp.Blog.Users;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Blog.Entities
{
    public class User : AuditedAggregateRoot<int>
    {
        [Column(TypeName = "varchar(100)")]
        public string UserName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NiceName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Password { get; set; }

        public int Phone { get; set; }

        public UserStatus UserStatus { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string AvatarUrl { get; set; }

    }
}
