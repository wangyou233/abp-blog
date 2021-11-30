using System;
using System.Threading.Tasks;
using Abp.Blog.Blog;
using Abp.Blog.Dto.Category;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Abp.Blog.Service
{
    public interface ICategoryService : ICrudAppService<CategoryDto,int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>
    {
    }
}
