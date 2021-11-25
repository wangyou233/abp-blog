using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Blog.DbMigrator;

namespace Abp.Blog.Utils.Db
{
    public static class DbRepositoryExtensions
    {
        public static void MigrateDatabase(this IServiceProvider serviceProvider)
        {
            //var db = serviceProvider.GetService<BlogDbMigratorModule>();

        }
    }
}
