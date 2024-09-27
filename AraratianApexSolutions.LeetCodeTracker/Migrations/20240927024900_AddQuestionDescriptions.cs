using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AraratianApexSolutions.LeetCodeTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddQuestionDescriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionDescription_Questions_QuestionNumber",
                        column: x => x.QuestionNumber,
                        principalTable: "Questions",
                        principalColumn: "Number");
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionDescription_QuestionNumber",
                table: "QuestionDescription",
                column: "QuestionNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionDescription");
        }
    }
}
