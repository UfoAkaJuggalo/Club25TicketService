using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_EF_SQLdB.Migrations
{
    /// <inheritdoc />
    public partial class cleanupticketsremove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketPool_TicketMediaType",
                table: "TicketPool");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketPool_TicketType",
                table: "TicketPool");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketPool_Vendor",
                table: "TicketPool");

            migrationBuilder.DropTable(
                name: "TicketMediaType");

            migrationBuilder.DropTable(
                name: "TicketType");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_TicketPool_idTicketMedia",
                table: "TicketPool");

            migrationBuilder.DropIndex(
                name: "IX_TicketPool_idTicketType",
                table: "TicketPool");

            migrationBuilder.DropIndex(
                name: "IX_TicketPool_idVendor",
                table: "TicketPool");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "TicketPool");

            migrationBuilder.DropColumn(
                name: "idPrice",
                table: "TicketPool");

            migrationBuilder.DropColumn(
                name: "idTicketMedia",
                table: "TicketPool");

            migrationBuilder.DropColumn(
                name: "idTicketType",
                table: "TicketPool");

            migrationBuilder.DropColumn(
                name: "idVendor",
                table: "TicketPool");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "amount",
                table: "TicketPool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idPrice",
                table: "TicketPool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTicketMedia",
                table: "TicketPool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTicketType",
                table: "TicketPool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idVendor",
                table: "TicketPool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TicketMediaType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketMediaType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TicketType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    averageProfit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    hash = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    www = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketPool_idTicketMedia",
                table: "TicketPool",
                column: "idTicketMedia");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPool_idTicketType",
                table: "TicketPool",
                column: "idTicketType");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPool_idVendor",
                table: "TicketPool",
                column: "idVendor");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPool_TicketMediaType",
                table: "TicketPool",
                column: "idTicketMedia",
                principalTable: "TicketMediaType",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPool_TicketType",
                table: "TicketPool",
                column: "idTicketType",
                principalTable: "TicketType",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPool_Vendor",
                table: "TicketPool",
                column: "idVendor",
                principalTable: "Vendor",
                principalColumn: "id");
        }
    }
}
