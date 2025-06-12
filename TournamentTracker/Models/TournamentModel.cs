using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Id for Tournament
        /// </summary>
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = [];
        public List<PriceModel> Prices { get; set; } = [];
        public List<List<MatchupModel>> Rounds { get; set; } = [];
    }
}
