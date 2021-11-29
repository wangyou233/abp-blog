using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Abp.Blog.Entities
{
    public class Link : Entity<int>
    {
        [Column("varchar(255)")]
        public string Name { get; set; }
        [Column("varchar(255)")]
        public string Logo { get; set; }
        [Column("text")]
        public string Description { get; set; }
        [Column("varchar(100)")]
        public string Team { get; set; }

        public int Sort { get; set; }
    }
}
