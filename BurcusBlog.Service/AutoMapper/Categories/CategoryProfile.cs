using AutoMapper;
using BurcusBlog.Entity.DTOs.Categories;
using BurcusBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcusBlog.Service.AutoMapper.Categories
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
