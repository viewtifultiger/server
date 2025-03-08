using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xiaolongshu2Model.Migrations
{
    /// <inheritdoc />
    public partial class long_lat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "lat",
                table: "City",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "lon",
                table: "City",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lat",
                table: "City");

            migrationBuilder.DropColumn(
                name: "lon",
                table: "City");
        }
    }
}
