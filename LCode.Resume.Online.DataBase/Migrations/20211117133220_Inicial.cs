using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCode.Resume.Online.DataBase.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "resume");

            migrationBuilder.CreateTable(
                name: "Category_Portfolio",
                schema: "resume",
                columns: table => new
                {
                    Guid_Category_Portolio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code_Figure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_Portfolio", x => x.Guid_Category_Portolio);
                });

            migrationBuilder.CreateTable(
                name: "General_Information",
                schema: "resume",
                columns: table => new
                {
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Domain = table.Column<string>(type: "varchar(500)", nullable: true),
                    Name = table.Column<string>(type: "varchar(500)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(500)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualLocation = table.Column<string>(type: "varchar(500)", nullable: false),
                    EMail = table.Column<string>(type: "varchar(150)", nullable: false),
                    CellPhoneNumber = table.Column<string>(type: "varchar(50)", nullable: false),
                    About = table.Column<string>(type: "varchar(max)", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General_Information", x => x.Guid_Resume);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio",
                schema: "resume",
                columns: table => new
                {
                    Guid_Portfolio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Category_Portolio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", nullable: false),
                    Description = table.Column<string>(type: "varchar(250)", nullable: false),
                    Link_Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.Guid_Portfolio);
                    table.ForeignKey(
                        name: "FK_Portfolio_Category_Portfolio_Guid_Category_Portolio",
                        column: x => x.Guid_Category_Portolio,
                        principalSchema: "resume",
                        principalTable: "Category_Portfolio",
                        principalColumn: "Guid_Category_Portolio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Portfolio_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resume_Extra_Skills",
                schema: "resume",
                columns: table => new
                {
                    Guid_Resume_Extra_Skill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Skill_Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Skill_Name = table.Column<string>(type: "varchar(250)", nullable: false),
                    Percent_Experience = table.Column<short>(type: "smallint", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume_Extra_Skills", x => x.Guid_Resume_Extra_Skill);
                    table.ForeignKey(
                        name: "FK_Resume_Extra_Skills_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resume_Knowledge_General",
                schema: "resume",
                columns: table => new
                {
                    Guid_Resume_Section = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(75)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume_Knowledge_General", x => x.Guid_Resume_Section);
                    table.ForeignKey(
                        name: "FK_Resume_Knowledge_General_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resume_Section",
                schema: "resume",
                columns: table => new
                {
                    Guid_Resume_Section = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Current = table.Column<bool>(type: "bit", nullable: false),
                    Institution_Company = table.Column<string>(type: "varchar(250)", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume_Section", x => x.Guid_Resume_Section);
                    table.ForeignKey(
                        name: "FK_Resume_Section_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Social_Networks",
                schema: "resume",
                columns: table => new
                {
                    Guid_SocialNetwork = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialNetwork = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social_Networks", x => x.Guid_SocialNetwork);
                    table.ForeignKey(
                        name: "FK_Social_Networks_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WhatIDo",
                schema: "resume",
                columns: table => new
                {
                    Guid_WhatIDo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid_Resume = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Icon = table.Column<string>(type: "varchar(50)", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DateTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatIDo", x => x.Guid_WhatIDo);
                    table.ForeignKey(
                        name: "FK_WhatIDo_General_Information_Guid_Resume",
                        column: x => x.Guid_Resume,
                        principalSchema: "resume",
                        principalTable: "General_Information",
                        principalColumn: "Guid_Resume",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_Guid_Category_Portolio",
                schema: "resume",
                table: "Portfolio",
                column: "Guid_Category_Portolio");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_Guid_Resume",
                schema: "resume",
                table: "Portfolio",
                column: "Guid_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_Extra_Skills_Guid_Resume",
                schema: "resume",
                table: "Resume_Extra_Skills",
                column: "Guid_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_Knowledge_General_Guid_Resume",
                schema: "resume",
                table: "Resume_Knowledge_General",
                column: "Guid_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_Section_Guid_Resume",
                schema: "resume",
                table: "Resume_Section",
                column: "Guid_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_Social_Networks_Guid_Resume",
                schema: "resume",
                table: "Social_Networks",
                column: "Guid_Resume");

            migrationBuilder.CreateIndex(
                name: "IX_WhatIDo_Guid_Resume",
                schema: "resume",
                table: "WhatIDo",
                column: "Guid_Resume");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolio",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "Resume_Extra_Skills",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "Resume_Knowledge_General",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "Resume_Section",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "Social_Networks",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "WhatIDo",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "Category_Portfolio",
                schema: "resume");

            migrationBuilder.DropTable(
                name: "General_Information",
                schema: "resume");
        }
    }
}
