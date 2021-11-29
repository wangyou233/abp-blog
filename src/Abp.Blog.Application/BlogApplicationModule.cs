using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace Abp.Blog
{
    [DependsOn(
        typeof(BlogDomainModule),
        typeof(BlogApplicationContractsModule),
        typeof(AbpSettingManagementApplicationModule)
        )]
    public class BlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BlogApplicationModule>();
            });
        }
    }
}
