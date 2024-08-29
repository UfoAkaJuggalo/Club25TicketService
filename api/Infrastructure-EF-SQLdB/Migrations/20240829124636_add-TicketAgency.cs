using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_EF_SQLdB.Migrations
{
    /// <inheritdoc />
    public partial class addTicketAgency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accountants_User_AccountantsId",
                table: "Accountants");

            migrationBuilder.CreateTable(
                name: "TicketAgency",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    city = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketAgency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TicketAgent",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    city = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TicketAgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketAgent", x => x.id);
                    table.ForeignKey(
                        name: "FK_TicketAgent_TicketAgency_TicketAgencyId",
                        column: x => x.TicketAgencyId,
                        principalTable: "TicketAgency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketAgent_TicketAgencyId",
                table: "TicketAgent",
                column: "TicketAgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accountants_TicketAgent_AccountantsId",
                table: "Accountants",
                column: "AccountantsId",
                principalTable: "TicketAgent",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accountants_TicketAgent_AccountantsId",
                table: "Accountants");

            migrationBuilder.DropTable(
                name: "TicketAgent");

            migrationBuilder.DropTable(
                name: "TicketAgency");

            migrationBuilder.AddForeignKey(
                name: "FK_Accountants_User_AccountantsId",
                table: "Accountants",
                column: "AccountantsId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
