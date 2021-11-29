using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Blog.Posts;
using Volo.Abp.Domain.Entities;

namespace Abp.Blog.Entities
{
    public class PostComment : Entity<int>
    {

        [Column("varchar(100)")]
        [Required]
        public string Author { get; set; }

        [Column("varchar(100)")]
        [Required]
        public string Email { get; set; }
        [Column("varchar(50)")]
        public string IpAddress { get; set; }

        [Column("varchar(255)")]
        public string AuthorUrl { get; set; }

        
        public bool IsAdmin { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public int PostId { get; set; }

        [Column("bit")]
        public bool AllowNotification { get; set; }
        
        [Column("varchar(255)")]
        public string UserAgent { get; set; }
        public PostCommentStatus PostCommentStatus { get; set; }

        [Column("text")]
        public string Content { get; set; }

        [ForeignKey("ParentId")]
        public PostComment ParentComment { get; set; }
        public int ParentId { get; set; }
    }
}
