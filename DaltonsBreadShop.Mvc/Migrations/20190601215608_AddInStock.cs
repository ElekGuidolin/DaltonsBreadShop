using Microsoft.EntityFrameworkCore.Migrations;

namespace DaltonsBreadShop.Mvc.Migrations
{
    public partial class AddInStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Breads",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Breads");
        }
    }
}
