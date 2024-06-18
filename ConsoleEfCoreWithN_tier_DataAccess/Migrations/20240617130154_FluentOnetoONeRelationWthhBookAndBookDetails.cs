using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleEfCoreWithN_tier_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FluentOnetoONeRelationWthhBookAndBookDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "Fluent_BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_FluentBook_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id",
                principalTable: "FluentBook",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_FluentBook_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "Fluent_BookDetails");
        }
    }
}
