using SportsLogger.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLogger.Models.ViewModels
{
    public class SPLViewModel
    {
        /// <summary>
        /// Entities !
        /// </summary>
        public List<Arena> Arenas { get; internal set; }

        public List<Club> Clubs { get; internal set; }

        public List<District> Districts { get; internal set; }

        public List<Game> Games { get; internal set; }

        public List<Person> People { get; internal set; }

        public List<Receipt> Receipts { get; internal set; }

        public List<Series> Series { get; internal set; }

        public List<Team> Teams { get; internal set; }

        public List<Tournament> Tournaments { get; internal set; }

        public List<Zone> Zones { get; internal set; }

        /// <summary>
        /// Settings !
        /// </summary>

        public List<ArenaStatus> ArenaStatuses { get; internal set; }

        public List<ClubStatus> ClubStatuses { get; internal set; }

        public List<GameCategory> GameCategories { get; internal set; }

        public List<GameStatus> GameStatuses { get; internal set; }

        public List<GameType> GameTypes { get; internal set; }

        public List<PersonRole> PersonRoles { get; internal set; }

        public List<PersonStatus> PersonStatuses { get; internal set; }

        public List<PersonType> PersonTypes { get; internal set; }

        public List<ReceiptCategory> ReceiptCategories { get; internal set; }

        public List<ReceiptStatus> ReceiptStatuses { get; internal set; }

        public List<ReceiptType> ReceiptTypes { get; internal set; }

        public List<SeriesStatus> SeriesStatuses { get; internal set; }

        public List<TeamStatus> TeamStatuses { get; internal set; }

        public List<TournamentType> TournamentTypes { get; internal set; }         

        

    }
}
