using System;
using System.Threading.Tasks;
using Abp.Blog.Blog;
using Abp.Blog.Dto.Category;
using Abp.Blog.Entities;
using Abp.Blog.Service;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Blog.Impl
{
    public class CategoryService: CrudAppService<Category,CategoryDto,int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>,ICategoryService
    {
        public CategoryService(IRepository<Category,int> repository):base(repository)
        {

        }

    }
}
