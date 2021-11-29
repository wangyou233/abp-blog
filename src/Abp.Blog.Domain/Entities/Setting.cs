using Volo.Abp.Domain.Entities;

namespace Abp.Blog.Entities
{
    public class Setting : Entity<int>
    {

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
