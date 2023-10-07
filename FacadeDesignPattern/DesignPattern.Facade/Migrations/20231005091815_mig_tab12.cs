using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignPattern.Facade.Migrations
{
    public partial class mig_tab12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coustemers",
                columns: table => new
                {
                    CoustumerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoustumerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoustumerSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoustumerAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoustumerCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coustemers", x => x.CoustumerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStock = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCatagory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coustemers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
