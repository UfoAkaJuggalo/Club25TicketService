using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_EF_SQLdB.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stagename = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Band",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Band", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BookingAgency",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    city = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingAgency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true)
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
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PromoterAgency",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    city = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoterAgency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    city = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TicketAgency",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
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
                name: "Vendor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    adres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    www = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    hash = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    averageProfit = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    gpslatitude = table.Column<decimal>(type: "decimal(18,15)", precision: 18, scale: 15, nullable: true),
                    gpslongitude = table.Column<decimal>(type: "decimal(18,15)", precision: 18, scale: 15, nullable: true),
                    email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    city = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ArtistDescription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptiontext = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    banddescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistDescription", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArtistDescription_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArtistBand",
                columns: table => new
                {
                    BandsId = table.Column<int>(type: "int", nullable: false),
                    MembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistBand", x => new { x.BandsId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_ArtistBand_Artist_MembersId",
                        column: x => x.MembersId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistBand_Band_BandsId",
                        column: x => x.BandsId,
                        principalTable: "Band",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BandDescription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptiontext = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    banddescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandDescription", x => x.id);
                    table.ForeignKey(
                        name: "FK_BandDescription_Band_BandId",
                        column: x => x.BandId,
                        principalTable: "Band",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Booker",
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
                    BookingAgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booker", x => x.id);
                    table.ForeignKey(
                        name: "FK_Booker_BookingAgency_BookingAgencyId",
                        column: x => x.BookingAgencyId,
                        principalTable: "BookingAgency",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BookingAgencyBand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceMin_Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    PriceMin_Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceMax_Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    PriceMax_Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BandId = table.Column<int>(type: "int", nullable: false),
                    BookingAgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingAgencyBand", x => x.id);
                    table.ForeignKey(
                        name: "FK_BookingAgencyBand_Band_BandId",
                        column: x => x.BandId,
                        principalTable: "Band",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_BookingAgencyBand_BookingAgency_BookingAgencyId",
                        column: x => x.BookingAgencyId,
                        principalTable: "BookingAgency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventArtist",
                columns: table => new
                {
                    idEvent = table.Column<int>(type: "int", nullable: false),
                    idArtist = table.Column<int>(type: "int", nullable: false)
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
                name: "EventDescriptions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptiontext = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    banddescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDescriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventDescriptions_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Promoter",
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
                    PromoterAgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promoter", x => x.id);
                    table.ForeignKey(
                        name: "FK_Promoter_PromoterAgency_PromoterAgencyId",
                        column: x => x.PromoterAgencyId,
                        principalTable: "PromoterAgency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SponsorDescription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptiontext = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    banddescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SponsorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorDescription", x => x.id);
                    table.ForeignKey(
                        name: "FK_SponsorDescription_Sponsor_SponsorId",
                        column: x => x.SponsorId,
                        principalTable: "Sponsor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SponsorRepresentative",
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
                    SponsorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorRepresentative", x => x.id);
                    table.ForeignKey(
                        name: "FK_SponsorRepresentative_Sponsor_SponsorId",
                        column: x => x.SponsorId,
                        principalTable: "Sponsor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtistTag",
                columns: table => new
                {
                    ArtistsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistTag", x => new { x.ArtistsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_ArtistTag_Artist_ArtistsId",
                        column: x => x.ArtistsId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistTag_Tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BandTag",
                columns: table => new
                {
                    BandsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandTag", x => new { x.BandsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_BandTag_Band_BandsId",
                        column: x => x.BandsId,
                        principalTable: "Band",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BandTag_Tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventTag",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTag", x => new { x.EventsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_EventTag_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTag_Tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromoterAgencyTicketAgency",
                columns: table => new
                {
                    PromoterAgenciesId = table.Column<int>(type: "int", nullable: false),
                    TicketAgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoterAgencyTicketAgency", x => new { x.PromoterAgenciesId, x.TicketAgencyId });
                    table.ForeignKey(
                        name: "FK_PromoterAgencyTicketAgency_PromoterAgency_PromoterAgenciesId",
                        column: x => x.PromoterAgenciesId,
                        principalTable: "PromoterAgency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromoterAgencyTicketAgency_TicketAgency_TicketAgencyId",
                        column: x => x.TicketAgencyId,
                        principalTable: "TicketAgency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Policy",
                columns: table => new
                {
                    idUserGroup = table.Column<int>(type: "int", nullable: false),
                    idPermission = table.Column<int>(type: "int", nullable: false)
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
                    id_person = table.Column<int>(type: "int", nullable: false),
                    id_group = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "TicketPool",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    idTicketType = table.Column<int>(type: "int", nullable: false),
                    idTicketMedia = table.Column<int>(type: "int", nullable: false),
                    idVendor = table.Column<int>(type: "int", nullable: false),
                    idPrice = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    dateStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    profit = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketPool", x => x.id);
                    table.ForeignKey(
                        name: "FK_TicketPool_TicketMediaType",
                        column: x => x.idTicketMedia,
                        principalTable: "TicketMediaType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TicketPool_TicketType",
                        column: x => x.idTicketType,
                        principalTable: "TicketType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TicketPool_Vendor",
                        column: x => x.idVendor,
                        principalTable: "Vendor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "EventVenue",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    VenuesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventVenue", x => new { x.EventsId, x.VenuesId });
                    table.ForeignKey(
                        name: "FK_EventVenue_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_EventVenue_Venue_VenuesId",
                        column: x => x.VenuesId,
                        principalTable: "Venue",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkType = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: true),
                    BandId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    SponsorId = table.Column<int>(type: "int", nullable: true),
                    VenueId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Link_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Link_Band_BandId",
                        column: x => x.BandId,
                        principalTable: "Band",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Link_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Link_Sponsor_SponsorId",
                        column: x => x.SponsorId,
                        principalTable: "Sponsor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Link_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: true),
                    PriceMin_Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    PriceMin_Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceMax_Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    PriceMax_Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.id);
                    table.ForeignKey(
                        name: "FK_Stage_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "StageManager",
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
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageManager", x => x.id);
                    table.ForeignKey(
                        name: "FK_StageManager_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookerBookingAgencyBand",
                columns: table => new
                {
                    BandsId = table.Column<int>(type: "int", nullable: false),
                    BookersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookerBookingAgencyBand", x => new { x.BandsId, x.BookersId });
                    table.ForeignKey(
                        name: "FK_BookerBookingAgencyBand_Booker_BookersId",
                        column: x => x.BookersId,
                        principalTable: "Booker",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookerBookingAgencyBand_BookingAgencyBand_BandsId",
                        column: x => x.BandsId,
                        principalTable: "BookingAgencyBand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accountants",
                columns: table => new
                {
                    AccountantsId = table.Column<int>(type: "int", nullable: false),
                    PromoterAgenciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accountants", x => new { x.AccountantsId, x.PromoterAgenciesId });
                    table.ForeignKey(
                        name: "FK_Accountants_PromoterAgency_PromoterAgenciesId",
                        column: x => x.PromoterAgenciesId,
                        principalTable: "PromoterAgency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accountants_TicketAgent_AccountantsId",
                        column: x => x.AccountantsId,
                        principalTable: "TicketAgent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    idClient = table.Column<int>(type: "int", nullable: false),
                    soldDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idTicketPool = table.Column<int>(type: "int", nullable: false),
                    seatNumber = table.Column<int>(type: "int", nullable: true),
                    hash = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ticket_Client",
                        column: x => x.idClient,
                        principalTable: "Client",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ticket_TicketPool",
                        column: x => x.idTicketPool,
                        principalTable: "TicketPool",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "LinkDescription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptiontext = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    banddescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkDescription", x => x.id);
                    table.ForeignKey(
                        name: "FK_LinkDescription_Link_LinkId",
                        column: x => x.LinkId,
                        principalTable: "Link",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    sectortype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sector_Link_LinkId",
                        column: x => x.LinkId,
                        principalTable: "Link",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lineup",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEvent = table.Column<int>(type: "int", nullable: false),
                    idStage = table.Column<int>(type: "int", nullable: true),
                    idArtist = table.Column<int>(type: "int", nullable: true),
                    startTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stopTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdEventNavigationId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planx = table.Column<int>(type: "int", nullable: false),
                    plany = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Seat_Sector_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sector",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectorStage",
                columns: table => new
                {
                    SectorsId = table.Column<int>(type: "int", nullable: false),
                    StagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorStage", x => new { x.SectorsId, x.StagesId });
                    table.ForeignKey(
                        name: "FK_SectorStage_Sector_SectorsId",
                        column: x => x.SectorsId,
                        principalTable: "Sector",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectorStage_Stage_StagesId",
                        column: x => x.StagesId,
                        principalTable: "Stage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SponsorContract",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sponsortype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contracttype = table.Column<int>(type: "int", maxLength: 16, nullable: false),
                    SponsorId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contracttype1 = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    LineupId = table.Column<int>(type: "int", nullable: true),
                    VenueId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorContract", x => x.id);
                    table.ForeignKey(
                        name: "FK_SponsorContract_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_SponsorContract_Lineup_LineupId",
                        column: x => x.LineupId,
                        principalTable: "Lineup",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_SponsorContract_Sponsor_SponsorId",
                        column: x => x.SponsorId,
                        principalTable: "Sponsor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponsorContract_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SponsorContractDescription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptiontext = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    banddescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SponsorContractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorContractDescription", x => x.id);
                    table.ForeignKey(
                        name: "FK_SponsorContractDescription_SponsorContract_SponsorContractId",
                        column: x => x.SponsorContractId,
                        principalTable: "SponsorContract",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SponsorContractSponsorRepresentative",
                columns: table => new
                {
                    RepresentativesId = table.Column<int>(type: "int", nullable: false),
                    SponsorContractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorContractSponsorRepresentative", x => new { x.RepresentativesId, x.SponsorContractId });
                    table.ForeignKey(
                        name: "FK_SponsorContractSponsorRepresentative_SponsorContract_SponsorContractId",
                        column: x => x.SponsorContractId,
                        principalTable: "SponsorContract",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponsorContractSponsorRepresentative_SponsorRepresentative_RepresentativesId",
                        column: x => x.RepresentativesId,
                        principalTable: "SponsorRepresentative",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accountants_PromoterAgenciesId",
                table: "Accountants",
                column: "PromoterAgenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistBand_MembersId",
                table: "ArtistBand",
                column: "MembersId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistDescription_ArtistId",
                table: "ArtistDescription",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistTag_TagsId",
                table: "ArtistTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_BandDescription_BandId",
                table: "BandDescription",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_BandTag_TagsId",
                table: "BandTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Booker_BookingAgencyId",
                table: "Booker",
                column: "BookingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BookerBookingAgencyBand_BookersId",
                table: "BookerBookingAgencyBand",
                column: "BookersId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAgencyBand_BandId",
                table: "BookingAgencyBand",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAgencyBand_BookingAgencyId",
                table: "BookingAgencyBand",
                column: "BookingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_id_person",
                table: "Client",
                column: "id_person");

            migrationBuilder.CreateIndex(
                name: "IX_EventArtist_idArtist",
                table: "EventArtist",
                column: "idArtist");

            migrationBuilder.CreateIndex(
                name: "IX_EventArtist_idEvent",
                table: "EventArtist",
                column: "idEvent");

            migrationBuilder.CreateIndex(
                name: "IX_EventDescriptions_EventId",
                table: "EventDescriptions",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTag_TagsId",
                table: "EventTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_EventVenue_VenuesId",
                table: "EventVenue",
                column: "VenuesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedEvent_idEvent",
                table: "FeaturedEvent",
                column: "idEvent");

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

            migrationBuilder.CreateIndex(
                name: "IX_Link_ArtistId",
                table: "Link",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_BandId",
                table: "Link",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_EventId",
                table: "Link",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_SponsorId",
                table: "Link",
                column: "SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_VenueId",
                table: "Link",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkDescription_LinkId",
                table: "LinkDescription",
                column: "LinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Policy_idPermission",
                table: "Policy",
                column: "idPermission");

            migrationBuilder.CreateIndex(
                name: "IX_Policy_idUserGroup",
                table: "Policy",
                column: "idUserGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Promoter_PromoterAgencyId",
                table: "Promoter",
                column: "PromoterAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PromoterAgencyTicketAgency_TicketAgencyId",
                table: "PromoterAgencyTicketAgency",
                column: "TicketAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_SectorId",
                table: "Seat",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sector_LinkId",
                table: "Sector",
                column: "LinkId",
                unique: true,
                filter: "[LinkId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SectorStage_StagesId",
                table: "SectorStage",
                column: "StagesId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContract_EventId",
                table: "SponsorContract",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContract_LineupId",
                table: "SponsorContract",
                column: "LineupId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContract_SponsorId",
                table: "SponsorContract",
                column: "SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContract_VenueId",
                table: "SponsorContract",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContractDescription_SponsorContractId",
                table: "SponsorContractDescription",
                column: "SponsorContractId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorContractSponsorRepresentative_SponsorContractId",
                table: "SponsorContractSponsorRepresentative",
                column: "SponsorContractId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorDescription_SponsorId",
                table: "SponsorDescription",
                column: "SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorRepresentative_SponsorId",
                table: "SponsorRepresentative",
                column: "SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_VenueId",
                table: "Stage",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_StageManager_VenueId",
                table: "StageManager",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_StageToStageManager_StageManagerId",
                table: "StageToStageManager",
                column: "StageManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_idClient",
                table: "Ticket",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_idTicketPool",
                table: "Ticket",
                column: "idTicketPool");

            migrationBuilder.CreateIndex(
                name: "IX_TicketAgent_TicketAgencyId",
                table: "TicketAgent",
                column: "TicketAgencyId");

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

            migrationBuilder.CreateIndex(
                name: "IX_User_id_group",
                table: "User",
                column: "id_group");

            migrationBuilder.CreateIndex(
                name: "IX_User_id_person",
                table: "User",
                column: "id_person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accountants");

            migrationBuilder.DropTable(
                name: "ArtistBand");

            migrationBuilder.DropTable(
                name: "ArtistDescription");

            migrationBuilder.DropTable(
                name: "ArtistTag");

            migrationBuilder.DropTable(
                name: "BandDescription");

            migrationBuilder.DropTable(
                name: "BandTag");

            migrationBuilder.DropTable(
                name: "BookerBookingAgencyBand");

            migrationBuilder.DropTable(
                name: "EventArtist");

            migrationBuilder.DropTable(
                name: "EventDescriptions");

            migrationBuilder.DropTable(
                name: "EventTag");

            migrationBuilder.DropTable(
                name: "EventVenue");

            migrationBuilder.DropTable(
                name: "FeaturedEvent");

            migrationBuilder.DropTable(
                name: "LinkDescription");

            migrationBuilder.DropTable(
                name: "Policy");

            migrationBuilder.DropTable(
                name: "Promoter");

            migrationBuilder.DropTable(
                name: "PromoterAgencyTicketAgency");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "SectorStage");

            migrationBuilder.DropTable(
                name: "SponsorContractDescription");

            migrationBuilder.DropTable(
                name: "SponsorContractSponsorRepresentative");

            migrationBuilder.DropTable(
                name: "SponsorDescription");

            migrationBuilder.DropTable(
                name: "StageToStageManager");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "TicketAgent");

            migrationBuilder.DropTable(
                name: "Booker");

            migrationBuilder.DropTable(
                name: "BookingAgencyBand");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "PromoterAgency");

            migrationBuilder.DropTable(
                name: "Sector");

            migrationBuilder.DropTable(
                name: "SponsorContract");

            migrationBuilder.DropTable(
                name: "SponsorRepresentative");

            migrationBuilder.DropTable(
                name: "StageManager");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "TicketPool");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "TicketAgency");

            migrationBuilder.DropTable(
                name: "BookingAgency");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "Lineup");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "TicketMediaType");

            migrationBuilder.DropTable(
                name: "TicketType");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Band");

            migrationBuilder.DropTable(
                name: "Sponsor");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "Venue");
        }
    }
}
