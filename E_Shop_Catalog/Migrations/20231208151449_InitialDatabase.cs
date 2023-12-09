using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Shop_Catalog.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Category_Name = table.Column<string>(type: "text", nullable: false),
                    Proccesor = table.Column<string>(type: "text", nullable: false),
                    Graphic = table.Column<string>(type: "text", nullable: false),
                    GPY = table.Column<int>(type: "integer", nullable: false),
                    Ram_Type = table.Column<string>(type: "text", nullable: false),
                    Ram_Name = table.Column<string>(type: "text", nullable: false),
                    Quantity_Ram = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Id_Category = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "ProductModel");
        }
    }
}
