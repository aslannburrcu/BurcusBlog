using BurcusBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcusBlog.Service.Services.Abstractions
{
    public interface IArticleService 
    {
        Task<List<Article>> GetAllArticleAsync();
    }
}
