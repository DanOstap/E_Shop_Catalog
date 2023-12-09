using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace E_Shop_Catalog.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Computers_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    table.PrimaryKey("PK_Computers", x => x.Computers_Id);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Laptops_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category_Name = table.Column<string>(type: "text", nullable: false),
                    Proccesor = table.Column<string>(type: "text", nullable: false),
                    Graphic = table.Column<string>(type: "text", nullable: false),
                    GPY = table.Column<int>(type: "integer", nullable: false),
                    Ram_Type = table.Column<string>(type: "text", nullable: false),
                    Ram_Name = table.Column<string>(type: "text", nullable: false),
                    Quantity_Ram = table.Column<int>(type: "integer", nullable: false),
                    Monitor = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Laptops_Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Category_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
