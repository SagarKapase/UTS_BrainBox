using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTS_BrainBox.Migrations
{
    /// <inheritdoc />
    public partial class allQuizzesTFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Attempts",
                table: "AllQuizzes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "AllQuizzes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AllQuizzes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attempts",
                table: "AllQuizzes");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "AllQuizzes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AllQuizzes");
        }
    }
}
