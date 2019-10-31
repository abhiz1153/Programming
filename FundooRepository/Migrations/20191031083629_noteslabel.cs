using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class noteslabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Labels");

            migrationBuilder.CreateTable(
                name: "NotesLabelModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LableId = table.Column<int>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotesLabelModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotesLabelModels");

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "Labels",
                nullable: false,
                defaultValue: 0);
        }
    }
}
