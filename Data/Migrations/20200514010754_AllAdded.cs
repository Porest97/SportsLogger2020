using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsLogger.Data.Migrations
{
    public partial class AllAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArenaStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArenaStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArenaStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClubStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonRoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TournamentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArenaNumber = table.Column<string>(nullable: true),
                    ArenaName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    ArenaStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arena_ArenaStatus_ArenaStatusId",
                        column: x => x.ArenaStatusId,
                        principalTable: "ArenaStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arena_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubNumber = table.Column<string>(nullable: true),
                    ClubName = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    ArenaId = table.Column<int>(nullable: true),
                    ClubStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Club_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Club_ClubStatus_ClubStatusId",
                        column: x => x.ClubStatusId,
                        principalTable: "ClubStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Club_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonRoleId = table.Column<int>(nullable: true),
                    PersonStatusId = table.Column<int>(nullable: true),
                    PersonTypeId = table.Column<int>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Ssn = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SwishNumber = table.Column<string>(nullable: true),
                    BankAccount = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_PersonRole_PersonRoleId",
                        column: x => x.PersonRoleId,
                        principalTable: "PersonRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_PersonStatus_PersonStatusId",
                        column: x => x.PersonStatusId,
                        principalTable: "PersonStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_PersonType_PersonTypeId",
                        column: x => x.PersonTypeId,
                        principalTable: "PersonType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesName = table.Column<string>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    SeriesStatusId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_SeriesStatus_SeriesStatusId",
                        column: x => x.SeriesStatusId,
                        principalTable: "SeriesStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SportsLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: true),
                    SportId = table.Column<int>(nullable: true),
                    DateTimeStart = table.Column<DateTime>(nullable: true),
                    DateTimeEnd = table.Column<DateTime>(nullable: true),
                    TimeSpent = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportsLog_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SportsLog_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDateTime = table.Column<DateTime>(nullable: false),
                    GameNumber = table.Column<string>(nullable: true),
                    TSMNumber = table.Column<string>(nullable: true),
                    GameCategoryId = table.Column<int>(nullable: true),
                    GameStatusId = table.Column<int>(nullable: true),
                    GameTypeId = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true),
                    ArenaId = table.Column<int>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    ClubId1 = table.Column<int>(nullable: true),
                    HomeTeamScore = table.Column<int>(nullable: true),
                    AwayTeamScore = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true),
                    PersonId3 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Club_ClubId1",
                        column: x => x.ClubId1,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_GameCategory_GameCategoryId",
                        column: x => x.GameCategoryId,
                        principalTable: "GameCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_GameType_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    ArenaId = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true),
                    TeamStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_TeamStatus_TeamStatusId",
                        column: x => x.TeamStatusId,
                        principalTable: "TeamStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptCategoryId = table.Column<int>(nullable: true),
                    ReceiptStatusId = table.Column<int>(nullable: true),
                    ReceiptTypeId = table.Column<int>(nullable: true),
                    GameId = table.Column<int>(nullable: true),
                    HD1Fee = table.Column<int>(nullable: false),
                    HD1TravelKost = table.Column<int>(nullable: false),
                    HD1Alowens = table.Column<int>(nullable: false),
                    HD1LateGameKost = table.Column<int>(nullable: false),
                    HD1Other = table.Column<int>(nullable: false),
                    HD1TotalFee = table.Column<int>(nullable: false),
                    HD2Fee = table.Column<int>(nullable: false),
                    HD2TravelKost = table.Column<int>(nullable: false),
                    HD2Alowens = table.Column<int>(nullable: false),
                    HD2LateGameKost = table.Column<int>(nullable: false),
                    HD2Other = table.Column<int>(nullable: false),
                    HD2TotalFee = table.Column<int>(nullable: false),
                    LD1Fee = table.Column<int>(nullable: false),
                    LD1TravelKost = table.Column<int>(nullable: false),
                    LD1Alowens = table.Column<int>(nullable: false),
                    LD1LateGameKost = table.Column<int>(nullable: false),
                    LD1Other = table.Column<int>(nullable: false),
                    LD1TotalFee = table.Column<int>(nullable: false),
                    LD2Fee = table.Column<int>(nullable: false),
                    LD2TravelKost = table.Column<int>(nullable: false),
                    LD2Alowens = table.Column<int>(nullable: false),
                    LD2LateGameKost = table.Column<int>(nullable: false),
                    LD2Other = table.Column<int>(nullable: false),
                    LD2TotalFee = table.Column<int>(nullable: false),
                    GameTotalKost = table.Column<int>(nullable: false),
                    AmountPaidHD1 = table.Column<int>(nullable: false),
                    AmountPaidHD2 = table.Column<int>(nullable: false),
                    AmountPaidLD1 = table.Column<int>(nullable: false),
                    AmountPaidLD2 = table.Column<int>(nullable: false),
                    TotalAmountPaid = table.Column<int>(nullable: false),
                    TotalAmountToPay = table.Column<int>(nullable: false),
                    HalfTotalAmountToPay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipt_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipt_ReceiptCategory_ReceiptCategoryId",
                        column: x => x.ReceiptCategoryId,
                        principalTable: "ReceiptCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipt_ReceiptStatus_ReceiptStatusId",
                        column: x => x.ReceiptStatusId,
                        principalTable: "ReceiptStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipt_ReceiptType_ReceiptTypeId",
                        column: x => x.ReceiptTypeId,
                        principalTable: "ReceiptType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentName = table.Column<string>(nullable: true),
                    TournamentDateTime = table.Column<DateTime>(nullable: false),
                    TournamentTypeId = table.Column<int>(nullable: true),
                    GameId = table.Column<int>(nullable: true),
                    GameId1 = table.Column<int>(nullable: true),
                    GameId2 = table.Column<int>(nullable: true),
                    GameId3 = table.Column<int>(nullable: true),
                    GameId4 = table.Column<int>(nullable: true),
                    GameId5 = table.Column<int>(nullable: true),
                    GameId6 = table.Column<int>(nullable: true),
                    GameId7 = table.Column<int>(nullable: true),
                    GameId8 = table.Column<int>(nullable: true),
                    GameId9 = table.Column<int>(nullable: true),
                    GameId10 = table.Column<int>(nullable: true),
                    GameId11 = table.Column<int>(nullable: true),
                    GameId12 = table.Column<int>(nullable: true),
                    GameId13 = table.Column<int>(nullable: true),
                    GameId14 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId1",
                        column: x => x.GameId1,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId10",
                        column: x => x.GameId10,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId11",
                        column: x => x.GameId11,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId12",
                        column: x => x.GameId12,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId13",
                        column: x => x.GameId13,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId14",
                        column: x => x.GameId14,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId2",
                        column: x => x.GameId2,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId3",
                        column: x => x.GameId3,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId4",
                        column: x => x.GameId4,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId5",
                        column: x => x.GameId5,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId6",
                        column: x => x.GameId6,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId7",
                        column: x => x.GameId7,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId8",
                        column: x => x.GameId8,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Game_GameId9",
                        column: x => x.GameId9,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_TournamentType_TournamentTypeId",
                        column: x => x.TournamentTypeId,
                        principalTable: "TournamentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arena_ArenaStatusId",
                table: "Arena",
                column: "ArenaStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Arena_DistrictId",
                table: "Arena",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Club_ArenaId",
                table: "Club",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Club_ClubStatusId",
                table: "Club",
                column: "ClubStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Club_DistrictId",
                table: "Club",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_ArenaId",
                table: "Game",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_ClubId",
                table: "Game",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_ClubId1",
                table: "Game",
                column: "ClubId1");

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameCategoryId",
                table: "Game",
                column: "GameCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameStatusId",
                table: "Game",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameTypeId",
                table: "Game",
                column: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId",
                table: "Game",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId1",
                table: "Game",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId2",
                table: "Game",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId3",
                table: "Game",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_Game_SeriesId",
                table: "Game",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ClubId",
                table: "Person",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DistrictId",
                table: "Person",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonRoleId",
                table: "Person",
                column: "PersonRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonStatusId",
                table: "Person",
                column: "PersonStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonTypeId",
                table: "Person",
                column: "PersonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_GameId",
                table: "Receipt",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ReceiptCategoryId",
                table: "Receipt",
                column: "ReceiptCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ReceiptStatusId",
                table: "Receipt",
                column: "ReceiptStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ReceiptTypeId",
                table: "Receipt",
                column: "ReceiptTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_DistrictId",
                table: "Series",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_PersonId",
                table: "Series",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesStatusId",
                table: "Series",
                column: "SeriesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsLog_PersonId",
                table: "SportsLog",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsLog_SportId",
                table: "SportsLog",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ArenaId",
                table: "Team",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ClubId",
                table: "Team",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_DistrictId",
                table: "Team",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_SeriesId",
                table: "Team",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_TeamStatusId",
                table: "Team",
                column: "TeamStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId",
                table: "Tournament",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId1",
                table: "Tournament",
                column: "GameId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId10",
                table: "Tournament",
                column: "GameId10");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId11",
                table: "Tournament",
                column: "GameId11");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId12",
                table: "Tournament",
                column: "GameId12");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId13",
                table: "Tournament",
                column: "GameId13");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId14",
                table: "Tournament",
                column: "GameId14");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId2",
                table: "Tournament",
                column: "GameId2");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId3",
                table: "Tournament",
                column: "GameId3");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId4",
                table: "Tournament",
                column: "GameId4");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId5",
                table: "Tournament",
                column: "GameId5");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId6",
                table: "Tournament",
                column: "GameId6");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId7",
                table: "Tournament",
                column: "GameId7");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId8",
                table: "Tournament",
                column: "GameId8");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameId9",
                table: "Tournament",
                column: "GameId9");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_TournamentTypeId",
                table: "Tournament",
                column: "TournamentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "SportsLog");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropTable(
                name: "ReceiptCategory");

            migrationBuilder.DropTable(
                name: "ReceiptStatus");

            migrationBuilder.DropTable(
                name: "ReceiptType");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "TeamStatus");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "TournamentType");

            migrationBuilder.DropTable(
                name: "GameCategory");

            migrationBuilder.DropTable(
                name: "GameStatus");

            migrationBuilder.DropTable(
                name: "GameType");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "SeriesStatus");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "PersonRole");

            migrationBuilder.DropTable(
                name: "PersonStatus");

            migrationBuilder.DropTable(
                name: "PersonType");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropTable(
                name: "ClubStatus");

            migrationBuilder.DropTable(
                name: "ArenaStatus");

            migrationBuilder.DropTable(
                name: "District");
        }
    }
}
