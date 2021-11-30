using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.Blog.Blog;
using Abp.Blog.Dto.Category;
using Abp.Blog.Entities;

namespace Abp.Blog.Profiles
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category,CategoryDto>();
            CreateMap<CreateUpdateCategoryDto,Category>();
        }
    }
}
