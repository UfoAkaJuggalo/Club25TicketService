using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_EF_SQLdB.Migrations
{
    /// <inheritdoc />
    public partial class addlineups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDescriptions_Event_EventId",
                table: "EventDescriptions");

            migrationBuilder.DropTable(
                name: "EventArtist");

            migrationBuilder.DropTable(
                name: "FeaturedEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventDescriptions",
                table: "EventDescriptions");

            migrationBuilder.RenameTable(
                name: "EventDescriptions",
                newName: "EventDescription");

            migrationBuilder.RenameIndex(
                name: "IX_EventDescriptions_EventId",
                table: "EventDescription",
                newName: "IX_EventDescription_EventId");

            migrationBuilder.AddColumn<int>(
                name: "LineupId",
                table: "SponsorContract",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventDescription",
                table: "EventDescription",
                column: "id");

            migrationBuilder.CreateTable(
                name: "EventStageLineup",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStageLineup", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventStageLineup_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_EventStageLineup_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventStageDescription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptiontext = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    banddescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventStageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStageDescription", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventStageDescription_EventStageLineup_EventStageId",
                        column: x => x.EventStageId,
                        principalTable: "EventStageLineup",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "EventStageLineupTag",
                columns: table => new
                {
                    EventStageLineupsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStageLineupTag", x => new { x.EventStageLineupsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_EventStageLineupTag_EventStageLineup_EventStageLineupsId",
                        column: x => x.EventStageLineupsId,
                        principalTable: "EventStageLineup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventStageLineupTag_Tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineupEntry",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    starttime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BandId = table.Column<int>(type: "int", nullable: false),
                    EventStageLineupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineupEntry", x => x.id);
                    table.ForeignKey(
                        name: "FK_LineupEntry_Band_BandId",
                        column: x => x.BandId,
                        principalTable: "Band",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_LineupEntry_EventStageLineup_EventStageLineupId",
                        column: x => x.EventStageLineupId,
                        principalTable: "EventStageLineup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContract_LineupId",
                table: "SponsorContract",
                column: "LineupId");

            migrationBuilder.CreateIndex(
                name: "IX_EventStageDescription_EventStageId",
                table: "EventStageDescription",
                column: "EventStageId");

            migrationBuilder.CreateIndex(
                name: "IX_EventStageLineup_EventId",
                table: "EventStageLineup",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventStageLineup_StageId",
                table: "EventStageLineup",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_EventStageLineupTag_TagsId",
                table: "EventStageLineupTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_LineupEntry_BandId",
                table: "LineupEntry",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_LineupEntry_EventStageLineupId",
                table: "LineupEntry",
                column: "EventStageLineupId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventDescription_Event_EventId",
                table: "EventDescription",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SponsorContract_EventStageLineup_LineupId",
                table: "SponsorContract",
                column: "LineupId",
                principalTable: "EventStageLineup",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDescription_Event_EventId",
                table: "EventDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_SponsorContract_EventStageLineup_LineupId",
                table: "SponsorContract");

            migrationBuilder.DropTable(
                name: "EventStageDescription");

            migrationBuilder.DropTable(
                name: "EventStageLineupTag");

            migrationBuilder.DropTable(
                name: "LineupEntry");

            migrationBuilder.DropTable(
                name: "EventStageLineup");

            migrationBuilder.DropIndex(
                name: "IX_SponsorContract_LineupId",
                table: "SponsorContract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventDescription",
                table: "EventDescription");

            migrationBuilder.DropColumn(
                name: "LineupId",
                table: "SponsorContract");

            migrationBuilder.RenameTable(
                name: "EventDescription",
                newName: "EventDescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_EventDescription_EventId",
                table: "EventDescriptions",
                newName: "IX_EventDescriptions_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventDescriptions",
                table: "EventDescriptions",
                column: "id");

            migrationBuilder.CreateTable(
                name: "EventArtist",
                columns: table => new
                {
                    idArtist = table.Column<int>(type: "int", nullable: false),
                    idEvent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_EventArtists_Artist",
                        column: x => x.idArtist,
                        principalTable: "Artist",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventArtists_Event",
                        column: x => x.idEvent,
                        principalTable: "Event",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "FeaturedEvent",
                columns: table => new
                {
                    idEvent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_FeaturedEvents_Event",
                        column: x => x.idEvent,
                        principalTable: "Event",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventArtist_idArtist",
                table: "EventArtist",
                column: "idArtist");

            migrationBuilder.CreateIndex(
                name: "IX_EventArtist_idEvent",
                table: "EventArtist",
                column: "idEvent");

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedEvent_idEvent",
                table: "FeaturedEvent",
                column: "idEvent");

            migrationBuilder.AddForeignKey(
                name: "FK_EventDescriptions_Event_EventId",
                table: "EventDescriptions",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
