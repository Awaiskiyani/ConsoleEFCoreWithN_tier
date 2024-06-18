using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleEfCoreWithN_tier_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFleuntOneToManyRelationshipBetweenBookAndPublisher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "FluentBook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentBook_Publisher_Id",
                table: "FluentBook",
                column: "Publisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBook_FluentPublishers_Publisher_Id",
                table: "FluentBook",
                column: "Publisher_Id",
                principalTable: "FluentPublishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBook_FluentPublishers_Publisher_Id",
                table: "FluentBook");

            migrationBuilder.DropIndex(
                name: "IX_FluentBook_Publisher_Id",
                table: "FluentBook");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "FluentBook");
        }
    }
}
