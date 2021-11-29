using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Blog.Entities
{
    public class File : AuditedAggregateRoot<int>
    {

        [Column("varchar(100)")]
        public string Path { get; set; }

        [Column("varchar(255)")]
        public string RootPath { get; set; }

        public int Size { get; set; }
        [Column("varchar(255)")]
        public string FileName { get; set; }

        [Column("varchar(100)")]
        public string Type { get; set; }
    }
}
