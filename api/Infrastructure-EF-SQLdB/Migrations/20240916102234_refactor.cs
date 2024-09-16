using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_EF_SQLdB.Migrations
{
    /// <inheritdoc />
    public partial class refactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Client_ClientId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Policy");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ClientId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Ticket");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_person = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                    table.ForeignKey(
                        name: "FK_Client_Person",
                        column: x => x.id_person,
                        principalTable: "Person",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Policy",
                columns: table => new
                {
                    idPermission = table.Column<int>(type: "int", nullable: false),
                    idUserGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Policy_Permission",
                        column: x => x.idPermission,
                        principalTable: "Permission",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Policy_UserGroup",
                        column: x => x.idUserGroup,
                        principalTable: "UserGroup",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    id_group = table.Column<int>(type: "int", nullable: false),
                    id_person = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Person",
                        column: x => x.id_person,
                        principalTable: "Person",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_User_UserGroup",
                        column: x => x.id_group,
                        principalTable: "UserGroup",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ClientId",
                table: "Ticket",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_id_person",
                table: "Client",
                column: "id_person");

            migrationBuilder.CreateIndex(
                name: "IX_Policy_idPermission",
                table: "Policy",
                column: "idPermission");

            migrationBuilder.CreateIndex(
                name: "IX_Policy_idUserGroup",
                table: "Policy",
                column: "idUserGroup");

            migrationBuilder.CreateIndex(
                name: "IX_User_id_group",
                table: "User",
                column: "id_group");

            migrationBuilder.CreateIndex(
                name: "IX_User_id_person",
                table: "User",
                column: "id_person");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Client_ClientId",
                table: "Ticket",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "id");
        }
    }
}
