using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Blog.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Blog.Repository
{
    public class BlogRepository<TEntity> : EfCoreRepository<BlogDbContext,TEntity>,IBlogRepository<TEntity> where TEntity : class, IEntity
    {
        public BlogRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        /// <summary>
        /// 批量插入实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<TEntity> entities)
        {
            var dbContext = await GetDbContextAsync();
            await dbContext.Set<TEntity>().AddRangeAsync(entities);
            await dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 批量更新实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<TEntity> entities)
        {
            var dbContext = await GetDbContextAsync();
            await dbContext.Set<TEntity>().AddRangeAsync(entities);
            await dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 批量删除实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<TEntity> entities)
        {
            var dbContext = await GetDbContextAsync();
            dbContext.Set<TEntity>().RemoveRange(entities);
            await dbContext.SaveChangesAsync();

        }



    }
}
