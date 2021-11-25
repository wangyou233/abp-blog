using Abp.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}