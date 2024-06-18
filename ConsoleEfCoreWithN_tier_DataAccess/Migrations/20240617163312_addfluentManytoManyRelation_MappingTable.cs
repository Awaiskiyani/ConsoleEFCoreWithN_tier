using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleEfCoreWithN_tier_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addfluentManytoManyRelation_MappingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentBookAuthorMap",
                columns: table => new
                {
                    BoodId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentBookAuthorMap", x => new { x.AuthorId, x.BoodId });
                    table.ForeignKey(
                        name: "FK_FluentBookAuthorMap_FluentAuthors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "FluentAuthors",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluentBookAuthorMap_FluentBook_BoodId",
                        column: x => x.BoodId,
                        principalTable: "FluentBook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentBookAuthorMap_BoodId",
                table: "FluentBookAuthorMap",
                column: "BoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentBookAuthorMap");
        }
    }
}
