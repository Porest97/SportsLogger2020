using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsLogger.Models.DataModels;

namespace SportsLogger.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SportsLogger.Models.DataModels.Arena> Arena { get; set; }
        public DbSet<SportsLogger.Models.DataModels.ArenaStatus> ArenaStatus { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Club> Club { get; set; }
        public DbSet<SportsLogger.Models.DataModels.ClubStatus> ClubStatus { get; set; }
        public DbSet<SportsLogger.Models.DataModels.District> District { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Game> Game { get; set; }
        public DbSet<SportsLogger.Models.DataModels.GameCategory> GameCategory { get; set; }
        public DbSet<SportsLogger.Models.DataModels.GameStatus> GameStatus { get; set; }
        public DbSet<SportsLogger.Models.DataModels.GameType> GameType { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Person> Person { get; set; }
        public DbSet<SportsLogger.Models.DataModels.PersonRole> PersonRole { get; set; }
        public DbSet<SportsLogger.Models.DataModels.PersonStatus> PersonStatus { get; set; }
        public DbSet<SportsLogger.Models.DataModels.PersonType> PersonType { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Receipt> Receipt { get; set; }
        public DbSet<SportsLogger.Models.DataModels.ReceiptCategory> ReceiptCategory { get; set; }
        public DbSet<SportsLogger.Models.DataModels.ReceiptStatus> ReceiptStatus { get; set; }
        public DbSet<SportsLogger.Models.DataModels.ReceiptType> ReceiptType { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Series> Series { get; set; }
        public DbSet<SportsLogger.Models.DataModels.SeriesStatus> SeriesStatus { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Sport> Sport { get; set; }
        public DbSet<SportsLogger.Models.DataModels.SportsLog> SportsLog { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Team> Team { get; set; }
        public DbSet<SportsLogger.Models.DataModels.TeamStatus> TeamStatus { get; set; }
        public DbSet<SportsLogger.Models.DataModels.TournamentType> TournamentType { get; set; }
        public DbSet<SportsLogger.Models.DataModels.Tournament> Tournament { get; set; }
       
    }
}
