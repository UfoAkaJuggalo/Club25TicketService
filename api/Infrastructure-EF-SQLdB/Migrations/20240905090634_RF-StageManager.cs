using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_EF_SQLdB.Migrations
{
    /// <inheritdoc />
    public partial class RFStageManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StageToStageManager");

            migrationBuilder.AddColumn<int>(
                name: "StageId",
                table: "StageManager",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StageManager_StageId",
                table: "StageManager",
                column: "StageId");

            migrationBuilder.AddForeignKey(
                name: "FK_StageManager_Stage_StageId",
                table: "StageManager",
                column: "StageId",
                principalTable: "Stage",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StageManager_Stage_StageId",
                table: "StageManager");

            migrationBuilder.DropIndex(
                name: "IX_StageManager_StageId",
                table: "StageManager");

            migrationBuilder.DropColumn(
                name: "StageId",
                table: "StageManager");

            migrationBuilder.CreateTable(
                name: "StageToStageManager",
                columns: table => new
                {
                    StageId = table.Column<int>(type: "int", nullable: false),
                    StageManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageToStageManager", x => new { x.StageId, x.StageManagerId });
                    table.ForeignKey(
                        name: "FK_StageToStageManager_StageManager_StageManagerId",
                        column: x => x.StageManagerId,
                        principalTable: "StageManager",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_StageToStageManager_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StageToStageManager_StageManagerId",
                table: "StageToStageManager",
                column: "StageManagerId");
        }
    }
}
