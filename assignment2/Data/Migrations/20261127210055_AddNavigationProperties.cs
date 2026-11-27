using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment2.Migrations
{
    /// <inheritdoc />
    public partial class AddNavigationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MortgageCases_CustomerId",
                table: "MortgageCases",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MortgageCases_Customers_CustomerId",
                table: "MortgageCases",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MortgageCases_Customers_CustomerId",
                table: "MortgageCases");

            migrationBuilder.DropIndex(
                name: "IX_MortgageCases_CustomerId",
                table: "MortgageCases");
        }
    }
}
