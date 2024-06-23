using AutoMapper;
using BurcusBlog.Data.UnitOfWorks;
using BurcusBlog.Entity.DTOs.Articles;
using BurcusBlog.Entity.Entities;
using BurcusBlog.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcusBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
         var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x=>!x.IsDeleted, x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
    }
}
