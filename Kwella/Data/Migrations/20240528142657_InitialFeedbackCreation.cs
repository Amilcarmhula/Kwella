using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kwella.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialFeedbackCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    feedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    feedContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    feedEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    feedMensagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
