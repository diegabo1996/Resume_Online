using Microsoft.EntityFrameworkCore.Migrations;

namespace LCode.Resume.Online.DataBase.Migrations
{
    public partial class CategoryPortfolioedited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "resume",
                table: "Category_Portfolio",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code_Figure",
                schema: "resume",
                table: "Category_Portfolio",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Group_Code",
                schema: "resume",
                table: "Category_Portfolio",
                type: "varchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group_Code",
                schema: "resume",
                table: "Category_Portfolio");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "resume",
                table: "Category_Portfolio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code_Figure",
                schema: "resume",
                table: "Category_Portfolio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);
        }
    }
}
