using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace Abp.Blog
{
    [DependsOn(
        typeof(BlogApplicationContractsModule),
        typeof(AbpSettingManagementHttpApiClientModule)
    )]
    public class BlogHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BlogApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
