using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace Abp.Blog
{
    [DependsOn(
        typeof(BlogDomainSharedModule),
        typeof(AbpObjectExtendingModule)
    )]
    public class BlogApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            BlogDtoExtensions.Configure();
        }
    }
}
