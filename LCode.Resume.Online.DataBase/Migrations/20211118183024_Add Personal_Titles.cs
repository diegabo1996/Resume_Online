using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCode.Resume.Online.DataBase.Migrations
{
    public partial class AddPersonal_Titles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personal_Titles",
                schema: "resume",
                columns: table => new
                {
                    Guid_Personal_Title = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Culture_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", nullable: false),
                    Principal = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal_Titles", x => x.Guid_Personal_Title);
                    table.ForeignKey(
                        name: "FK_Personal_Titles_Culture_Resume_Guid_Culture_Resume",
                        column: x => x.Guid_Culture_Resume,
                        principalSchema: "resume",
                        principalTable: "Culture_Resume",
                        principalColumn: "Guid_Culture_Resume",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personal_Titles_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Titles_Guid_Culture_Resume",
                schema: "resume",
                table: "Personal_Titles",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Titles_Guid_Resume",
                schema: "resume",
                table: "Personal_Titles",
                column: "Guid_Resume");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personal_Titles",
                schema: "resume");
        }
    }
}
