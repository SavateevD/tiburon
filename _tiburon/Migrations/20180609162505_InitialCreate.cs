using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _tiburon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneMarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneMarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Respondents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respondents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RespondetnPhoneMark",
                columns: table => new
                {
                    PhoneMarkId = table.Column<int>(nullable: false),
                    RespondentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespondetnPhoneMark", x => new { x.PhoneMarkId, x.RespondentId });
                    table.ForeignKey(
                        name: "FK_RespondetnPhoneMark_PhoneMarks_PhoneMarkId",
                        column: x => x.PhoneMarkId,
                        principalTable: "PhoneMarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RespondetnPhoneMark_Respondents_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RespondetnPhoneMark_RespondentId",
                table: "RespondetnPhoneMark",
                column: "RespondentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespondetnPhoneMark");

            migrationBuilder.DropTable(
                name: "PhoneMarks");

            migrationBuilder.DropTable(
                name: "Respondents");
        }
    }
}
