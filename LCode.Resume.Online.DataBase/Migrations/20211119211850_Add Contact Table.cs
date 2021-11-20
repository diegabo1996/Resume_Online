using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCode.Resume.Online.DataBase.Migrations
{
    public partial class AddContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact_Registry",
                schema: "resume",
                columns: table => new
                {
                    Guid_Contact = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    EMail = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cellphone = table.Column<string>(type: "varchar(50)", nullable: false),
                    Subject = table.Column<string>(type: "varchar(100)", nullable: false),
                    Message = table.Column<string>(type: "varchar(max)", nullable: false),
                    DateTimeRegistred = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Notified = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_Registry", x => x.Guid_Contact);
                    table.ForeignKey(
                        name: "FK_Contact_Registry_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Registry_Guid_Resume",
                schema: "resume",
                table: "Contact_Registry",
                column: "Guid_Resume");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact_Registry",
                schema: "resume");
        }
    }
}
