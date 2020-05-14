using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLogger.Models.DataModels
{
    public class SportsLog
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        [Display(Name = "Person")]
        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        public int? SportId { get; set; }
        [Display(Name = "Sport")]
        [ForeignKey("SportId")]
        public Sport Sport { get; set; }

        [Display(Name = "Started")]
        public DateTime? DateTimeStart { get; set; }

        [Display(Name = "Ended")]
        public DateTime? DateTimeEnd { get; set; }

        [Display(Name = "Time in decimals ")]
        public decimal TimeSpent { get; set; }


    }
   
    public class Arena
    {
        public int Id { get; set; }

        [Display(Name = "#")]
        public string ArenaNumber { get; set; }

        [Display(Name = "Arena")]
        public string ArenaName { get; set; }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }

        [Display(Name = "District")]
        public int? DistrictId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        public int? ArenaStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("ArenaStatusId")]
        public ArenaStatus ArenaStatus { get; set; }

    }
    public class Club
    {
        public int Id { get; set; }

        // Club props !
        [Display(Name = "#")]
        public string ClubNumber { get; set; }

        [Display(Name = "Club")]
        public string ClubName { get; set; }

        [Display(Name = "Short name")]
        public string ShortName { get; set; }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }

        [Display(Name = "District")]
        public int? DistrictId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        [Display(Name = "Home Arena")]
        public int? ArenaId { get; set; }
        [Display(Name = "Home Arena")]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set; }

        public int? ClubStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("ClubStatusId")]
        public ClubStatus ClubStatus { get; set; }
    }
    public class District
    {
        public int Id { get; set; }

        [Display(Name = "District")]
        public string DistrictName { get; set; }
    }
    public class Game
    {
        public int Id { get; set; }

        //Game DateTime Prop !
        [Display(Name = "Date&Time")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime GameDateTime { get; set; }

        // Game Identification Prop!
        [Display(Name = "Game #")]
        public string GameNumber { get; set; }

        // Game TSM Idenfication Prop !
        [Display(Name = "TSM #")]
        public string TSMNumber { get; set; }

        // Game settings props !
        [Display(Name = "Category")]
        public int? GameCategoryId { get; set; }
        [Display(Name = "Category")]
        [ForeignKey("GameCategoryId")]
        public GameCategory GameCategory { get; set; }

        [Display(Name = "Status")]
        public int? GameStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("GameStatusId")]
        public GameStatus GameStatus { get; set; }

        [Display(Name = "Game Type")]
        public int? GameTypeId { get; set; }
        [Display(Name = "GameType")]
        [ForeignKey("GameTypeId")]
        public GameType GameType { get; set; }

        [Display(Name = "Series")]
        public int? SeriesId { get; set; }
        [Display(Name = "Series")]
        [ForeignKey("SeriesId")]
        public Series Series { get; set; }

        // Game location prop !
        [Display(Name = "Arena")]
        public int? ArenaId { get; set; }
        [Display(Name = "Arena")]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set; }

        // Game Teams Props !
        [Display(Name = "Home")]
        public int? ClubId { get; set; }
        [Display(Name = "Home")]
        [ForeignKey("ClubId")]
        public Club HomeTeam { get; set; }

        [Display(Name = "Away")]
        public int? ClubId1 { get; set; }
        [Display(Name = "Away")]
        [ForeignKey("ClubId1")]
        public Club AwayTeam { get; set; }

        // Game Result Props !
        [Display(Name = "Score Home Team")]
        public int? HomeTeamScore { get; set; }

        [Display(Name = "Score Away Team")]
        public int? AwayTeamScore { get; set; }

        [Display(Name = "Score")]
        public string Result { get { return string.Format("{0} {1} {2}", HomeTeamScore, "-", AwayTeamScore); } }

        // Game Ref props !
        [Display(Name = "HD")]
        public int? PersonId { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("PersonId")]
        public Person HD1 { get; set; }

        [Display(Name = "HD")]
        public int? PersonId1 { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("PersonId1")]
        public Person HD2 { get; set; }

        [Display(Name = "LD")]
        public int? PersonId2 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("PersonId2")]
        public Person LD1 { get; set; }

        [Display(Name = "LD")]
        public int? PersonId3 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("PersonId3")]
        public Person LD2 { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }

        // Person Setting props!
        public int? PersonRoleId { get; set; }
        [Display(Name = "Role")]
        [ForeignKey("PersonRoleId")]
        public PersonRole PersonRole { get; set; }

        public int? PersonStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("PersonStatusId")]
        public PersonStatus PersonStatus { get; set; }

        public int? PersonTypeId { get; set; }
        [Display(Name = "Person Type")]
        [ForeignKey("PersonTypeId")]
        public PersonType PersonType { get; set; }

        // Person Org props !
        public int? ClubId { get; set; }
        [Display(Name = "Club")]
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

        public int? DistrictId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        //Person Personalia !
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        //CName = Contact Name with Phonenumbers attached !
        public string CName { get { return string.Format("{0} {1} ", FullName, Ssn); } }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }

        [Display(Name = "SSN")]
        public string Ssn { get; set; }

        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }

        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Person Accounts !
        [Display(Name = "Swish #")]
        [DataType(DataType.PhoneNumber)]
        public string SwishNumber { get; set; }

        [Display(Name = "Bank #")]
        public string BankAccount { get; set; }

        [Display(Name = "Bank")]
        public string BankName { get; set; }

        [Display(Name = "Swish# and Bank#")]
        public string PaymentDetails { get { return string.Format("{0} {1}", SwishNumber, BankAccount); } }
    }

    public class Receipt
    {
        public int Id { get; set; }

        // Receipt settings props !
        [Display(Name = "Category")]
        public int? ReceiptCategoryId { get; set; }
        [Display(Name = "Category")]
        [ForeignKey("ReceiptCategoryId")]
        public ReceiptCategory ReceiptCategory { get; set; }

        [Display(Name = "Status")]
        public int? ReceiptStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("ReceiptStatusId")]
        public ReceiptStatus ReceiptStatus { get; set; }

        [Display(Name = "Receipt Type")]
        public int? ReceiptTypeId { get; set; }
        [Display(Name = "ReceiptType")]
        [ForeignKey("ReceiptTypeId")]
        public ReceiptType ReceiptType { get; set; }


        // Receipt Game Prop !
        [Display(Name = "Game")]
        public int? GameId { get; set; }
        [Display(Name = "Game")]
        [ForeignKey("GameId")]
        public Game Game { get; set; }

        // Fee calculations !
        // HD1
        [Display(Name = "FEE")]
        [DataType(DataType.Currency)]
        public int HD1Fee { get; set; } = 0;
        [Display(Name = "Travel")]
        [DataType(DataType.Currency)]
        public int HD1TravelKost { get; set; } = 0;
        [Display(Name = "Alowance")]
        [DataType(DataType.Currency)]
        public int HD1Alowens { get; set; } = 0;
        [Display(Name = "Lategame")]
        [DataType(DataType.Currency)]
        public int HD1LateGameKost { get; set; } = 0;
        [Display(Name = "Other")]
        [DataType(DataType.Currency)]
        public int HD1Other { get; set; } = 0;
        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public int HD1TotalFee { get; set; } = 0;

        //HD2
        [Display(Name = "FEE")]
        [DataType(DataType.Currency)]
        public int HD2Fee { get; set; } = 0;
        [Display(Name = "Travel")]
        [DataType(DataType.Currency)]
        public int HD2TravelKost { get; set; } = 0;
        [Display(Name = "Alowance")]
        [DataType(DataType.Currency)]
        public int HD2Alowens { get; set; } = 0;
        [Display(Name = "Lategame")]
        [DataType(DataType.Currency)]
        public int HD2LateGameKost { get; set; } = 0;
        [Display(Name = "Other")]
        [DataType(DataType.Currency)]
        public int HD2Other { get; set; } = 0;
        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public int HD2TotalFee { get; set; } = 0;

        // LD1
        [Display(Name = "FEE")]
        [DataType(DataType.Currency)]
        public int LD1Fee { get; set; } = 0;
        [Display(Name = "Travel")]
        [DataType(DataType.Currency)]
        public int LD1TravelKost { get; set; } = 0;
        [Display(Name = "Alowance")]
        [DataType(DataType.Currency)]
        public int LD1Alowens { get; set; } = 0;
        [Display(Name = "Lategame")]
        [DataType(DataType.Currency)]
        public int LD1LateGameKost { get; set; } = 0;
        [Display(Name = "Other")]
        [DataType(DataType.Currency)]
        public int LD1Other { get; set; } = 0;
        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public int LD1TotalFee { get; set; } = 0;

        //LD2
        [Display(Name = "FEE")]
        [DataType(DataType.Currency)]
        public int LD2Fee { get; set; } = 0;
        [Display(Name = "Travel")]
        [DataType(DataType.Currency)]
        public int LD2TravelKost { get; set; } = 0;
        [Display(Name = "Alowance")]
        [DataType(DataType.Currency)]
        public int LD2Alowens { get; set; } = 0;
        [Display(Name = "Lategame")]
        [DataType(DataType.Currency)]
        public int LD2LateGameKost { get; set; } = 0;
        [Display(Name = "Other")]
        [DataType(DataType.Currency)]
        public int LD2Other { get; set; } = 0;
        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public int LD2TotalFee { get; set; } = 0;
        // The Game total
        [Display(Name = "Game Total")]
        [DataType(DataType.Currency)]
        public int GameTotalKost { get; set; } = 0;

        //Accounting
        [Display(Name = "Amount Paid HD1")]
        [DataType(DataType.Currency)]
        public int AmountPaidHD1 { get; set; }


        [Display(Name = "Amount Paid HD2")]
        [DataType(DataType.Currency)]
        public int AmountPaidHD2 { get; set; }

        [Display(Name = "Amount Paid LD1")]
        [DataType(DataType.Currency)]
        public int AmountPaidLD1 { get; set; }

        [Display(Name = "Amount Paid LD2")]
        [DataType(DataType.Currency)]
        public int AmountPaidLD2 { get; set; }

        [Display(Name = "Total Amount Paid")]
        [DataType(DataType.Currency)]
        public int TotalAmountPaid { get; set; }

        [Display(Name = "Total Amount To Pay")]
        [DataType(DataType.Currency)]
        public int TotalAmountToPay { get; set; }

        [Display(Name = " 50 / 50 ")]
        [DataType(DataType.Currency)]
        public int HalfTotalAmountToPay { get; set; }

    }

    public class Series
    {
        public int Id { get; set; }


        [Display(Name = "Series")]
        public string SeriesName { get; set; }

        [Display(Name = "District")]
        public int? DistrictId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        [Display(Name = "Status")]
        public int? SeriesStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("SeriesStatusId")]
        public SeriesStatus SeriesStatus { get; set; }

        [Display(Name = "Series ADMIN")]
        public int? PersonId { get; set; }
        [Display(Name = "Series ADMIN")]
        [ForeignKey("PersonId")]
        public Person Admin { get; set; }

    }

    public class Sport
    {
        public int Id { get; set; }

        public string SportName { get; set; }
    }
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "Team")]
        public string TeamName { get; set; }

        [Display(Name = "Club")]
        public int? ClubId { get; set; }
        [Display(Name = "Club")]
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

        [Display(Name = "District")]
        public int? DistrictId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        [Display(Name = "Home Arena")]
        public int? ArenaId { get; set; }
        [Display(Name = "Home Arena")]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set; }
        //Team Series and Status !
        [Display(Name = "Series")]
        public int? SeriesId { get; set; }
        [Display(Name = "Series")]
        [ForeignKey("SeriesId")]
        public Series Series { get; set; }

        public int? TeamStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("TeamStatusId")]
        public TeamStatus TeamStatus { get; set; }

        ////Team Roster !

        //public int? TeamRosterId { get; set; }
        //[Display(Name = "Team Roster")]
        //[ForeignKey("TeamRosterId")]
        //public TeamRoster TeamRoster { get; set; }

    }

    public class Tournament
    {
        public int Id { get; set; }
        [Display(Name = "Tournament")]
        public string TournamentName { get; set; }

        //Tournament DateTime Prop !
        [Display(Name = "Date&Time")]
        public DateTime TournamentDateTime { get; set; }

        // Tournament settings props !   

        [Display(Name = "Type")]
        public int? TournamentTypeId { get; set; }
        [Display(Name = "Type")]
        [ForeignKey("TournamentTypeId")]
        public TournamentType TournamentType { get; set; }

        //Tournament Games !
        // #1
        [Display(Name = "#1")]
        public int? GameId { get; set; }
        [Display(Name = "#1")]
        [ForeignKey("GameId")]
        public Game Game1 { get; set; }
        // #2
        [Display(Name = "#2")]
        public int? GameId1 { get; set; }
        [Display(Name = "#2")]
        [ForeignKey("GameId1")]
        public Game Game2 { get; set; }
        // #3
        [Display(Name = "#3")]
        public int? GameId2 { get; set; }
        [Display(Name = "#3")]
        [ForeignKey("GameId2")]
        public Game Game3 { get; set; }
        // #4
        [Display(Name = "#4")]
        public int? GameId3 { get; set; }
        [Display(Name = "#4")]
        [ForeignKey("GameId3")]
        public Game Game4 { get; set; }
        // #5
        [Display(Name = "#5")]
        public int? GameId4 { get; set; }
        [Display(Name = "#5")]
        [ForeignKey("GameId4")]
        public Game Game5 { get; set; }

        // #6
        [Display(Name = "#6")]
        public int? GameId5 { get; set; }
        [Display(Name = "#6")]
        [ForeignKey("GameId5")]
        public Game Game6 { get; set; }
        // #7
        [Display(Name = "#7")]
        public int? GameId6 { get; set; }
        [Display(Name = "#7")]
        [ForeignKey("GameId6")]
        public Game Game7 { get; set; }
        // #8
        [Display(Name = "#8")]
        public int? GameId7 { get; set; }
        [Display(Name = "#8")]
        [ForeignKey("GameId7")]
        public Game Game8 { get; set; }
        // #9
        [Display(Name = "#9")]
        public int? GameId8 { get; set; }
        [Display(Name = "#9")]
        [ForeignKey("GameId8")]
        public Game Game9 { get; set; }

        // #10
        [Display(Name = "#10")]
        public int? GameId9 { get; set; }
        [Display(Name = "#10")]
        [ForeignKey("GameId9")]
        public Game Game10 { get; set; }
        // #11
        [Display(Name = "#11")]
        public int? GameId10 { get; set; }
        [Display(Name = "#11")]
        [ForeignKey("GameId10")]
        public Game Game11 { get; set; }
        // #12
        [Display(Name = "#12")]
        public int? GameId11 { get; set; }
        [Display(Name = "#12")]
        [ForeignKey("GameId11")]
        public Game Game12 { get; set; }
        // #13
        [Display(Name = "#13")]
        public int? GameId12 { get; set; }
        [Display(Name = "#13")]
        [ForeignKey("GameId12")]
        public Game Game13 { get; set; }
        // #14
        [Display(Name = "#14")]
        public int? GameId13 { get; set; }
        [Display(Name = "#14")]
        [ForeignKey("GameId13")]
        public Game Game14 { get; set; }
        // #15
        [Display(Name = "#15")]
        public int? GameId14 { get; set; }
        [Display(Name = "#15")]
        [ForeignKey("GameId14")]
        public Game Game15 { get; set; }

    }


    //SettingsModels

    public class ArenaStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ArenaStatusName { get; set; }
    }
    public class ClubStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ClubStatusName { get; set; }
    }
    public class GameCategory
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string GameCategoryName { get; set; }
    }
    public class GameStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string GameStatusName { get; set; }
    }
    public class GameType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string GameTypeName { get; set; }
    }
    public class PersonRole
    {
        public int Id { get; set; }

        [Display(Name = "Role")]
        public string PersonRoleName { get; set; }
    }
    public class PersonStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string PersonStatusName { get; set; }
    }
    public class PersonType
    {
        public int Id { get; set; }

        [Display(Name = "Person Type")]
        public string PersonTypeName { get; set; }
    }
    public class ReceiptCategory
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string ReceiptCategoryName { get; set; }
    }
    public class ReceiptStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ReceiptStatusName { get; set; }
    }
    public class ReceiptType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string ReceiptTypeName { get; set; }
    }
    public class SeriesStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string SeriesStatusName { get; set; }
    }
    public class TeamStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string TeamStatusName { get; set; }
    }
    public class TournamentType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string TournamentTypeName { get; set; }
    }
    public class Zone
    {
        public int Id { get; set; }

        [Display(Name = "Zone")]
        public string ZoneName { get; set; }
    }





}
