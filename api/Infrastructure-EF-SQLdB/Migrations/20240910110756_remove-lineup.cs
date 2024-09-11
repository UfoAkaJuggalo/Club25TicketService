using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_EF_SQLdB.Migrations
{
    /// <inheritdoc />
    public partial class removelineup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SponsorContract_Lineup_LineupId",
                table: "SponsorContract");

            migrationBuilder.DropTable(
                name: "Lineup");

            migrationBuilder.DropIndex(
                name: "IX_SponsorContract_LineupId",
                table: "SponsorContract");

            migrationBuilder.DropColumn(
                name: "LineupId",
                table: "SponsorContract");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LineupId",
                table: "SponsorContract",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Lineup",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idArtist = table.Column<int>(type: "int", nullable: true),
                    IdEventNavigationId = table.Column<int>(type: "int", nullable: false),
                    idStage = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    idEvent = table.Column<int>(type: "int", nullable: false),
                    startTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stopTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lineup", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lineup_Artist",
                        column: x => x.idArtist,
                        principalTable: "Artist",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lineup_Event_IdEventNavigationId",
                        column: x => x.IdEventNavigationId,
                        principalTable: "Event",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lineup_Stage_idStage",
                        column: x => x.idStage,
                        principalTable: "Stage",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContract_LineupId",
                table: "SponsorContract",
                column: "LineupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineup_idArtist",
                table: "Lineup",
                column: "idArtist");

            migrationBuilder.CreateIndex(
                name: "IX_Lineup_IdEventNavigationId",
                table: "Lineup",
                column: "IdEventNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineup_idStage",
                table: "Lineup",
                column: "idStage");

            migrationBuilder.AddForeignKey(
                name: "FK_SponsorContract_Lineup_LineupId",
                table: "SponsorContract",
                column: "LineupId",
                principalTable: "Lineup",
                principalColumn: "id");
        }
    }
}
