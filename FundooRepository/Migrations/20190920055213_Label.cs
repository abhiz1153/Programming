using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class Label : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Register_Email",
                table: "Notes");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Notes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Labels_Register_Email",
                        column: x => x.Email,
                        principalTable: "Register",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Labels_Email",
                table: "Labels",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Register_Email",
                table: "Notes",
                column: "Email",
                principalTable: "Register",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Register_Email",
                table: "Notes");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Notes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Register_Email",
                table: "Notes",
                column: "Email",
                principalTable: "Register",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
