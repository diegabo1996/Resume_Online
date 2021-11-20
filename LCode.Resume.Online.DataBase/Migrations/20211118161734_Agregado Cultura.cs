using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCode.Resume.Online.DataBase.Migrations
{
    public partial class AgregadoCultura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                schema: "resume",
                table: "General_Information");

            migrationBuilder.DropColumn(
                name: "Title",
                schema: "resume",
                table: "General_Information");

            migrationBuilder.RenameColumn(
                name: "Guid_Resume_Section",
                schema: "resume",
                table: "Resume_Knowledge_General",
                newName: "Guid_Resume_Knowledge_General");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "WhatIDo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Social_Networks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Section",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Knowledge_General",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Extra_Skills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Portfolio",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Category_Portfolio",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Culture_Resume",
                schema: "resume",
                columns: table => new
                {
                    Guid_Culture_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Culture_Code = table.Column<string>(type: "varchar(10)", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culture_Resume", x => x.Guid_Culture_Resume);
                    table.ForeignKey(
                        name: "FK_Culture_Resume_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "About_Info",
                schema: "resume",
                columns: table => new
                {
                    Guid_About_Info = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Culture_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About_Info", x => x.Guid_About_Info);
                    table.ForeignKey(
                        name: "FK_About_Info_Culture_Resume_Guid_Culture_Resume",
                        column: x => x.Guid_Culture_Resume,
                        principalSchema: "resume",
                        principalTable: "Culture_Resume",
                        principalColumn: "Guid_Culture_Resume",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_About_Info_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WhatIDo_Guid_Culture_Resume",
                schema: "resume",
                table: "WhatIDo",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Social_Networks_Guid_Culture_Resume",
                schema: "resume",
                table: "Social_Networks",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_Section_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Section",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_Knowledge_General_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Knowledge_General",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_Extra_Skills_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Extra_Skills",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_Guid_Culture_Resume",
                schema: "resume",
                table: "Portfolio",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Portfolio_Guid_Culture_Resume",
                schema: "resume",
                table: "Category_Portfolio",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_About_Info_Guid_Culture_Resume",
                schema: "resume",
                table: "About_Info",
                column: "Guid_Culture_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_About_Info_Guid_Resume",
                schema: "resume",
                table: "About_Info",
                column: "Guid_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Culture_Resume_Guid_Resume",
                schema: "resume",
                table: "Culture_Resume",
                column: "Guid_Resume");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Portfolio_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Category_Portfolio",
                column: "Guid_Culture_Resume",
                principalSchema: "resume",
                principalTable: "Culture_Resume",
                principalColumn: "Guid_Culture_Resume",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Portfolio",
                column: "Guid_Culture_Resume",
                principalSchema: "resume",
                principalTable: "Culture_Resume",
                principalColumn: "Guid_Culture_Resume",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Resume_Extra_Skills_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Extra_Skills",
                column: "Guid_Culture_Resume",
                principalSchema: "resume",
                principalTable: "Culture_Resume",
                principalColumn: "Guid_Culture_Resume",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Resume_Knowledge_General_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Knowledge_General",
                column: "Guid_Culture_Resume",
                principalSchema: "resume",
                principalTable: "Culture_Resume",
                principalColumn: "Guid_Culture_Resume",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Resume_Section_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Section",
                column: "Guid_Culture_Resume",
                principalSchema: "resume",
                principalTable: "Culture_Resume",
                principalColumn: "Guid_Culture_Resume",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Social_Networks_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Social_Networks",
                column: "Guid_Culture_Resume",
                principalSchema: "resume",
                principalTable: "Culture_Resume",
                principalColumn: "Guid_Culture_Resume",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_WhatIDo_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "WhatIDo",
                column: "Guid_Culture_Resume",
                principalSchema: "resume",
                principalTable: "Culture_Resume",
                principalColumn: "Guid_Culture_Resume",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Portfolio_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Category_Portfolio");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolio_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Portfolio");

            migrationBuilder.DropForeignKey(
                name: "FK_Resume_Extra_Skills_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Extra_Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Resume_Knowledge_General_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Knowledge_General");

            migrationBuilder.DropForeignKey(
                name: "FK_Resume_Section_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Social_Networks_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "Social_Networks");

            migrationBuilder.DropForeignKey(
                name: "FK_WhatIDo_Culture_Resume_Guid_Culture_Resume",
                schema: "resume",
                table: "WhatIDo");

            migrationBuilder.DropTable(
                name: "About_Info",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "Culture_Resume",
                schema: "resume");

            migrationBuilder.DropIndex(
                name: "IX_WhatIDo_Guid_Culture_Resume",
                schema: "resume",
                table: "WhatIDo");

            migrationBuilder.DropIndex(
                name: "IX_Social_Networks_Guid_Culture_Resume",
                schema: "resume",
                table: "Social_Networks");

            migrationBuilder.DropIndex(
                name: "IX_Resume_Section_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Section");

            migrationBuilder.DropIndex(
                name: "IX_Resume_Knowledge_General_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Knowledge_General");

            migrationBuilder.DropIndex(
                name: "IX_Resume_Extra_Skills_Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Extra_Skills");

            migrationBuilder.DropIndex(
                name: "IX_Portfolio_Guid_Culture_Resume",
                schema: "resume",
                table: "Portfolio");

            migrationBuilder.DropIndex(
                name: "IX_Category_Portfolio_Guid_Culture_Resume",
                schema: "resume",
                table: "Category_Portfolio");

            migrationBuilder.DropColumn(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "WhatIDo");

            migrationBuilder.DropColumn(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Social_Networks");

            migrationBuilder.DropColumn(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Section");

            migrationBuilder.DropColumn(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Knowledge_General");

            migrationBuilder.DropColumn(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Resume_Extra_Skills");

            migrationBuilder.DropColumn(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Portfolio");

            migrationBuilder.DropColumn(
                name: "Guid_Culture_Resume",
                schema: "resume",
                table: "Category_Portfolio");

            migrationBuilder.RenameColumn(
                name: "Guid_Resume_Knowledge_General",
                schema: "resume",
                table: "Resume_Knowledge_General",
                newName: "Guid_Resume_Section");

            migrationBuilder.AddColumn<string>(
                name: "About",
                schema: "resume",
                table: "General_Information",
                type: "varchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "resume",
                table: "General_Information",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");
        }
    }
}
