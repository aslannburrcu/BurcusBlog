﻿// <auto-generated />
using System;
using BurcusBlog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurcusBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("51a743f1-c785-4fef-9be8-cb3cfecdc253"),
                            ConcurrencyStamp = "072aba3c-3b21-479d-8ee1-08ad502ee81c",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("1e5aa0f3-b6fd-407d-a4ea-94517513cb76"),
                            ConcurrencyStamp = "7cfffe6e-28e4-436a-b054-04875a35058e",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("bee7691b-2a32-42f8-8b8c-baff9062c4ad"),
                            ConcurrencyStamp = "fabe4c6d-3944-4f62-9aaf-fd83d6ec7dd9",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("275b092a-f867-42c9-89fb-167dc1c9a292"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2c5d734c-bd65-4b58-b616-8ee4d09f9e18",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Burcu",
                            ImageId = new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"),
                            LastName = "Aslan",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOYlmNeqWFPHR8ONrdlMiLZa5haGpzsj0j1ae4lfg4sO+//T0O6B/uX9WBANYcYdRw==",
                            PhoneNumber = "+90356789898",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "94b1ec53-1a62-4dc4-9a4c-4ae1ed6a5700",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("67f122e2-0b40-4204-b3ab-17c6031ad896"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d1c21131-b617-45e2-9008-d66bcfab7bea",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELpYHl7T0UP5wRulQ0e+/9mLhsDNwWllRGu3Qsevttlyr6EB7qsI0xSQajYbbsNBTg==",
                            PhoneNumber = "+90356789898",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ce7f0744-c610-4401-8df5-5a4c6a7bfa46",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("275b092a-f867-42c9-89fb-167dc1c9a292"),
                            RoleId = new Guid("51a743f1-c785-4fef-9be8-cb3cfecdc253")
                        },
                        new
                        {
                            UserId = new Guid("67f122e2-0b40-4204-b3ab-17c6031ad896"),
                            RoleId = new Guid("1e5aa0f3-b6fd-407d-a4ea-94517513cb76")
                        });
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3d194f7c-f96d-4183-bac3-3452850ae785"),
                            CategoryId = new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"),
                            Content = " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 4, 3, 18, 10, 28, 945, DateTimeKind.Local).AddTicks(3829),
                            ImageId = new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"),
                            IsDeleted = false,
                            Title = "Asp.net Core Deneme Makalesi 1",
                            UserId = new Guid("275b092a-f867-42c9-89fb-167dc1c9a292"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("1de35c57-1c6e-4d50-9f1a-f04897a6b3b6"),
                            CategoryId = new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"),
                            Content = " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 4, 3, 18, 10, 28, 945, DateTimeKind.Local).AddTicks(3842),
                            ImageId = new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"),
                            IsDeleted = false,
                            Title = "visual studio Deneme Makalesi 1",
                            UserId = new Guid("67f122e2-0b40-4204-b3ab-17c6031ad896"),
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 4, 3, 18, 10, 28, 945, DateTimeKind.Local).AddTicks(4770),
                            IsDeleted = false,
                            Name = "Asp.net Core"
                        },
                        new
                        {
                            Id = new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 4, 3, 18, 10, 28, 945, DateTimeKind.Local).AddTicks(4776),
                            IsDeleted = false,
                            Name = "visual Studio 2022"
                        });
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 4, 3, 18, 10, 28, 945, DateTimeKind.Local).AddTicks(5380),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 4, 3, 18, 10, 28, 945, DateTimeKind.Local).AddTicks(5387),
                            FileName = "images/vstest",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("BurcusBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("BurcusBlog.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("BurcusBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("BurcusBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("BurcusBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurcusBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("BurcusBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.Article", b =>
                {
                    b.HasOne("BurcusBlog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurcusBlog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("BurcusBlog.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BurcusBlog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
