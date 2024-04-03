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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("275B092A-F867-42C9-89FB-167DC1C9A292"),
                RoleId = Guid.Parse("51A743F1-C785-4FEF-9BE8-CB3CFECDC253"),
            },
            new AppUserRole
            {
                UserId = Guid.Parse("67F122E2-0B40-4204-B3AB-17C6031AD896"),
                RoleId = Guid.Parse("1E5AA0F3-B6FD-407D-A4EA-94517513CB76"),
            });
        }
    }
}
