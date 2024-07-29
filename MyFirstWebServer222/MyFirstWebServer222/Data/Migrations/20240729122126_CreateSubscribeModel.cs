using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstWebServer222.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateSubscribeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Subscribers",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subscribers",
                newName: "id");
        }
    }
}
