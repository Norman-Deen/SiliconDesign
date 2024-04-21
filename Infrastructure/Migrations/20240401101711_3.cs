using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ProfileImagePath",
                table: "AspNetUsers",
                newName: "ImagePath");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "DiscountPrice", "Hours", "ImageName", "IsBestseller", "LikesInNumbers", "LikesInProcent", "OriginalPrice", "Title" },
                values: new object[,]
                {
                    { "19b557d0-bdab-456f-9595-2565a82fb7af", "Jenny Wilson", 0m, 160, "html_css_js.svg", false, 3100m, 0.92m, 15.99m, "HTML, CSS, JavaScript" },
                    { "4f7a0a9e-3d31-4dfc-b3f8-77f736187896", "Ralph Edwards", 0m, 160, "blender_character_creator.svg", false, 3100m, 0.92m, 18.99m, "Blender Character Creator: Rigging Humanoid 3D Characters" },
                    { "5fe860ae-42e1-48b5-813f-90263f8fe9d4", "Albert Flores", 12.99m, 100, "ui_ux_design.svg", false, 2700m, 0.98m, 44.99m, "The Ultimate 6-Day Intensive For UX/UI Design" },
                    { "6d58c745-089d-4b25-ad1e-741e2979f275", "Esther Howard", 0m, 160, "data_science.svg", true, 3100m, 0.92m, 11.20m, "Data Science" },
                    { "759375a6-fdd9-4f01-ad9a-9348c783fb98", "Robert Fox", 0m, 220, "fullstack_web_dev.svg", true, 4200m, 0.94m, 12.50m, "Fullstack Web Development" },
                    { "8af1b321-8eda-4d4d-acf5-af1e79a4086f", "Albert Flores", 9.99m, 100, "front_end_dev.svg", false, 2700m, 0.98m, 44.99m, "The Complete Front-End Web Development Course" },
                    { "cc7144c2-f3e4-44bf-89be-4f47b63fa35e", "Robert Fox", 0m, 220, "creative_css_design.svg", false, 4200m, 0.94m, 1050m, "Creative CSS Design" },
                    { "d3cf5240-ff63-43c8-b118-f67ecde6ff22", "Jenny Wilson", 0m, 160, "jmeter_performance_testing.svg", false, 3100m, 0.92m, 14.50m, "Learn JMETER from Scratch on Live Apps - Performance Testing" },
                    { "ed744a1e-82ae-463d-9bde-7149360362f3", "Marvin McKinney", 0m, 160, "ios_swift_dev.svg", false, 3100m, 0.92m, 15.99m, "iOS & Swift - The Complete iOS App Development Bootcamp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "19b557d0-bdab-456f-9595-2565a82fb7af");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "4f7a0a9e-3d31-4dfc-b3f8-77f736187896");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "5fe860ae-42e1-48b5-813f-90263f8fe9d4");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "6d58c745-089d-4b25-ad1e-741e2979f275");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "759375a6-fdd9-4f01-ad9a-9348c783fb98");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "8af1b321-8eda-4d4d-acf5-af1e79a4086f");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "cc7144c2-f3e4-44bf-89be-4f47b63fa35e");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d3cf5240-ff63-43c8-b118-f67ecde6ff22");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "ed744a1e-82ae-463d-9bde-7149360362f3");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "AspNetUsers",
                newName: "ProfileImagePath");

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
    }
}
