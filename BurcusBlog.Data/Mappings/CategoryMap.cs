using BurcusBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcusBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("1FDD5EF2-6F21-4E57-8FA9-B04354633A92"),
                Name = "Asp.net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
           new Category
           {
                   Id = Guid.Parse("0F3B77EC-8445-4634-B9BE-5C2F1180AF0C"),
                   Name = "visual Studio 2022",
                   CreatedBy = "Admin Test",
                   CreatedDate = DateTime.Now,
                   IsDeleted = false,
           });
        }
    }
}
