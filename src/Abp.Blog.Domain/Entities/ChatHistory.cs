using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Blog.Entities
{
    /// <summary>
    /// 聊天记录表
    /// </summary>
    public class ChatHistory : AuditedAggregateRoot<int>
    {

        [ForeignKey("SendUserId")]
        public User User { get; set; }
        /// <summary>
        /// 发送人Id
        /// </summary>
        public int SendUserId { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string AvatarUrl { get; set; }


        /// <summary>
        /// 聊天文本
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Ip
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string IpAddress { get; set; }

    }
}
