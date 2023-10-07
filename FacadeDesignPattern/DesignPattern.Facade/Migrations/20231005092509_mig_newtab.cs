using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignPattern.Facade.Migrations
{
    public partial class mig_newtab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoustumerId = table.Column<int>(type: "int", nullable: false),
                    CoustemerCoustumerId = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Coustemers_CoustemerCoustumerId",
                        column: x => x.CoustemerCoustumerId,
                        principalTable: "Coustemers",
                        principalColumn: "CoustumerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CoustemerCoustumerId",
                table: "Order",
                column: "CoustemerCoustumerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
