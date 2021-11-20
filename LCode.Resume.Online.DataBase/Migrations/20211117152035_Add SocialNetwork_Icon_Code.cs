using Microsoft.EntityFrameworkCore.Migrations;

namespace LCode.Resume.Online.DataBase.Migrations
{
    public partial class AddSocialNetwork_Icon_Code : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialNetwork",
                schema: "resume",
                table: "Social_Networks",
                newName: "SocialNetwork_Icon_Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialNetwork_Icon_Code",
                schema: "resume",
                table: "Social_Networks",
                newName: "SocialNetwork");
        }
    }
}
