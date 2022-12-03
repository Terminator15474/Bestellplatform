using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bestellplatform.Data.Migrations
{
    public partial class secondUpdateOfFoodItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "FoodItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "FoodItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
