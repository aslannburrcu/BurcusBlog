using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurcusBlog.Data.Migrations
{
    public partial class DALExtentions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5030610e-6a19-4ec1-9121-a5a6383f67c6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fba65ab2-7620-457d-bf4a-26225ca1a58d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("9b3e3e5a-da3b-4e42-ac54-70a3a9dde5a2"), new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"), " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 3, 23, 22, 38, 3, 525, DateTimeKind.Local).AddTicks(1747), null, null, new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"), false, "Asp.net Core Deneme Makalesi 1", null, null, 15 },
                    { new Guid("f8e917f7-3abe-48dd-bd2a-2b1bcf4c55c2"), new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"), " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 3, 23, 22, 38, 3, 525, DateTimeKind.Local).AddTicks(1771), null, null, new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"), false, "visual studio Deneme Makalesi 1", null, null, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 22, 38, 3, 525, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 22, 38, 3, 525, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 22, 38, 3, 525, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 22, 38, 3, 525, DateTimeKind.Local).AddTicks(2760));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9b3e3e5a-da3b-4e42-ac54-70a3a9dde5a2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f8e917f7-3abe-48dd-bd2a-2b1bcf4c55c2"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5030610e-6a19-4ec1-9121-a5a6383f67c6"), new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"), " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(6812), null, null, new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"), false, "Asp.net Core Deneme Makalesi 1", null, null, 15 },
                    { new Guid("fba65ab2-7620-457d-bf4a-26225ca1a58d"), new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"), " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(6827), null, null, new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"), false, "visual studio Deneme Makalesi 1", null, null, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f3b77ec-8445-4634-b9be-5c2f1180af0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fdd5ef2-6f21-4e57-8fa9-b04354633a92"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5ca2cde2-06dc-4a0f-bf85-f11b85e67fde"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e5a1d749-a841-42ef-9c1b-b75668702cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 22, 5, 38, 122, DateTimeKind.Local).AddTicks(7816));
        }
    }
}
