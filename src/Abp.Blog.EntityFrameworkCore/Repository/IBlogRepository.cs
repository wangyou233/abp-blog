using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Abp.Blog.Repository
{
    public interface IBlogRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<TEntity> entities);
    }
}
