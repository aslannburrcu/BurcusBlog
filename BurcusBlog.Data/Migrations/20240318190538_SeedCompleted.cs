using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurcusBlog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"), "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7484), null, null, false, "visual Studio 2022", null, null },
                    { new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"), "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7476), null, null, false, "Asp.net Core", null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"), "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7808), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"), "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7816), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[] { new Guid("5030610e-6a19-4ec1-9121-a5a6383f67c6"), new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"), " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(6812), null, null, new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"), false, "Asp.net Core Deneme Makalesi 1", null, null, 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[] { new Guid("fba65ab2-7620-457d-bf4a-26225ca1a58d"), new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"), " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(6827), null, null, new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"), false, "visual studio Deneme Makalesi 1", null, null, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5030610e-6a19-4ec1-9121-a5a6383f67c6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fba65ab2-7620-457d-bf4a-26225ca1a58d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
