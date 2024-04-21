using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "01f9aa2c-cbb4-46bd-974a-f0082254262f");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "442b0a3e-9575-45b3-8e3e-cb0e38af267c");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "488a89ca-db37-411a-85a1-98555f8c6c88");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "5383477a-230d-440d-85cc-85bd718a54c3");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "8242b541-32d8-40b4-b8f2-8c3d6a903ec8");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "91b4c26d-dd9e-4d0b-927a-78464fc4e71e");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "9bfc29ae-a1f6-45e6-9a43-66209ad18d1e");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c4ecdbf5-4ab2-4975-9aff-15ad4aed190f");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "dcc7b20d-3dd1-4ddd-94ce-30ae8fd23e18");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImagePath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "DiscountPrice", "Hours", "ImageName", "IsBestseller", "LikesInNumbers", "LikesInProcent", "OriginalPrice", "Title" },
                values: new object[,]
                {
                    { "5aae207a-4051-4cc5-931f-dd8b6aa940aa", "Robert Fox", 0m, 220, "fullstack_web_dev.svg", true, 4200m, 0.94m, 12.50m, "Fullstack Web Development" },
                    { "7d847695-d883-4fb1-80a5-6f16827a451b", "Marvin McKinney", 0m, 160, "ios_swift_dev.svg", false, 3100m, 0.92m, 15.99m, "iOS & Swift - The Complete iOS App Development Bootcamp" },
                    { "99bd4ecd-d523-46f5-b7d1-caebda411507", "Jenny Wilson", 0m, 160, "html_css_js.svg", false, 3100m, 0.92m, 15.99m, "HTML, CSS, JavaScript" },
                    { "9d3f33f9-cc88-48c0-a223-e8b6efdb6042", "Jenny Wilson", 0m, 160, "jmeter_performance_testing.svg", false, 3100m, 0.92m, 14.50m, "Learn JMETER from Scratch on Live Apps - Performance Testing" },
                    { "b0f93753-3442-4949-bb30-5fc0f4fd6f32", "Albert Flores", 12.99m, 100, "ui_ux_design.svg", false, 2700m, 0.98m, 44.99m, "The Ultimate 6-Day Intensive For UX/UI Design" },
                    { "c8748115-155d-4a66-b1c2-2eb20451d4a9", "Robert Fox", 0m, 220, "creative_css_design.svg", false, 4200m, 0.94m, 1050m, "Creative CSS Design" },
                    { "c8b94d75-c773-43a5-8c64-fd6af513274f", "Ralph Edwards", 0m, 160, "blender_character_creator.svg", false, 3100m, 0.92m, 18.99m, "Blender Character Creator: Rigging Humanoid 3D Characters" },
                    { "f6204c2e-c7dd-444e-a9f8-1f97f2a36b1e", "Esther Howard", 0m, 160, "data_science.svg", true, 3100m, 0.92m, 11.20m, "Data Science" },
                    { "f925f2ce-b5cb-4ccd-93cb-59657cc99be4", "Albert Flores", 9.99m, 100, "front_end_dev.svg", false, 2700m, 0.98m, 44.99m, "The Complete Front-End Web Development Course" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "5aae207a-4051-4cc5-931f-dd8b6aa940aa");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "7d847695-d883-4fb1-80a5-6f16827a451b");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "99bd4ecd-d523-46f5-b7d1-caebda411507");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "9d3f33f9-cc88-48c0-a223-e8b6efdb6042");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "b0f93753-3442-4949-bb30-5fc0f4fd6f32");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c8748115-155d-4a66-b1c2-2eb20451d4a9");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c8b94d75-c773-43a5-8c64-fd6af513274f");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f6204c2e-c7dd-444e-a9f8-1f97f2a36b1e");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f925f2ce-b5cb-4ccd-93cb-59657cc99be4");

            migrationBuilder.DropColumn(
                name: "ProfileImagePath",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "DiscountPrice", "Hours", "ImageName", "IsBestseller", "LikesInNumbers", "LikesInProcent", "OriginalPrice", "Title" },
                values: new object[,]
                {
                    { "01f9aa2c-cbb4-46bd-974a-f0082254262f", "Robert Fox", 0m, 220, "fullstack_web_dev.svg", true, 4200m, 0.94m, 12.50m, "Fullstack Web Development" },
                    { "442b0a3e-9575-45b3-8e3e-cb0e38af267c", "Albert Flores", 12.99m, 100, "ui_ux_design.svg", false, 2700m, 0.98m, 44.99m, "The Ultimate 6-Day Intensive For UX/UI Design" },
                    { "488a89ca-db37-411a-85a1-98555f8c6c88", "Jenny Wilson", 0m, 160, "jmeter_performance_testing.svg", false, 3100m, 0.92m, 14.50m, "Learn JMETER from Scratch on Live Apps - Performance Testing" },
                    { "5383477a-230d-440d-85cc-85bd718a54c3", "Jenny Wilson", 0m, 160, "html_css_js.svg", false, 3100m, 0.92m, 15.99m, "HTML, CSS, JavaScript" },
                    { "8242b541-32d8-40b4-b8f2-8c3d6a903ec8", "Robert Fox", 0m, 220, "creative_css_design.svg", false, 4200m, 0.94m, 1050m, "Creative CSS Design" },
                    { "91b4c26d-dd9e-4d0b-927a-78464fc4e71e", "Esther Howard", 0m, 160, "data_science.svg", true, 3100m, 0.92m, 11.20m, "Data Science" },
                    { "9bfc29ae-a1f6-45e6-9a43-66209ad18d1e", "Albert Flores", 9.99m, 100, "front_end_dev.svg", false, 2700m, 0.98m, 44.99m, "The Complete Front-End Web Development Course" },
                    { "c4ecdbf5-4ab2-4975-9aff-15ad4aed190f", "Marvin McKinney", 0m, 160, "ios_swift_dev.svg", false, 3100m, 0.92m, 15.99m, "iOS & Swift - The Complete iOS App Development Bootcamp" },
                    { "dcc7b20d-3dd1-4ddd-94ce-30ae8fd23e18", "Ralph Edwards", 0m, 160, "blender_character_creator.svg", false, 3100m, 0.92m, 18.99m, "Blender Character Creator: Rigging Humanoid 3D Characters" }
                });
        }
    }
}
